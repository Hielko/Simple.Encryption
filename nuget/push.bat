@echo off

@rem nuget.exe push "*.nupkg" -ApiKey AzureDevOps -source "Perplex"

nuget.exe push "..\Encryption\bin\Release\Perplex.Encryption.1.0.10.nupkg" -ApiKey AzureDevOps -source "Perplex" -SkipDuplicate

PAUSE