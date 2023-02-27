using FindYourPartyBackend.Data.Models.DbModels;
using FindYourPartyBackend.Data.Models.Dto.DtoPagination;
using FindYourPartyBackend.Data.Models.Dto.DtoValidators;
using FindYourPartyBackend.Data.Seeder;
using FindYourPartyBackend.Services;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration["ConnectionString"];

// Add services to the container.
builder.Services.AddEntityFrameworkNpgsql().AddDbContext<ApiDbContext>(opt => opt.UseNpgsql(connectionString));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<DbSeeder>();
builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());
builder.Services.AddScoped<IClubService, ClubService>();
builder.Services.AddControllers().AddFluentValidation();
builder.Services.AddScoped<IValidator<PaginationDto>, PaginationDtoValidator>();
builder.Services.AddHttpContextAccessor();

var app = builder.Build();

var scope = app.Services.CreateScope();
var seeder = scope.ServiceProvider.GetRequiredService<DbSeeder>();
seeder.Seed();

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
