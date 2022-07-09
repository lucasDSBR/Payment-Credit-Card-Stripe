# API-.NETCore

- **Estrutura:**
    - Api.Application
    - Api.Domain
    - Api.CrossCutting
    - Api.Data
    - Api.Service


## Pacotes instalados:
    - Microsoft.EntityFrameworkCore.SqlServer
        -  dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 3.1.6
    - Pomelo.EntityFrameworkCore.MySql
        -  dotnet add package Pomelo.EntityFrameworkCore.MySql --version 3.1.1
    - Microsoft.EntityFrameworkCore.Tools 
        -  dotnet add package Microsoft.EntityFrameworkCore.Tools --version 3.1.6
    - Microsoft.EntityFrameworkCore.Design 
        -  dotnet add package Microsoft.EntityFrameworkCore.Design --version 3.1.6
    - AutoMapper.Extensions.Microsoft.DependencyInjection
        - dotnet add package AutoMapper.Extensions.Microsoft.DependencyInjection --version 6.1.1
    - System.IdentityModel.Tokens.Jwt
        - dotnet add package System.IdentityModel.Tokens.Jwt --version 5.5.0
    - Microsoft.AspNetCore.Authentication.JwtBearer
        - dotnet add package Microsoft.AspNetCore.Authentication.JwtBearer --version 3.1.6


## Criando banco de dados
    - dotnet: dotnet ef migrations add <Nome da migração>
    - dotnet: dotnet ef database update


