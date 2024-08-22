using Microsoft.EntityFrameworkCore;
using QimiaSchool.Business.Abstractions;
using QimiaSchool.Business.Implementations;
using QimiaSchool.DataAccess;
using QimiaSchool.DataAccess.Repository.Abstractions;
using QimiaSchool.DataAccess.Repository.Implementations;
using QimiaSchool.Business.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<QimiaSchoolDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"), options => options.CommandTimeout(120)));



builder.Services.AddScoped<IStudentRepository, StudentRepository>();
builder.Services.AddBussinessLayer();

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
