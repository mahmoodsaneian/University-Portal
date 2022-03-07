using Microsoft.EntityFrameworkCore;
using UniversityPortal.Controllers;
using UniversityPortal.Models.Contexts;
using UniversityPortal.Models.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
var connectionString = builder.Configuration.GetConnectionString("Portal");
builder.Services.AddEntityFrameworkSqlServer()
    .AddDbContext<DatabaseContext>(option => option.UseSqlServer(connectionString));
builder.Services.AddScoped<TeacherRepository, TeacherRepository>();
builder.Services.AddScoped<StudentRepository, StudentRepository>();
builder.Services.AddScoped<ManagerRepository, ManagerRepository>();
builder.Services.AddScoped<LessonRepository, LessonRepository>();
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