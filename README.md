# Client CRUD API

Web API desenvolvida na plataforma **.NET 10** com persistência em banco de dados relacional **PostgreSQL**. 
Este projeto consiste na implementação de um CRUD (Create, Read, Update, Delete) completo, construído para consolidar os fundamentos da linguagem C#, Entity Framework Core e boas práticas de engenharia de software, como separação de responsabilidades e uso de DTOs.

## 🚀 Funções Principais do Sistema

* **Cadastrar Clientes (Create):** Inserção de clientes utilizando validação nativa de tipos.
* **Listar e Buscar (Read):** Listagem geral e específica de clientes utilizando identificadores únicos universais (`Guid`).
* **Atualizar Cadastros (Update):** Modificação segura de dados cadastrais existentes.
* **Remover Clientes (Delete):** Exclusão de registros do banco de dados utilizando padrão de retorno HTTP adequado (204 No Content).

---

## Estrutura do Projeto

A arquitetura do projeto foi desenhada visando a separação de responsabilidades (Separation of Concerns), isolando o tráfego HTTP das regras de negócio e do acesso a dados.

```text
📁 ClientesAPI/
├── 📁 Controllers/      # Endpoints REST (Porta de entrada HTTP)
├── 📁 Database/         # Contexto de dados do EF Core (ApplicationDbContext)
├── 📁 Dtos/             # Data Transfer Objects (Isolam a entrada e saída de dados)
├── 📁 Entities/         # Modelos de domínio centrais da aplicação (ex: Client.cs)
├── 📁 Migrations/       # Histórico de versionamento estrutural do Banco de Dados
├── 📁 Services/         # Camada de serviços contendo a lógica de negócios e injeção de dependência
├── 📄 appsettings.json  # Arquivo de configuração (Template sem credenciais reais)
└── 📄 Program.cs        # Inicializador do .NET, Pipeline HTTP e Container de Injeção de Dependência
```
---

## Tecnologias Chave
*.NET 10 (C#)

*Entity Framework Core (Adaptador ORM para banco de dados)

*PostgreSQL 16.14 (Banco de dados relacional)

*Scalar (Interface moderna e interativa para documentação e testes da API REST

--- 

## Configuração do Ambiente Local

### 1. Clonar e Restaurar Dependências
```bash
git clone [https://github.com/RyanSS27/client-crud-api.git](https://github.com/RyanSS27/client-crud-api.git)
cd client-crud-api/ClientesAPI
dotnet restore
```

### 2. Configurar a String de Conexão (User Secrets)
Para não expor senhas no repositório do Git, utilize a ferramenta de segredos do .NET para configurar sua conexão com o PostgreSQL:
```bash
dotnet user-secrets set "ConnectionStrings:DefaultConnection" "Host=localhost;Port=5432;Database=client_crud_db;Username=postgres;Password=SUA_SENHA_AQUI"
```

### 3. Executar as Migrations (Criação do Banco)
Com o serviço do PostgreSQL ativo em sua máquina, aplique a estrutura das tabelas usando o EF Core:
```bash
dotnet ef database update
```

### 4. Rodar a Aplicação
```bash
dotnet run
```

---

## Como Utilizar a API

Ao rodar o projeto localmente, você pode acessar a interface visual do **Scalar** (geralmente disponível na rota `/scalar/v1` ou na raiz da API) para visualizar e interagir com todos os endpoints documentados.

### Matriz de Endpoints Disponíveis

| Método | Rota | Descrição |
| :--- | :--- | :--- |
| **GET** | `/api/clients` | Retorna a lista completa de clientes cadastrados. |
| **POST** | `/api/clients` | Cadastra um novo cliente. |
| **GET** | `/api/clients/{id}` | Busca um cliente específico através do seu `Guid`. |
| **PUT** | `/api/clients/{id}` | Atualiza os dados de um cliente existente. |
| **DELETE** | `/api/clients/{id}` | Remove um cliente da base de dados. |

### Exemplo de Uso: Criar Cliente (POST)

* **Rota:** `POST /api/clients`
* **Payload (Body):**
```json
{
  "name": "Ryan Souza",
  "address": "Avenida Paulista, 1000",
  "email": "ryan@email.com",
  "phone": "(11) 99999-9999"
}
```

* **Retorno de Sucesso (201 Created):**
```json
{
  "id": "3fa85f64-5717-4562-b3fc-2c963f66afa6",
  "name": "Ryan Souza",
  "address": "Avenida Paulista, 1000",
  "email": "ryan@email.com",
  "phone": "(11) 99999-9999"
}
```
