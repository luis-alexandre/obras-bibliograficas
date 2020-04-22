#!/bin/bash

cd webapi/Guide.ObrasLiterarias.Api/
dotnet restore
dotnet publish -c release -o ./publish -r linux-x64 
docker build -t guide/webapi:1.0 .

cd ..
cd ..

cd webapp/ObrasLit/
docker build -t guide/webapp:1.0 .

cd ..
cd ..

docker-compose up