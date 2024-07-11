using Microsoft.EntityFrameworkCore;
using POCClient.Data;
using POCClient.Functionality;
using POCClient.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<ProductDBContext>(); // IOC OR Registering the ProductDBContext class in Unity Container 
builder.Services.AddTransient<IProduct, ProductRepository>(); // IOC for productRepository 

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
  app.UseSwagger();
  app.UseSwaggerUI();


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
