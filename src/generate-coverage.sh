#!/bin/bash

rm -rf coveragereport
rm -rf BrinquedoTest/TestResults

dotnet test --collect:"XPlat Code Coverage"

uuid_coverage=$(ls BrinquedoTest/TestResults | tail -1)

dotnet test --collect:"XPlat Code Coverage"

reportgenerator -reports:"./BrinquedoTest/TestResults/${uuid_coverage}/coverage.cobertura.xml" -targetdir:"coveragereport" -reporttypes:Html