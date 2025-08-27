# ⚙️ Pokedex API  

[![ASP.NET Core](https://img.shields.io/badge/ASP.NET%20Core-API-512BD4?logo=dotnet&logoColor=white)](https://dotnet.microsoft.com/apps/aspnet)  
[![Swagger](https://img.shields.io/badge/Swagger-Docs-brightgreen?logo=swagger&logoColor=white)](https://swagger.io/)  
[![PostgreSQL](https://img.shields.io/badge/PostgreSQL-DB-4169E1?logo=postgresql&logoColor=white)](https://www.postgresql.org/)  
[![License: MIT](https://img.shields.io/badge/License-MIT-green.svg)](https://opensource.org/licenses/MIT)  

A simple **ASP.NET Core Web API** for managing Pokémon data, connected to a **PostgreSQL database** and documented with **Swagger**.  
This API is used by the [Pokedex App](https://github.com/tu-usuario/tu-repo-app).  

---

## 🚀 Features
- Get Pokémon list  
- Add new Pokémon  
- Update Pokémon info  
- Delete Pokémon  
- Swagger UI for testing endpoints  

---

## 🛠️ Tech Stack
- ASP.NET Core Web API  
- Entity Framework Core  
- PostgreSQL  
- Swagger UI  

---

## 📦 Setup
1. Clone this repository.  
2. Configure connection string in `appsettings.json` for PostgreSQL.  
3. Run migrations if needed (`dotnet ef database update`).  
4. Start the API (`dotnet run`).  
5. Access Swagger UI at `http://localhost:5102/swagger`.  

---

## 📜 License
This project is open source under the **MIT License**.  
