using Microsoft.EntityFrameworkCore;
using TodoListApp.BLL.Interfaces;
using TodoListApp.BLL.Services;
using TodoListApp.DAL.Db;
using TodoListApp.DAL.Interfaces;
using TodoListApp.DAL.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

string todoListAppDbConnectionString = builder.Configuration.GetConnectionString("TodoListAppDb");

builder.Services.AddDbContext<TodoListAppDbContext>(options => options.UseSqlServer(todoListAppDbConnectionString));

builder.Services.AddScoped<ITodoListRepository, TodoListRepository>();
builder.Services.AddScoped<ITodoListService, TodoListService>();

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
