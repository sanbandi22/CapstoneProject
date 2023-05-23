using CapstoneProject_Backend.DAL;
using CapstoneProject_Backend.Models;
using Microsoft.Net.Http.Headers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<UserService1, UserService>();
builder.Services.AddScoped<MedicineService1, MedicineService>();
builder.Services.AddScoped<CategoryService1, CategoryService>();
builder.Services.AddScoped<CartService1, CartService>();
builder.Services.AddScoped<AddressService1, AddressService>();
builder.Services.AddDbContext<ApplicationDbContext>();



builder.Services.AddControllers();

var app = builder.Build();

builder.Services.AddCors();
app.UseCors(builder =>
{
    builder
    .AllowAnyOrigin()
    .AllowAnyMethod()
    .AllowAnyHeader();
});

// Configure the HTTP request pipeline.

app.UseAuthorization();


app.MapControllers();

app.Run();
