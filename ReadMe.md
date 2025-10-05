# ⚙️ GearCore

![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
![.NET](https://img.shields.io/badge/.NET-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![ASP.NET](https://img.shields.io/badge/ASP.NET-512BD4?style=for-the-badge&logo=aspdotnet&logoColor=white)
![Docker](https://img.shields.io/badge/Docker-2496ED?style=for-the-badge&logo=docker&logoColor=white)
![PostgreSQL](https://img.shields.io/badge/PostgreSQL-4169E1?style=for-the-badge&logo=postgresql&logoColor=white)
![GitHub](https://img.shields.io/badge/github-%23121011.svg?style=for-the-badge&logo=github&logoColor=white)
![License](https://img.shields.io/badge/MIT-000000?style=for-the-badge&logo=github&logoColor=white)
![Postman](https://img.shields.io/badge/Postman-FF6C37?style=for-the-badge&logo=postman&logoColor=white)

---

GearCore é uma API simples que funciona como backend para aplicações de gerenciamento de máquinas. Cada empresa pode cadastrar seus usuários e controlar suas próprias máquinas, de qualquer tipo. O usuário que registra a empresa recebe o título de **Owner** 🏢 e pode criar e gerenciar usuários dentro da sua organização.  
Cada **Empresa** pode criar, gerenciar e monitorar suas próprias máquinas 🖥️, garantindo que os dados e operações sejam isolados por empresa.

## ✨ Funcionalidades

- 📝 Cadastro de empresas e usuários
- 🖥️ Controle de máquinas por empresa
- 👥 Cada empresa pode criar, gerenciar e monitorar suas próprias máquinas
- 🔒 Sistema de permissões (Owner, Users)
- 📜 Registro de logs e histórico de operações
- 🔔 Notificações em tempo real via SignalR
- 🧩 API modular, pronta para auto-hospedagem

## 🛠️ Tecnologias

- C# / ASP.NET Core
- Clean Architecture (Domain, Application, Infrastructure, Api, Migrations, Test)
- Entity Framework / Dapper / PostgreSQL
- JWT para autenticação
- SignalR para notificações em tempo real
- Docker (opcional para execução local)

## 📂 Estrutura do Projeto (Clean Architecture)

- `Domain/` → entidades e regras de negócio
- `Application/` → casos de uso, serviços e lógica de aplicação
- `Infrastructure/` → acesso a banco de dados, integração com serviços externos
- `Api/` → controllers, endpoints e configuração da API
- `Migrations/` → migrations do banco de dados
- `Test/` → testes unitários e de integração

## 🐳 Docker

O projeto conta com **Dockerfile** e **docker-compose**, prontos para uso, facilitando a execução da aplicação de forma isolada no localhost ou em uma rede interna via IP. O banco de dados já está configurado para rodar dentro do container.

## 🗄️ Banco de Dados

O PostgreSQL foi utilizado para performance e fácil relacionamento entre as tabelas, garantindo integridade e escalabilidade.

## ⚡ SignalR

O GearCore utiliza **SignalR**, o sistema oficial da Microsoft, para enviar notificações em tempo real para o frontend conectado.

- 🔄 Permite atualizações instantâneas de status das máquinas
- 💬 Pode enviar mensagens personalizadas para usuários ou grupos de usuários
- 🔗 Totalmente integrado à arquitetura Clean Architecture do projeto

## 🐋 Rodando via dockerfile

1. Clonar esse repositório:

   ```bash
   git clone https://github.com/LucasLantemamLeite/GearOps.git
   ```

2. Compilar o docker:

   ```bash
   docker build -t gear-ops-api .
   ```

3. Rodar a imagem:

   ```bash
   docker run -d -p 5000:5000 -e ASPNETCORE_URLS="http://+:5000" --name gear-ops-backend gear-ops-api
   ```

4. Verificar se foi compilado corretamente:

   ```bash
   http://localhost:5000/v1/health -> Roda via localhost
   http:'ip-da-máquina':5000/v1/health -> Roda via rede IP
   ```

## 📦 Rodar via docker-compose

> ⚠️ Em progresso

## 📝 Observações

Para mais informações de como usar a aplicação, consulte a **[Wiki do Projeto](https://github.com/LucasLantemamLeite/GearOps/wiki)**
