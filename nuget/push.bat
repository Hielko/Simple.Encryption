@echo off

@rem nuget.exe push "*.nupkg" -ApiKey AzureDevOps -source "SimpleEncryption"

nuget.exe push "..\SimpleEncryption\bin\Release\SimpleEncryption.1.0.0.nupkg" -ApiKey AzureDevOps -source "SimpleEncryption" -SkipDuplicate

PAUSE