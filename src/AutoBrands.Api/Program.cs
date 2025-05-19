using AutoBrands.Application.Interfaces;
using AutoBrands.Application.Services;
using AutoBrands.Infrastructure.Persistence;
using AutoBrands.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace AutoBrands.Api;

[ExcludeFromCodeCoverage]

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // PostgreSQL connection string
        builder.Services.AddDbContext<AutoBrandsDbContext>(options =>
        options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

        builder.Services.AddScoped<IMarcaAutoService, MarcaAutoService>();
        builder.Services.AddScoped<IMarcaAutoRepository, MarcaAutoRepository>();        
        builder.Services.AddScoped<MarcaAutoService>();

        builder.Services.AddControllers();
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

        app.UseRouting();

        app.UseAuthorization();
        app.MapControllers();

        app.Run();
    }
}