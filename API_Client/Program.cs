﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using API_Cliente.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<API_ClienteContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("API_ClienteContext") ?? throw new InvalidOperationException("Connection string 'API_ClienteContext' not found.")));

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
