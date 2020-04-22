# Obras Bibliográficas

## Requisitos

* .NET Core 2.2
* .Node JS v10 ou superior
* Angular 9
* Docker Tools (para execução de containers)

## Estrutura da solução

A solução está dividida em dois projetos: Web API (backend) e Web App (Frontend).

###### Web API
Para a projeto de Web API foi construído utilizando .NET Core 2.2 e o DDD (Domain Drive Design).
O Projeto está dividido da seguinte forma:

* Guide.ObrasLiterarias.Api: responsável por expor as operações da api.
* Guide.ObrasLiterarias.Domain: contém todos as interfaces e entidades utilizado pelos demais projetos da solução.
* Guide.ObrasLiterarias.Infra: acesso ao banco de dados. Foi utilizado SQLite e Dapper para simular as transações com o banco de dados.
* Guide.ObrasLiterarias.Services: contém as regras de negócios especificadas no teste.
* Guide.ObrasLiterarias.UnitTest: teste unitário para as projetos da solução. Nesse projeto foram construídos os testes unitários focados na regra de negócio.

###### Web App
Para o projeto de Web App foi utilizado Angular 9. Os componentes e serviços foram criados com o nome "citacao-create".
Todos os itens do projeto Web App estão localizados dentro da pasta "/src/webapp/ObrasLit/src/app/".

## Como executar a aplicação

###### Executar de forma automática

Para iniciar as aplicações execute o arquivo **deploy.bat** ou **deploy.sh** dentro da pasta "src/".

Esse arquivo contém **todas as instruções necessárias para realizar o build e construção de imagens Docker para cada projeto**.
Execute o arquivo ou siga os comandos que estão dentro dele.

Após as imagens construídas com sucesso, um arquivo docker-compose é inicializado e consequentemente os containers de cada imagem são criados.

Para acessar cada projeto utilize o caminho abaixo após o docker compose file for inicializado:
* Web App: http://localhost:4200
* Web Api: http://localhost:5000/swagger/


###### Executar de forma manual

Todos os comandos foram testados utilizando Powershell.
Para executar a Web API, dentro da pasta "src\webapi\Guide.ObrasLiterarias.Api" execute os comandos abaixo:

* dotnet restore
* dotnet publish -c release -o ./publish
* entre na pasta "publish"
* Configure a variável de ambiente para a database executando o comando: **[Environment]::SetEnvironmentVariable("databaseFile", "databaseFile.db3", "User")**
* inicie a aplicação: dotnet .\Guide.ObrasLiterarias.Api.dll 
* abra a o swagger da api: http://localhost:5000/swagger

Para executar a Web App, dentro da pasta "src\webapp\ObrasLit" execute os comandos abaixo:

* ng serve
* abra a aplicação utilizando este endereço: http://localhost:4200
