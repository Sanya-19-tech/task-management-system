# Task Management System

A comprehensive, full-stack Task Management application designed to help users efficiently track and manage their day-to-day tasks. The project features a robust C# ASP.NET Core API for the backend and a modern Angular application for the frontend.

## 🚀 Project Overview

The repository is structured into two main applications:

- **`TaskManagementAPI`**: A backend RESTful API built using ASP.NET Core, Entity Framework Core (In-Memory Database), and Swagger for documentation.
- **`task-management-frontend`**: A frontend web application built using Angular 21, designed to interface seamlessly with the backend API.

### Core Features
- Create new tasks with a Title, Description, and Completion Status.
- View a list of all existing tasks.
- Update the details or status of existing tasks.
- Delete or mark tasks as completed.
- Cross-Origin Resource Sharing (CORS) configured for frontend-backend communication.
- Comprehensive REST API endpoints tested and documented via Swagger UI.

---

## 🛠️ Technology Stack

**Backend (`TaskManagementAPI`)**:
- C# & .NET (ASP.NET Core Web API)
- Entity Framework Core (In-Memory Database)
- Swagger / OpenAPI (API Documentation)
- Repository & Service Patterns (Design Architecture)

**Frontend (`task-management-frontend`)**:
- Angular (v21.x)
- TypeScript
- RxJS
- HTML / CSS

---

## ⚙️ Getting Started

To get a local copy up and running, follow these steps.

### Prerequisites

You need to have the following installed on your machine:
- [.NET SDK](https://dotnet.microsoft.com/download) 
- [Node.js and npm](https://nodejs.org/) 
- [Angular CLI](https://angular.io/cli) 

### Setting up the Backend (API)

1. Open a terminal and navigate to the backend directory:
   ```bash
   cd TaskManagementAPI
   ```
2. Restore the necessary .NET packages (optional, implicit on build/run):
   ```bash
   dotnet restore
   ```
3. Run the application:
   ```bash
   dotnet run
   ```
   **Note**: The application uses an *In-Memory Database*, meaning data resets every time the application restarts.
4. Open your browser and navigate to the provided localhost URL appended with `/swagger` (e.g., `https://localhost:<port>/swagger`) to view the interactive API documentation and test endpoints.

### Setting up the Frontend (Angular)

1. Open a new terminal and navigate to the frontend directory:
   ```bash
   cd task-management-frontend
   ```
2. Install the required Node dependencies:
   ```bash
   npm install
   ```
3. Start the Angular development server:
   ```bash
   npm start
   ```
   *(Alternatively, run `ng serve` if you have Angular CLI installed globally)*
4. Open your browser and navigate to `http://localhost:4200/` to test the UI. The application will automatically reload if you change any of the source files.

---

## 📂 Project Architecture Highlights

- **CORS Configuration**: The backend explicitly allows origins from the Angular application to ensure seamless requests during development.
- **Service & Repository Pattern**: The backend API code logic is cleanly separated between Data access (`ITaskRepository`) and Business logic (`ITaskService`), making the project highly maintainable and testable.
- **Data Model**: The primary entity `TaskItem` includes:
  - `Id`: Unique Identifier
  - `Title`: Required task title
  - `Description`: Optional details about the task
  - `IsCompleted`: Boolean progress state

---

## 🤝 Contributing

Contributions, issues, and feature requests are welcome! 
Feel free to check the [issues page](https://github.com/yourusername/TaskManagementSystem/issues) if you want to contribute.

1. Fork the Project
2. Create your Feature Branch (`git checkout -b feature/AmazingFeature`)
3. Commit your Changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the Branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request
