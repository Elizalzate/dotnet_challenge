using Application.Validators;
using Data;
using Microsoft.Extensions.DependencyInjection;
using Repository;
using Repository.Persistance.Contexts;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IContext, Context>();
builder.Services.AddScoped<ClienteRepository>();
builder.Services.AddScoped<SucursalRepository>();
builder.Services.AddScoped<ClienteValidator>();
var connectionString = "Data Source=database.db";
builder.Services.AddSqlite<DatabaseGestion>(connectionString);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
