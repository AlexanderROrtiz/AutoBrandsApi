using AutoBrands.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AutoBrands.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MarcasAutosController : ControllerBase
    {
        private readonly IMarcaAutoService _service;

        public MarcasAutosController(IMarcaAutoService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var marcas = await _service.GetAllMarcasAsync();
            return Ok(marcas);
        }
    }
}
