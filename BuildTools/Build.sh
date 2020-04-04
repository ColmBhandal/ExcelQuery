#!/bin/bash

./BuildTools/UpdateVersion.sh

dotnet build --configuration Release
dotnet pack ExcelQuery/ExcelQuery.csproj --configuration Release
