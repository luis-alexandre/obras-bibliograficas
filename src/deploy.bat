REM ### criando container para web api

cd webapi\Guide.ObrasLiterarias.Api
dotnet restore
dotnet publish -c release -o ./publish -r linux-x64 
docker build -t guide/webapi:1.0 .

REM # docker run -it -p:5000:80 guide/webapi:1.0
cd ..
cd ..

REM ### criando container para web app

cd webapp\ObrasLit
docker build -t guide/webapp:1.0 .

REM #docker run -it -p 4200:80   
cd ..
cd ..

docker-compose up