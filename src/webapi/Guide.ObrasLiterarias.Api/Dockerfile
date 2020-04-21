FROM mcr.microsoft.com/dotnet/core/runtime:3.1-bionic
WORKDIR /app

ENV ASPNETCORE_ENVIRONMENT=Production
ENV databaseFile=databaseFile.db3

COPY ./publish .
ENTRYPOINT ["dotnet", "Guide.ObrasLiterarias.Api.dll"]