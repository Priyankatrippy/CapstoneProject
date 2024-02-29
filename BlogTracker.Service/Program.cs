using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using BlogTracker.DAL.Repositories;
using BlogTracker.Service.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// Configure services for dependency injection
builder.Services.AddControllers();
DependencyInjectionConfig.RegisterServices(builder.Services);

var app = builder.Build();

// Configure the HTTP request pipeline.

// Add authorization middleware if needed
app.UseAuthorization();

// Map controllers for handling HTTP requests
app.MapControllers();

// Run the application
app.Run();

