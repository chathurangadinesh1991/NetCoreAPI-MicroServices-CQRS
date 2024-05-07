Architecture : Open architecture + Microservices
Design pattern : Common Querry Responsibility Segregation
Technology : .NET Core 6 API

Application layers
  Payroll.API : Main API with all end point
  Payroll.APIGateway : Additional API gateway, but we are still able to utilise the current Azure API service
  Payroll.Application : Application logics 
  Payroll.Domain : Application Domain
  Payroll.Infrastructure : Application infrastructure
  PayrollUnitTest : This is a XUnit Test project
Database : MSSQL
ORM : Microsoft Entity Framework
