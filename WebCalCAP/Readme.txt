This Web API sample application provides you the basic elements of an application that uses .NET DataStore for data access.

Prerequisite:
Because the .NET DataStore model (D_Department.cs) in the application is already bound with
specific DataContext (database connection), you need to set up the database following these steps:
1. Install one of the supported database servers: Oracle, SQL Server, PostgreSQL, or SQL Anywhere.
2. Download the database backup file for the database server from https://github.com/Appeon/.NET-Project-Example-Database.
3. Restore database using the downloaded database backup file.
4. In appsettings.json, modify the database connection name from the default "Local" to a name you prefer to use, 
   and modify the datasource, initial catalog, username and password of the database connection string.
5. In the ConfigureServices method of Startup.cs, find the AddDataContext code line for the database server you are using and update it following the comments. Make sure the AddDataContext code line for SQL Server is commented out if you are not using SQL Server.


How to run the sample app:
Enter the URL http://localhost:5000/api/sample/retrieveone/{id}.

Basic elements of the application:
1.	The Program.cs file.
	This file is the entry point for the application. It sets up the IWebHost, and contains 
	the UseStartup<Startup> line which tells the host to use the Startup.cs file.

2.	The Startup.cs file.
	In this file, the ConfigureServices method configures the services for dependency injection;
	the UseCoreIntegrated method and UsePowerBuilderIntegrated method in
	the ConfigureServices method enables the actions in the controller to support PowerBuilder
	based technology (e.g. DataWindow); the Configure method specifies how the service
	responds to the requests; the UseDataWindow method in the Configure method parses and
	loads all DataWindow objects of the current application.
	Both the ConfigureServices method and Configure methods are standard methods in C# development.
	For more description, you may refer to
	https://docs.microsoft.com/en-us/aspnet/core/fundamentals/startup?view=aspnetcore-3.1.

3.	The SampleDataContext.cs file.
	The SampleDataContext.cs file contains the class that manages database connections and transactions.

4.	The appsettings.json file.
	The database connection string and other app settings are saved in appsettings.json.

5.	The DataWindows folder.
	The D_Department.cs file is the .NET DataStore model that is generated from a PowerBuilder DataWindow using the DataWindow Converter tool.

6.	The ISampleService.cs and SampleService.cs files.
	The interface file ISampleService.cs contains only the declaration of the methods for the services.
	The service file SampleService.cs contains the implementation of the services that the application provides.

7.	The SampleController.cs file.
	It contains the sample API controller class, which provides methods that respond to HTTP requests.

8.	The launchSettings.json file.
	It is a standard file in ASP.NET Core. This file sets up the environments that SnapDevelop can launch automatically.
