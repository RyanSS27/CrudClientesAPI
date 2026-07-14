# 📋 Client CRUD API

API REST desenvolvida em **.NET 10** para gerenciamento de clientes. O projeto implementa um CRUD completo utilizando **Entity Framework Core** e **PostgreSQL**, com foco no estudo da linguagem C#, persistência de dados e boas práticas de desenvolvimento.

## 🚀 Funcionalidades

- Cadastrar clientes
- Listar clientes
- Buscar clientes por ID (`Guid`)
- Atualizar clientes
- Remover clientes

---

## 🛠️ Tecnologias

- .NET 10 (C#)
- Entity Framework Core
- PostgreSQL 16
- Scalar

---

## 📁 Estrutura do Projeto

```text
📁 ClientesAPI/
├── 📁 Controllers/      # Endpoints da API
├── 📁 Database/         # Contexto do Entity Framework Core
├── 📁 Dtos/             # Objetos de transferência de dados
├── 📁 Entities/         # Entidades da aplicação
├── 📁 Migrations/       # Histórico das migrações
├── 📁 Services/         # Regras de negócio
├── 📄 appsettings.json  # Configurações da aplicação
└── 📄 Program.cs        # Inicialização da aplicação
```

---

## ⚙️ Executando o projeto

### Pré-requisitos

- .NET SDK 10
- PostgreSQL 16+

### 1. Clonar o repositório

```bash
git clone https://github.com/RyanSS27/client-crud-api.git
cd client-crud-api/ClientesAPI
dotnet restore
```

### 2. Configurar a conexão com o banco

Utilize o **User Secrets** para armazenar sua string de conexão local.

```bash
dotnet user-secrets set "ConnectionStrings:DefaultConnection" "Host=localhost;Port=5432;Database=client_crud_db;Username=postgres;Password=SUA_SENHA_AQUI"
```

### 3. Criar o banco de dados

```bash
dotnet ef database update
```

### 4. Executar a aplicação

```bash
dotnet run
```

---

## 🧪 Como utilizar

Após iniciar a aplicação, acesse o **Scalar** para visualizar e testar os endpoints da API.

```text
/scalar/v1
```

### Endpoints

| Método | Rota | Descrição |
| :---: | :--- | :--- |
| GET | `/api/clients` | Lista todos os clientes. |
| GET | `/api/clients/{id}` | Busca um cliente pelo ID. |
| POST | `/api/clients` | Cadastra um novo cliente. |
| PUT | `/api/clients/{id}` | Atualiza um cliente existente. |
| DELETE | `/api/clients/{id}` | Remove um cliente. |

### Exemplo de requisição

**POST** `/api/clients`

```json
{
  "name": "Ryan Souza",
  "address": "Avenida Paulista, 1000",
  "email": "ryan@email.com",
  "phone": "(11) 99999-9999"
}
```

### Resposta (201 Created)

```json
{
  "id": "3fa85f64-5717-4562-b3fc-2c963f66afa6",
  "name": "Ryan Souza",
  "address": "Avenida Paulista, 1000",
  "email": "ryan@email.com",
  "phone": "(11) 99999-9999"
}
```

<div align="center">
  <img src="https://img.shields.io/badge/.NET-10-512BD4?logo=dotnet&logoColor=white" alt=".NET">
  <img src="https://img.shields.io/badge/PostgreSQL-16-4169E1?logo=postgresql&logoColor=white" alt="PostgreSQL">
  <img src="https://img.shields.io/badge/EF_Core-ORM-8A2BE2" alt="Entity Framework Core">
  <img src="https://img.shields.io/badge/API-REST-009688" alt="REST API">
</div>   
