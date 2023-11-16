# DapperDataProject-CDNCompany
SQL Server &amp; Create the methods using dapper framework
--------------------------------------------------------------------------------
Data Access Layer(DapperData Application):

The DataAccess folder, The implementation of the data access layer using Dapper. 
     - Connection Setup: The 'DataAccess' class sets up a Dapper connection to the database. Update the connection string in appsettings.json.
     - Repository Pattern: The UserRepository.cs class is used to interacting with the User table.
     - CRUD Operations: The repository provides methods for CRUD operations (Create, Read, Update, Delete) using Dapper.

Technologies Used:
       -  Backend Framework :  ASP.NET Core Web API and MVC 
       -  Data Access :  Dapper
       -  Database :  My SQL Server

Database Configuration:
The connection configuration is used to connection between api & database. It is placed appsettings.Json file in Api solution explorer. the below is the connection string:
' "ConnectionStrings": {"default": "data source = SIVAKRISHNA\\SQLEXPRESS; initial catalog = UserData;integrated security=True;encrypt=false"}'.


