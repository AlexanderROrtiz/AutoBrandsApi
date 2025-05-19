using AutoBrands.Application.Interfaces;
using AutoBrands.Domain.Entities;
using AutoBrands.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace AutoBrands.Infrastructure.Repositories
{
    public class MarcaAutoRepository : IMarcaAutoRepository
    {
        private readonly AutoBrandsDbContext _context;

        public MarcaAutoRepository(AutoBrandsDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<MarcaAuto>> GetAllAsync()
        {
            return await _context.MarcasAutos.ToListAsync();
        }
    }
}

