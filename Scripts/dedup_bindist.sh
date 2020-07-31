#!/bin/bash
set -euo pipefail

# Our build consists of separate "dotnet publish" commands that are
# directed to separate subdirectories of the output.

primary="runtime"
secondary=" coord codegen unsafedereg "

if [ $# -eq 0 ]; then
    mode=symlink
elif [ "$1" == "symlink" ]; then
     mode=symlink
elif [ "$1" == "squish" ]; then
     mode=squish
else
    echo "ERROR: expected 'symlink' or 'squish' as optional first argument (default symlink)."
    exit 1
fi

# Helpers
# ------------------------------------------------------------



# Compute the relative path to A starting from directory B
# Output the resulting relative path to stdout.
if which realpath 2>&1 >/dev/null ; then
    
    function getrelative() {
        realpath "$1" --relative-to="$2"
    }
    
elif which python 2>&1 >/dev/null ; then

    function getrelative() {
        python -c "import os,sys;print(os.path.relpath(*(sys.argv[1:])))" "$1" "$2"
    }
        
# elif which perl; then
else
    echo "ERROR $0: can't find an easy way to compute relative paths on this system."
    exit 1
fi

# ------------------------------------------------------------

echo "Begin script in mode = $mode"

cd `dirname $0`/../bin
bindir=`pwd -P`
echo "Total files in bin/: "`find . | wc -l`

for dir in $secondary; do
    echo
    echo "Processing $dir"
    cd "$bindir/$dir"
    echo "  Files: "`ls | wc -l`
    dups=`mktemp /tmp/dupslist.XXXXX`
    echo "  Comparing ../$primary/ ./"
    
    diffs=`mktemp`
    diff -srq ../$primary/ ./ > $diffs || true
    echo "  Computed diffs..."
    echo "  Number of diffs: $(cat $diffs | wc -l)"
    
    # FRAGILE:
    # Expects Files __ and __ are identical
    cat $diffs | grep identical \
               | awk '{ print $4 }' \
               > $dups || true
    
    echo "  Found $(cat $dups | wc -l) duplicates."
    case $mode in
        symlink)
            echo -ne "  Linking: " ;;
        squish)
            echo -ne "  Deleting dups: " ;;
    esac
    case $mode in
        squish)
            xargs rm -f < $dups
            ;;        
        symlink)
            while read f; do        
                echo -ne "."
                dirof=`dirname $f`
                relativepath=$(getrelative "../runtime/$f" "$dirof")
                ln -sf $relativepath $f
            done < $dups
            echo
            ;;
    esac
    rm $diffs
    rm $dups
done

echo "Done with all subdirectories."

if [ $mode == symlink ]; then 

    echo " |-> Looking for broken links:"
    cd "$bindir"
    broken=`mktemp`
    find . -type l ! -exec test -e {} \; -print | tee $broken    

    if [ "$(cat $broken)" == "" ];
    then
        echo " |-> No broken links found."
    else
        echo
        echo "WARNING: found broken links."
        echo "Number of broken: $(cat $broken | wc -l)"
        echo "Sample:"
        head -n10 $broken
        #exit 1
    fi
else
    echo
    echo "In squishing mode, so smashing it back together."
    echo "Clearing main exe symlinks."
    cd "$bindir"
    rm -f ambrosia AmbrosiaCS ImmortalCoordinator UnsafeDeregisterInstance
    
    cd "$bindir/$primary"
    mv -n * ..

    echo "Removing redundant localization stuff."
    cd "$bindir"
    rm -rf */cs */de */es */fr */it */ja */ko */pl */pt-BR */ru */tr */zh-Hans */zh-Hant
    
    for dir in $secondary; do
        echo "  Dumping back in $dir contents"
        cd "$bindir/$dir"
        mv -n * ..
    done
    echo 
    echo "After squishing, these files left behind / conflicting:"
    echo "-------------------------------------------------------"
    cd "$bindir"
    find $secondary
    echo "-------------------------------------------------------"
    echo "Every one of these represents a risk of undefined behavior!"
    echo
fi
