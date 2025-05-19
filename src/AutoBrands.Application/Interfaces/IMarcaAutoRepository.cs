using AutoBrands.Domain.Entities;

namespace AutoBrands.Application.Interfaces
{
    public interface IMarcaAutoRepository
    {
        Task<IEnumerable<MarcaAuto>> GetAllAsync();
    }
}
