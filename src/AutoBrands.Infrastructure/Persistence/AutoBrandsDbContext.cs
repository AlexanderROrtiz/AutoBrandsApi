using AutoBrands.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace AutoBrands.Infrastructure.Persistence
{
    public class AutoBrandsDbContext : DbContext
    {
        public AutoBrandsDbContext(DbContextOptions<AutoBrandsDbContext> options) : base(options) { }

        public DbSet<MarcaAuto> MarcasAutos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed data Para la primera migracion descomentar luego para pruebas unitarias comentar las lineas
            //modelBuilder.Entity<MarcaAuto>().HasData(
            //    new MarcaAuto { Id = 1, Nombre = "Toyota" },
            //    new MarcaAuto { Id = 2, Nombre = "Ford" },
            //    new MarcaAuto { Id = 3, Nombre = "Honda" }
            //);
        }
    }
}
