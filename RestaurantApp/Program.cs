using Microsoft.EntityFrameworkCore;
using RestaurantApp.Interface;
using RestaurantApp.Models;
using RestaurantApp.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IMenu, menuService>();
builder.Services.AddScoped<IOrderItems, orderItemsService>();
builder.Services.AddScoped<IResEmployee, resEmployeeService>();
builder.Services.AddScoped<IResOrder, resOrderService>();
builder.Services.AddScoped<IResTable, resTableService>();
builder.Services.AddScoped<IResUser, resUserService>();
builder.Services.AddDbContext<resturentContext>(option => option.UseSqlServer("Data Source=DESKTOP-DNK5RHH\\SQLEXPRESS;Initial Catalog=resturent;Integrated Security=True; encrypt=false"));
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
