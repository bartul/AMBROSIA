#!/bin/bash
set -euo pipefail

# Requires: Bash shell on Windows (cygwin/Git bash), Linux, or Mac OS.
#
# This script builds FOUR docker containers:
#  (1) ambrosia-dev: the core library, sources, and binaries
#  (2) ambrosia: the binary release only
#  (3) ambrosia-perftest: an example application C#
#  (4) ambrosia-nativeapp: an example application C/Nativecode
# 
# Run this inside a fresh working copy.

TAG1A=ambrosia/ambrosia-dev
TAG1B=ambrosia/ambrosia
TAG2=ambrosia/ambrosia-perftest
TAG3=ambrosia/ambrosia-nativeapp

if ! [[ ${DOCKER:+defined} ]]; then
   DOCKER=docker
fi

export AMBROSIA_ROOT=`pwd`

# Default logs location:
if [ `uname` == "Linux" ]; then
    AMBROSIA_LOGDIR="/tmp/logs"
else
    AMBROSIA_LOGDIR="c:\\logs"
fi

echo "================================================================================"
if [[ ${DONT_BUILD_APP_IMAGES:+defined} ]];
then echo "Building Docker images: $TAG1A, $TAG1B"
else echo "Building Docker images: $TAG1A, $TAG1B, $TAG2, $TAG3"
fi
echo "================================================================================"
echo
    
$DOCKER build -t ${TAG1A} .

if ! [[ ${DONT_BUILD_RELEASE_IMAGE:+defined} ]]; then
    echo;echo "Building Release Image: $TAG1B"; echo
    $DOCKER build -f Dockerfile.release -t ${TAG1B} .
fi

if ! [[ ${DONT_BUILD_APP_IMAGES:+defined} ]]; then

    if ! [[ ${DONT_BUILD_PTI_IMAGE:+defined} ]]; then
        echo;echo "Building App Image: $TAG2"; echo
	      cd "$AMBROSIA_ROOT"/InternalImmortals/PerformanceTestInterruptible
	      $DOCKER build -t ${TAG2} .
	      cd "$AMBROSIA_ROOT"
    fi
    if ! [[ ${DONT_BUILD_NATIVE_IMAGE:+defined} ]]; then
        echo;echo "Building App Image: $TAG3"; echo
	      cd "$AMBROSIA_ROOT"/InternalImmortals/NativeService
	      docker build -t ${TAG3} .
	      cd "$AMBROSIA_ROOT"
    fi
fi

echo
echo "Docker images built successfully."
echo
echo "Below is an example command bring up the generated image interactively:"
echo "  $DOCKER run -it --rm --env AZURE_STORAGE_CONN_STRING=... ${TAG2}"

if ! [[ ${DONT_BUILD_TARBALL:+defined} ]]; then
    echo
    echo "Extracting a release tarball..."
    set -x
    rm -rf ambrosia.tgz
    TMPCONT=temp-container-name_`date '+%s'`
    $DOCKER run --name $TMPCONT $TAG1A bash -c 'tar czf /ambrosia/ambrosia.tgz /ambrosia/bin'
    $DOCKER cp $TMPCONT:/ambrosia/ambrosia.tgz ambrosia.tgz
    $DOCKER rm $TMPCONT
    set +x
fi
