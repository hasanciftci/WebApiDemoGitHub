using Microsoft.EntityFrameworkCore;
using WebAPIDemo.Models;
using WebAPIDemo.Controllers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
//builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<azureacademyprojectContext>(opt =>
    opt.UseSqlServer("Server=tcp:azureacademysqlserver.database.windows.net,1433;Initial Catalog=azureacademyproject;Persist Security Info=False;User ID=serveradmin;Password=r@EwpLF9tvHEf6b;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    //app.UseSwagger();
    //app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
