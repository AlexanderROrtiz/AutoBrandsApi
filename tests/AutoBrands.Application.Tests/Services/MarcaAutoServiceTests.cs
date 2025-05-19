using AutoBrands.Application.Services;
using AutoBrands.Domain.Entities;
using AutoBrands.Infrastructure.Persistence;
using AutoBrands.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

namespace AutoBrands.Application.Tests.Services
{
    public class MarcaAutoServiceTests
    {
        private AutoBrandsDbContext GetInMemoryDbContext()
        {
            var options = new DbContextOptionsBuilder<AutoBrandsDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;

            var context = new AutoBrandsDbContext(options);

            // Aseguramos que la base de datos esté limpia
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();

            return context;
        }

        [Fact]
        public async Task GetAllMarcasAsync_ReturnsAllMarcas()
        {
            // Arrange
            var context = GetInMemoryDbContext();

            // Seed manual para asegurar datos de prueba -- Comentar la sección de Seed en el AutoBrandsDbContext para probar
            context.MarcasAutos.AddRange(new List<MarcaAuto>
        {
            new MarcaAuto { Id = 1, Nombre = "Toyota" },
            new MarcaAuto { Id = 2, Nombre = "Ford" },
            new MarcaAuto { Id = 3, Nombre = "Honda" }
        });
            await context.SaveChangesAsync();

            var repository = new MarcaAutoRepository(context);
            var service = new MarcaAutoService(repository);

            // Act
            var result = await service.GetAllMarcasAsync();

            // Assert
            Assert.NotNull(result);
            Assert.Equal(3, result.Count());
            Assert.Contains(result, m => m.Nombre == "Toyota");
            Assert.Contains(result, m => m.Nombre == "Ford");
            Assert.Contains(result, m => m.Nombre == "Honda");
        }
    }
}
