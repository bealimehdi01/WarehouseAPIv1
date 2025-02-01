# WarehouseAPIv1

WarehouseAPIv1 is an ASP.NET Core Web API for managing products in a warehouse. It provides endpoints for CRUD operations on products, including creating, reading, updating, and deleting products.

## Features

- Create, read, update, and delete products
- Supports CORS for cross-origin requests
- Entity Framework Core for database operations

## Technologies Used

- ASP.NET Core 6.0
- Entity Framework Core
- SQL Server
- Visual Studio 2022

## Getting Started

### Prerequisites

- .NET 6 SDK
- SQL Server
- Visual Studio 2022

### Installation

1. Clone the repository:

   2. Set up the database:

   - Update the connection string in `appsettings.json`:
- Apply migrations:
3. Run the application:
### Usage

The API provides the following endpoints:

- **Get all products**: `GET /api/products`
- **Get a product by ID**: `GET /api/products/{id}`
- **Create a new product**: `POST /api/products`
- **Update a product**: `PUT /api/products/{id}`
- **Delete a product**: `DELETE /api/products/{id}`

### Example Requests

#### Get all products
#### Get a product by ID
#### Create a new product
#### Update a product
#### Delete a product
## Contributing

Contributions are welcome! Please open an issue or submit a pull request for any changes.

## License

This project is licensed under the MIT License. 