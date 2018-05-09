# API_Reports

There are two project branches in the App. Master branch is in Asp.Net Framework and Feature/Asp.NetCore_API is in Asp.Net Core 2.0 .NET Framework

The functionlity of both the solution is similar which would Call an API in using Entity framework with sproc in a different way.

The primary purpose of this project is to call an API and display the respone in JSON format by querying the SQL database tables.

Functionalities and High level info that are achieved in the proj are as follows:-

MASTER BRANCH:-
Technology Used: Asp.Net 4.6.1 Framework, SQL, EntityFramework 6.2

1) Implemented dependency injection by using Unity Container
2) Implemented Areas for differenct API's 
3) Enabled Cors for cross site requests
4) Configured the response in JSON format. See Global.aspx.cs
5) Read connectionString and Appsettings value from web.config file 
6) Implemented AutoMapper to map the objects from Repository to Business Entities and from Business to ViewModels
7) Implemented IDContext for Entity Framework to connect to an User's individual DB connection string. The Repository mechanism is to read the connection string from the DB for each user and connect to that database.
Check out the Repository for more updates
8) Performed API Call operation fetch Multiple ResultSets using a Stored Procedure. See EmployerReportRepository.cs 
9) Connect to the Database based without EDMX and without stating Connection.OpenAsync(). See GroupRepository.cs and SettingsDBContext

FEATURE/ASp.NetCore_Api BRANCH:- 

Adding most of the above functionalities in a similar way except 5th point

10) Reading connection string and app setting values from appsettings.json  

NOTE:  Multiple Resultsets and Database Connection swapping does not support Entity Framework Core 2.0.1. So we tried this approach in Entity 6.2.0
