# Perform the code-generation step for this example application.
if ( $env:AMBVARIANTCORE ) {
    $AMBVARIANTCORE=$env:AMBVARIANTCORE
} else {
    $AMBVARIANTCORE = "x64\Debug\netcoreapp2.0"
}

if ( $env:AMBROSIATOOLS ) {
    $AMBROSIATOOLS=$env:AMBROSIATOOLS
} else {
    $AMBROSIATOOLS = "..\..\Clients\CSharp\AmbrosiaCS\bin"
}

Write-Host "Using variant of AmbrosiaCS: $AMBVARIANTCORE"

# Generate the assemblies, assumes an .exe which is created by a .Net Framework build:
Write-Host "Executing codegen command: dotnet $AMBROSIATOOLS\$AMBVARIANTCORE\AmbrosiaCS.dll CodeGen -a=DashboardAPI\bin\$AMBVARIANTCORE\DashboardAPI.dll -o=DashboardAPIGenerated -f=net46 -f=netcoreapp2.0"
& dotnet $AMBROSIATOOLS\$AMBVARIANTCORE\AmbrosiaCS.dll CodeGen -a="DashboardAPI\bin\$AMBVARIANTCORE\DashboardAPI.dll" -o="DashboardAPIGenerated" -f="net46" -f="netcoreapp2.0"

Write-Host "Executing codegen command: dotnet $AMBROSIATOOLS\$AMBVARIANTCORE\AmbrosiaCS.dll CodeGen -a=DashboardAPI\bin\$AMBVARIANTCORE\DashboardAPI.dll -a=AnalyticsAPI\bin\$AMBVARIANTCORE\AnalyticsAPI.dll -o=AnalyticsAPIGenerated -f=net46 -f=netcoreapp2.0"
& dotnet $AMBROSIATOOLS\$AMBVARIANTCORE\AmbrosiaCS.dll CodeGen -a="DashboardAPI\bin\$AMBVARIANTCORE\DashboardAPI.dll" -a="AnalyticsAPI\bin\$AMBVARIANTCORE\AnalyticsAPI.dll" -o="AnalyticsAPIGenerated" -f="net46" -f="netcoreapp2.0"