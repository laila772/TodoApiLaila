# To-Do List Application

**Author:** Nur Fazreen Laila Binti Paudzi  
**GitHub:** https://github.com/laila772

---

## Project Overview

This project is a simple To-Do application consisting of:

- A .NET Web API backend to manage to-do items
- A React frontend to display and manage the to-do list

The application allows users to:
- View all to-dos
- Add new to-dos
- Update existing to-dos
- Delete to-dos

---

## Backend

- ASP.NET Core Web API
- In-memory data storage (List)
- RESTful API endpoints
- Dependency Injection

### Backend API Endpoints

| Method | Endpoint           | Description          |
|------|--------------------|----------------------|
| GET  | /api/todo          | Get all to-dos       |
| POST | /api/todo          | Add a new to-do      |
| PUT  | /api/todo/{id}     | Update a to-do       |
| DELETE | /api/todo/{id}   | Delete a to-do       |

**Example POST Body**
"Study for exam"

---

## Frontend

- React (JavaScript)
- Fetch API for HTTP requests
- Basic CSS for UI styling

---

## How to Run the Backend

- Open terminal in the backend project folder
- Run: dotnet run
- Open Swagger UI: http://localhost:5000/swagger

## How to Run the Frontend

- Open terminal in the todo-frontend folder
- Install dependencies: npm install
- Start the React app: npm start
- Open in browser: http://localhost:3000
