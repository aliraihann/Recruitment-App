# Recruitment Application

## Description
This is a simple web application built using ASP.NET Core MVC for managing job applicants. The application allows users to add, edit, and delete candidate data. It uses SQL Server as the database and is designed to run in a local environment.

## Features
- Add, edit, and delete candidate data.
- Built with ASP.NET Core MVC.
- Uses SQL Server for data storage.
- Clear and structured code.
- Implements dependency injection.

## Prerequisites
Before you begin, ensure you have the following installed on your local machine:
- [.NET SDK](https://dotnet.microsoft.com/download) (version 6.0 or later)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) (Express edition is sufficient)
- [Visual Studio](https://visualstudio.microsoft.com/) or any other IDE that supports .NET development.

## Setup Instructions

### 1. Clone the Repository
Clone this repository to your local machine using the following command:
```
  git clone https://github.com/aliraihann/Recruitment-App.git
```

### 2. Database Setup
1. **Create a SQL Server Database**:
   - Open SQL Server Management Studio (SSMS).
   - Connect to your SQL Server instance.
   - Create a new database named `RecruitmentDb` or whatever name you like.

2. **Update Connection String**:
   - Open the `appsettings.json` file in the project.
   - Update the connection string to point to your SQL Server database:
      ```
        "ConnectionStrings": { "Server=[your_server_name;Database=your_database_name;Trusted_Connection=True;TrustServerCertificate=True" }
      ```

## Snapshot of the Application
1. **Home Page**
   ![Home-Page](https://github.com/aliraihann/Recruitment-App/blob/main/Home%20Page.PNG)
   
   ENDPOINT:yourAppURL
3. **Candidate List**
   ![Candidate-List-Page](https://github.com/aliraihann/Recruitment-App/blob/main/Candidate%20List.PNG)
   
   ENDPOINT:yourAppURL/Candidate/List
5. **Add New Candidate Page**
   ![Add-New-Candidate-Page](https://github.com/aliraihann/Recruitment-App/blob/81d8222035cbacbe20853bbdcb82af27c3917720/Add%20New%20Candidate.PNG)
   
   ENDPOINT:yourAppURL/Candidate/Add
7. **Update Candidate Page**
   ![Edit-Candidate-Information](https://github.com/aliraihann/Recruitment-App/blob/main/Edit.PNG)
   
   ENDPOINT:yourAppURL/Candidate/Edit/Candidate_Id
   


