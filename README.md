DVLD (Driver and Vehicle Licensing Department) Management System
A comprehensive desktop application built using C# .NET Windows Forms, SQL Server, and 3-Tier / 3-Layer Architecture designed to digitize and manage driver and vehicle licensing operations.

🏗️ Architecture & Tech Stack
The application is structured following clean 3-Tier Architecture separation of concerns:

Presentation Layer (UI): C# Windows Forms, customized user controls, error providers, and custom event delegates.

Business Logic Layer (BLL): Object-Oriented Programming (OOP) classes managing business rules, validation, and data flows.

Data Access Layer (DAL): ADO.NET (SqlConnection, SqlCommand, SqlDataReader) for robust database operations.

Database: Microsoft SQL Server (Relational database design, indexes, and views).

✨ Key Features & Modules
Applications Management:

Manage Local Driving License Applications.

International Driving License (IDL) applications and tracking.

Application Types, Test Types, and fees management.

Tests & Pass/Fail Tracking:

Vision Test, Written (Theory) Test, and Street (Practical) Test scheduling and results recording.

Drivers & Vehicles:

Comprehensive Driver management and history tracking.

Detain and Release License workflows with fine management.

Users & People Management:

Full CRUD operations for system users with role-based access control (IsActive bits, secure credentials).

Person management with integrated image handling (GUID-based storage, secure file streaming).

📂 Project Structure
Plaintext
DVLD-Full-Project-Desktop-3Tier/
│
├── DVLD_Solution/
│   ├── BusinessLayer/        # Business Logic classes and rules
│   ├── DataAccessLayer/      # ADO.NET data access components
│   ├── DVLD Full Project Desktop/ # Windows Forms UI and forms
│   └── DVLD_Database.sql     # Full database schema and setup script
│
└── .gitignore
🚀 Getting Started & Installation
Prerequisites
Visual Studio 2022 (with .NET desktop development workload).

Microsoft SQL Server (SSMS - SQL Server Management Studio).

Step 1: Clone the Repository
Bash
git clone https://github.com/mosabmomani/DVLD-Full-Project-Desktop-3Tier.git
Step 2: Set Up the Database
Open SQL Server Management Studio (SSMS).

Execute the included SQL script file located in the solution directory: DVLD_Database.sql. This will create the required database, tables, relationships, and initial data.

Update your connection string in the configuration settings / data access layer to point to your local SQL Server instance.

Step 3: Run the Application
Open the solution file (.sln) inside Visual Studio 2022.

Restore NuGet packages if prompted.

Build and run the project (F5).

👨‍💻 Author
Musab Al-Momani

GitHub: @mosabmomani
