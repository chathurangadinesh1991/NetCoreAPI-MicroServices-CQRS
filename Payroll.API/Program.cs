using MediatR;
using Microsoft.EntityFrameworkCore;
using Payroll.Application.Services;
using Payroll.Domain.Models;
using Payroll.Domain.Repositories;
using Payroll.Infrastructure.Context;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);
var settings = builder.Configuration.GetSection("Settings").Get<Settings>();

var assembly = AppDomain.CurrentDomain.Load("Payroll.Application");
builder.Services.AddMediatR(assembly);

//builder.Services.AddMediatR(Assembly.GetExecutingAssembly());
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<PayrollDBContext>(o =>
{
    o.UseSqlServer(settings.ConnectionStrings);
});
builder.Services.AddScoped<IAlowanceRepository, AlowanceRepository>();

var app = builder.Build();
IConfiguration configuration = app.Configuration;
IWebHostEnvironment environment = app.Environment;

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();