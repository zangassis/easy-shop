# EasyShop 🛒

This project contains a sample ASP.NET Core app. This app is an example of the article I produced for the Telerik Blog (telerik.com/blogs).

EasyShop is an ASP.NET Core minimal API application developed using .NET 7. The application utilizes various libraries and tools, including SQLite, EF Core, AutoMapper, Serilog, and FluentValidation.

## 🚀 Getting Started

To get started with EasyShop, follow the steps below:

1. **Prerequisites**
   - Install [.NET 7](https://dotnet.microsoft.com/download/dotnet/7.0) or higher.

2. **Clone the Repository**
   ```bash
   git clone https://github.com/zangassis/easy-shop
   cd easy-shop
   ```

3. **Configure the Database**
   - EasyShop uses SQLite as the database.
   - The connection string is in the `appsettings.json` file.

4. **Install Dependencies**
   ```bash
   dotnet restore
   ```

5. **Run Migrations**
   ```bash
   dotnet ef database update
   ```

6. **Start the Application**
   ```bash
   dotnet run
   ```

7. **Access EasyShop**
   Open your web browser and visit `http://localhost:PORT` to access the EasyShop application.

## 📂 Project Structure

The project structure of EasyShop is as follows:

```
├── EasyShop
│   ├── Data
│   ├── logs
│   ├── Migrations
│   ├── Models
│   │  ├── Dtos
│   │     └── Profiles
│   ├── Services
│   ├── Validators
│   ├── appsettings.json
│   └── Program.cs
└── ...
```

- `Data`: Contains the database context and related classes.
- `logs`: Contains the logs files.
- `Migrations`: Contains the database migration scripts.
- `Models`: Contains the data models used in the application.
- `Dtos`: Contains the DTOs used in the application.
- `Profiles`: Contains the Profiles files used in the application.
- `Services`: Contains the business logic services.
- `Validators`: Contains the validations used in the application.
- `appsettings.json`: Configuration file for the application.
- `Program.cs`: Entry point of the application.

## 📦 Libraries and Tools

EasyShop utilizes the following libraries and tools:

- SQLite: Lightweight and self-contained database engine.
- EF Core: Object-relational mapping (ORM) framework for database operations.
- AutoMapper: Object-to-object mapping library.
- Serilog: Logging framework for structured logging.
- FluentValidation: Library for validating objects and properties.

Feel free to explore the codebase to learn more about the implementation details of each library.

## 📝 License

This project is licensed under the [MIT License](LICENSE).

Happy Shopping! 🛍️