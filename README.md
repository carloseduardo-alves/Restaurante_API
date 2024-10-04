# Restaurante_API

Este projeto é uma API RESTful desenvolvida em ASP.NET Core que permite a gestão de restaurantes e seus pratos associados. Com a **Restaurante_API**, é possível realizar operações de CRUD (Criar, Ler, Atualizar e Deletar) para gerenciar informações sobre restaurantes, incluindo detalhes sobre os pratos oferecidos, como descrições e preços. A API foi projetada para ser simples de usar e extensível, permitindo que desenvolvedores integrem facilmente com outros sistemas.

## Instalação

Para rodar este projeto localmente, você precisará ter as seguintes ferramentas instaladas:

### Pré-requisitos:
- .NET 6.0 SDK ou superior
- SQL Server (ou outro banco de dados compatível)
- Entity Framework Core

### Passos para instalação:
1. Clone o repositório:
   ```bash
   git clone https://github.com/seu-usuario/Restaurante_API.git
   ```
2. Entre no diretório do projeto:
   ```bash
   cd Restaurante_API
   ```
3. Restaure as dependências:
   ```bash
   dotnet restore
   ```
4. Crie o banco de dados (certifique-se de que sua conexão com o banco esteja configurada corretamente no `AppDbContext`):
   ```bash
   dotnet ef database update
   ```
5. Rode o projeto:
   ```bash
   dotnet run
   ```

## Funcionalidades
- Listagem de restaurantes incluindo os pratos vinculados a cada um, com sua descrição e preço.
- Busca de um restaurante específico por ID.
- Criação de um restaurante, com seus pratos.
- Atualização/modificação de um restaurante.
- Deleção de um restaurante.

## Como usar

### Endpoints principais:
- **GET** `/api/restaurantes` - Lista todos os restaurantes.
- **GET** `/api/restaurantes/{id}` - Busca um restaurante específico pelo ID.
- **POST** `/api/restaurantes` - Cria um novo restaurante.
- **PUT** `/api/restaurantes/{id}` - Atualiza um restaurante existente.
- **DELETE** `/api/restaurantes/{id}` - Deleta um restaurante pelo ID.

## Tecnologias Utilizadas
- **ASP.NET Core**: Framework para desenvolvimento da aplicação web.
- **C#**: Linguagem de programação utilizada no desenvolvimento.
- **SQL Server**: Banco de dados relacional utilizado.
- **Swagger**: Para documentação da API.
- **Fluent Validation**: Para validação de dados.
- **Entity Framework Core**: Para manipulação de dados com ORM.

## Licença
Este projeto está sob a licença MIT. Veja o arquivo [LICENSE](LICENSE) para mais detalhes.
