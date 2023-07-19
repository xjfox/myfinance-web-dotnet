# MyFinance Web

## Descrição

O MyFinance Web é um hipotético sistema para controle de finanças pessoais. Ele foi desenvolvido para a disciplina "Práticas de Implementação e Evolução de Software" do curso de pós-graduação em Engenharia de Software da PUC Minas.

## Requisitos

Para rodar o projeto, você precisará dos seguintes requisitos:

- [.NET Core SDK 7.0](https://dotnet.microsoft.com/en-us/download)
- [SQL Server](https://www.microsoft.com/pt-br/sql-server/sql-server-downloads)
- [Git](https://git-scm.com/)

## Instalação

Para instalar o projeto, siga os seguintes passos:

1. Clone o projeto em um diretório:

    ```bash
    git clone https://github.com/xjfox/myfinance-web-dotnet.git
    ```
2. Execute o arquivo `docs/database-setup.sql` no Microsoft SQL Server Management Studio para criar o banco de dados e as tabelas necessárias.

3. Navegue até a pasta do projeto .NET:
    ```bash
    cd myfinance-web-netcore
    ```
4. Configure o acesso ao banco de dados:
    - Copie o arquivo `Config/database.env.example` para `Config/database.env`.
    - Edite o arquivo `Config/database.env` e, na variável `SERVER`, substitua o valor `{HOSTNAME}` pelo seu servidor.

5. Execute o comando de build:
    ```bash
    dotnet build
    ```
6. Execute o projeto:
    ```bash
    dotnet run
    ```
7. Acesse o projeto na URL e porta indicada no console: http://localhost:5249.

## Uso

Depois de iniciar o projeto, você pode começar a usar o MyFinance Web de várias maneiras:

### Plano de Contas

1. No menu principal, selecione "Plano de Contas".
2. Aqui, você pode realizar operações de criação, leitura, atualização e exclusão (CRUD) em seus planos de contas.

### Transações Financeiras

1. No menu principal, selecione "Transações Financeiras".
2. Aqui, você pode realizar operações de criação, leitura, atualização e exclusão (CRUD) em suas transações financeiras.

## Arquitetura

O objetivo do refactoring foi aplicar o Clean Architecture, onde foram criadas as seguintes camadas lógicas:

- Application Interface: Core do Asp MVC, Models, Builders
- Infra: Camada que implementa o acesso a dados e utiliza EntityFramework
- Adaptares: Define as interfaces dos repositórios que são implementados na camada de infraestrutura e que podem ser utilizadas nas camadas de serviços através de injeção de dependências
- Services: Implementa as lógica que acessa os recursos da camada de infraestrutura
- UseCases: Implementa os casos de uso do domínio
- Entities: Define as entidades do domínio

## Dependências do projeto

- Microsoft.EntityFrameworkCore 8.0.0-preview.5.23280.1
- Microsoft.EntityFrameworkCore.SqlServer 8.0.0-preview.5.23280.1
- DotNetEnv 2.5.0

## Agradecimentos

Um agradecimento especial ao professor Filipe Nhimi, que lecionou a disciplina "Práticas de Implementação e Evolução de Software" e cujo apoio foi inestimável durante o desenvolvimento deste projeto. Para mais informações sobre seu trabalho, visite seu [perfil no GitHub](https://github.com/filipenhimi).
