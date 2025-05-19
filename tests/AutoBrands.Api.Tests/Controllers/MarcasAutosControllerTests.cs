
using AutoBrands.Api.Controllers;
using AutoBrands.Application.Interfaces;
using AutoBrands.Application.Services;
using AutoBrands.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Moq;

namespace AutoBrands.Api.Tests.Controllers
{
    public class MarcasAutosControllerTests
    {
        [Fact]
        public async Task Get_ListOfMarcas()
        {
            // Arrange
            var mockRepository = new Mock<IMarcaAutoRepository>();
            var marcasMock = new List<MarcaAuto>
            {
                new MarcaAuto { Id = 1, Nombre = "Toyota" },
                new MarcaAuto { Id = 2, Nombre = "Ford" }
            };

            mockRepository.Setup(s => s.GetAllAsync()).ReturnsAsync(marcasMock);

            var service = new MarcaAutoService(mockRepository.Object);
            var controller = new MarcasAutosController(service);    

            // Act
            var result = await controller.Get();

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result);
            var returnValue = Assert.IsAssignableFrom<IEnumerable<MarcaAuto>>(okResult.Value);
            Assert.Equal(marcasMock.Count, returnValue.Count());
        }
    }
}
