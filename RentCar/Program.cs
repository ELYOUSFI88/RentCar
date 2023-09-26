using Microsoft.EntityFrameworkCore;
using RentCar_Data.DContext;
using RentCar_Data.Repository.Implementation;
using RentCar_Data.Repository.Signatures;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<RentCarContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("RentCarConnection")));
builder.Services.AddTransient<IRepositoryManager, RepositoryManager>();
builder.Services.AddCors();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseCors(Options => Options.WithOrigins("http://localhost:4200").AllowAnyMethod().AllowAnyHeader());
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
