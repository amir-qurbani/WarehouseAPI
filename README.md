# Warehouse API Manager

A professional Fullstack application for inventory management, built with a decoupled architecture and containerized database.

## 🚀 Features
* **Full CRUD Operations**: Create, Read, and Delete products through a responsive web interface.
* **Clean Architecture**: Implements the Service Pattern and Interfaces (`IProductService`) to separate business logic from controllers.
* **Server-side Validation**: Strict data integrity using Data Annotations (e.g., preventing negative prices or empty names).
* **Containerized Infrastructure**: Database runs in Docker for consistent development environments.
* **Interactive Documentation**: Explore and test endpoints using integrated Swagger UI.



## 🛠 Tech Stack
* **Backend**: .NET 8 / C#
* **Database**: Microsoft SQL Server running in Docker
* **ORM**: Entity Framework Core
* **Frontend**: Vanilla JavaScript, HTML5, CSS3

## 🏁 Getting Started

### Prerequisites
* .NET 8 SDK 
* Docker Desktop

### Installation & Setup
1. **Clone the repository**:
   ```bash
   git clone <your-repo-url>
   cd WarehouseAPI

2. **Start the database container**:
   ```bash
    docker-compose up -d
3. **Run the application**:
    ```bash
     dotnet run --project WarehouseAPI
4. **Access the API**:
    Open your browser and navigate to `http://localhost:5000/swagger` to explore the API documentation and test endpoints.
## 📂 Project Structure
```
WarehouseAPI/
├── Controllers/
│   └── ProductsController.cs   
├── Services/
│   ├── IProductService.cs
│   └── ProductService.cs
├── Models/
│   └── Product.cs
├── Data/
│   └── WarehouseContext.cs
├── Program.cs
├── index.html
├── docker-compose.yml
└── README.md


