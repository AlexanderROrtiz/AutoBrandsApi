using AutoBrands.Domain.Entities;

namespace AutoBrands.Application.Interfaces
{
    public interface IMarcaAutoService
    {
        Task<IEnumerable<MarcaAuto>> GetAllMarcasAsync();
    }
}
