using AutoBrands.Application.Interfaces;
using AutoBrands.Domain.Entities;

namespace AutoBrands.Application.Services
{
    public class MarcaAutoService: IMarcaAutoService
    {
        private readonly IMarcaAutoRepository _repository;

        public MarcaAutoService(IMarcaAutoRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<MarcaAuto>> GetAllMarcasAsync()
        {
            return await _repository.GetAllAsync();
        }
    }
}
