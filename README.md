Architecture : Open architecture + Microservices<br />
Design pattern : Common Querry Responsibility Segregation<br />
Technology : .NET Core 6 API<br />
Language : C#

Application layers<br />
<ul>
Payroll.API : Main API with all end-point<br />
Payroll.APIGateway : Additional API gateway, but we are still able to utilise the current Azure API service<br />
Payroll.Application : Application logics <br />
Payroll.Domain : Application Domain<br />
Payroll.Infrastructure : Application infrastructure<br />
PayrollUnitTest : This is a XUnit Test project
</ul>

Database : MSSQL<br />
ORM : Microsoft Entity Framework<br />
