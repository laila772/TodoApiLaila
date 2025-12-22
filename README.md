Project Overview

This project is a simple To-Do application consisting of:

1. A .NET Web API backend to manage to-do items
2. A React frontend to display and manage the to-do list

The application allows users to:

1. View all to-dos
2. Add new to-dos
3. Update existing to-dos
4. Delete to-dos

Backend

1. ASP.NET Core Web API
2. In-memory data storage (List)
3. RESTful endpoints
4. Dependency Injection

Frontend

1. React (JavaScript)
2. Fetch API for HTTP requests
3. Basic CSS for UI styling

Backend API Endpoints
Method	    Endpoint	      Description
GET	        /api/todo	      Get all to-dos
POST	    /api/todo	      Add a new to-do
PUT	        /api/todo/{id}	  Update a to-do
DELETE	    /api/todo/{id}	  Delete a to-do
Example POST Body
"Study for exam"

How to Run the Backend

1. Open terminal in the backend project folder
2. Run the following command:
3. dotnet run
4. The API will run on: http://localhost:5000/swagger

How to Run the Frontend

1. Open terminal in the todo-frontend project folder
2. Install dependencies: npm install
3. Start the React app: npm start
4. Open in browser: http://localhost:3000

Author

Nur Fazreen Laila Binti Paudzi
