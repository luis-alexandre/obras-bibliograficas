dotnet restore .\webapi\Guide.ObrasLiterarias.Api
dotnet publish .\webapi\Guide.ObrasLiterarias.Api -c release -o ./publish -r linux-x64 
docker build -t .\webapi\Guide.ObrasLiterarias.Api guide/webapi:1.0 . 