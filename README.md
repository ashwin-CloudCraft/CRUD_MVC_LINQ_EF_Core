# CRUD_MVC_LINQ_EF_Core
# CRUD Operations using ASP.NET Core MVC, LINQ, and Entity Framework Core

A robust web application built with **ASP.NET Core MVC** utilizing **Entity Framework Core (EF Core)** and **LINQ** queries to perform seamless Create, Read, Update, and Delete (CRUD) operations against a SQL Server database.

## 🚀 Features
* **MVC Architecture:** Structured separation of concerns using Models, Views, and Controllers.
* **Database Management:** Connected to Microsoft SQL Server via Entity Framework Core.
* **LINQ Queries:** Clean, strongly-typed data querying and manipulation.
* **Data Validation:** Model validation with Data Annotations (e.g., `[Required]`, `[StringLength]`).

## 🛠️ Tech Stack
* **Backend Framework:** .NET Core (ASP.NET Core MVC)
* **ORM:** Entity Framework Core
* **Database:** Microsoft SQL Server
* **Frontend:** Razor Views, HTML5, CSS3, Bootstrap

## 🔧 Prerequisites & Setup

1. **Clone the repository:**
   ```bash
   git clone https://github.com
   ```

2. **Configure the Connection String:**
   Open `appsettings.json` and add your SQL Server details under `ConnectionStrings`:
   ```json
   "ConnectionStrings": {
     "DefaultConnection": "Server=YOUR_SERVER_NAME;Database=your_database;Trusted_Connection=True;MultipleActiveResultSets=true"
   }
   ```

3. **Restore Packages & Run:**
   ```bash
   dotnet restore
   dotnet run
   ```

## 📂 Project Structure
* `Models/` - Data models mapping directly to SQL database tables.
* `Data/` - Contains the `ApplicationDbContext` class handling database connections.
* `Controllers/` - Manages business logic and user actions (e.g., `EmployeeController`).
* `Views/` - Razor components rendering UI layouts.
