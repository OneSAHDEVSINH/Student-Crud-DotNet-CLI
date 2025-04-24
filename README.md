# Student CRUD CLI

## Overview
The **Student CRUD CLI** is a command-line interface application designed to manage student information. It provides functionality to create, read, update, and delete student records. The application is built using C# and leverages the Entity Framework for database operations.

## Features
- Add new student records.
- View existing student records.
- Update student details.
- Delete student records.
- Database migrations using Entity Framework.

## Prerequisites
- .NET Framework 4.8 or higher.
- Visual Studio 2019 or later (optional for development).
- SQL Server (for database operations).

## Setup Instructions

### Clone the Repository
```bash
# Clone the repository to your local machine
git clone https://github.com/OneSAHDEVSINH/Student-Crud-DotNet-CLI.git
cd StudentICrudCLI
```

### Install Dependencies
The project uses Entity Framework 6.5.1. Ensure all dependencies are installed by restoring NuGet packages:
```bash
# Restore NuGet packages
nuget restore StudentCrudCLI.sln
```

### Configure the Database
1. Open the `App.config` file in the `StudentInfo` directory.
2. Update the connection string to point to your SQL Server instance.

### Apply Migrations
Run the following commands to apply database migrations:
```bash
# Navigate to the project directory
cd StudentInfo

# Apply migrations
dotnet ef database update
```

## Usage

### Run the Application
To run the application, execute the following command:
```bash
# Navigate to the output directory
cd StudentInfo/bin/Debug

# Run the application
StudentInfo.exe
```

### Commands
- **Add Student**: Follow the prompts to input student details.
- **View Students**: Displays a list of all students.
- **Update Student**: Select a student and update their details.
- **Delete Student**: Remove a student record from the database.

## Project Structure
```
StudentICrudCLI/
├── StudentCrudCLI.sln          # Solution file
├── StudentInfo/                # Main project directory
│   ├── App.config              # Configuration file
│   ├── Program.cs              # Entry point of the application
│   ├── Model.cs                # Student model definition
│   ├── StudentContext.cs       # Database context
│   ├── Migrations/             # Entity Framework migrations
│   └── Properties/             # Assembly info
├── packages/                   # NuGet packages
│   └── EntityFramework.6.5.1/  # Entity Framework package
└── README.md                   # Project documentation
```

## Entity Framework
This project uses Entity Framework 6.5.1 for database operations. Key commands include:
- `Enable-Migrations`: Enables migrations for the project.
- `Add-Migration <name>`: Creates a new migration.
- `Update-Database`: Applies migrations to the database.

For more information, refer to the [Entity Framework documentation](https://docs.microsoft.com/ef/ef6/).

## Contributing
Contributions are welcome! Please follow these steps:
1. Fork the repository.
2. Create a new branch for your feature or bug fix.
3. Commit your changes and push the branch.
4. Submit a pull request.

## License
This project is licensed under the MIT License. See the LICENSE file for details.

## Acknowledgments
- [Entity Framework](https://github.com/dotnet/ef6) for providing robust ORM capabilities.
- The .NET community for their support and resources.
