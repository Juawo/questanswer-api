# 🧠 QuestAnswer - Backend API
![C#](https://img.shields.io/badge/C%23-Backend-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
![ASP.NET](https://img.shields.io/badge/ASP.NET-Web%20API-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![Entity Framework](https://img.shields.io/badge/Entity%20Framework-ORM-68217A?style=for-the-badge)
![Rider](https://img.shields.io/badge/Rider-IDE-000000?style=for-the-badge&logo=jetbrains&logoColor=white)
![PostgreSQL](https://img.shields.io/badge/PostgreSQL-Database-336791?style=for-the-badge&logo=postgresql&logoColor=white)
![REST](https://img.shields.io/badge/REST-API-black?style=for-the-badge)

A RESTful ASP.NET Web API responsible for managing and serving trivia cards for the QuestAnswer game.

This API acts as the bridge between the game client and the database, ensuring efficient card delivery and data persistence.

---

## 📚 Table of Contents

- [Features](#-features)
- [Architecture Overview](#architecture-overview)
- [Architecture Diagram](#architecture-diagram)
- [Technical Decisions](#technical-decisions)
- [Tech Stack](#tech-stack)
- [How to Run](#how-to-run)
- [Project Status](#project-status)
- [Differentials](#differentials)
- [Future Improvements](#future-improvements)
- [Related Projects](#related-projects)

---

## Features

- RESTful API for trivia card storage and retrieval
- Integration with game client (Godot)
- Supports dynamic card fetching based on gameplay needs
- Persistent storage of trivia cards in database

### Planned Features

- Player authentication (JWT-based)
- Score tracking system
- Leaderboard endpoints
- Game session management
- Request validation and rate limiting

---

## Architecture Overview

The API follows a layered architecture to ensure maintainability and scalability:

```text
Controller → Service → Repository → Database

Controllers handle HTTP requests and responses

Services contain business logic

Repositories manage data access

DTOs are used to transfer data between layers
```

## Architecture Diagram



## Technical Decisions

Layered Architecture (Separation of Concerns)
The project is structured using Controller, Service, and Repository layers to keep responsibilities clear and maintainable.

**Client-Driven Filtering Strategy**
The API supports retrieving cards based on the client needs, allowing the game to control which cards should or should not be requested.

**Decoupled AI Generation**
Card generation is handled by a separate system, keeping this API focused only on data persistence and delivery.

**Scalable Design**
The architecture allows future expansion (authentication, leaderboard, etc.) without major restructuring.

## Tech Stack

![C#](https://img.shields.io/badge/C%23-Backend-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
![ASP.NET](https://img.shields.io/badge/ASP.NET-Web%20API-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![Entity Framework](https://img.shields.io/badge/Entity%20Framework-ORM-68217A?style=for-the-badge)
![Rider](https://img.shields.io/badge/Rider-IDE-000000?style=for-the-badge&logo=jetbrains&logoColor=white)
![PostgreSQL](https://img.shields.io/badge/PostgreSQL-Database-336791?style=for-the-badge&logo=postgresql&logoColor=white)
![REST](https://img.shields.io/badge/REST-API-black?style=for-the-badge)
## How to Run
```text
Clone the repository:

git clone <REPO_URL>

Navigate to the project folder:

cd QuestAnswer.API

Configure the database connection string

Apply migrations (if applicable):

dotnet ef database update

Run the application:

dotnet run
```

## Project Status

**In development** — currently supports card storage and retrieval, with future expansion planned.

## Differentials

- Clean separation between game client, API, and AI generator

- Focused API responsibility (data persistence and delivery only)

- Designed to integrate with mobile games (Godot)

- Scalable backend structure for future multiplayer and ranking systems

## Future Improvements

- JWT authentication and authorization

- Leaderboard system (global and weekly)

- Score validation and anti-cheat logic

- Request validation and rate limiting

- Logging and monitoring

- API documentation (Swagger)

- Deployment pipeline (CI/CD)

## Related Projects

This API is part of the QuestAnswer ecosystem:

🎮 Game Client (Godot): https://github.com/Juawo/questanswer-client?tab=readme-ov-file
🤖 AI Card Generator: https://github.com/Juawo/questanswer-cardgen
