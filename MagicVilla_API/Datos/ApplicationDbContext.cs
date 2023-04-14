using MagicVilla_API.Modelos;
using Microsoft.EntityFrameworkCore;

namespace MagicVilla_API.Datos
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
            
        }
        public DbSet<Villa> Villas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Villa>().HasData(
                new Villa()
                {
                    Id = 1,
                    Nombre = "Villa Real",
                    Detalle = "Detalle de la Villa",
                    ImagenUrl = "",
                    Ocupantes = 5,
                    MetrosCuadrado = 20,
                    Tarifa = 200,
                    Amenidad = "",
                    FechaCreacion = DateTime.Now,
                    FechaActualizacion = DateTime.Now,
                },
                new Villa()
                {
                    Id = 2,
                    Nombre = "Villa Real2",
                    Detalle = "Detalle de la Villa2",
                    ImagenUrl = "",
                    Ocupantes = 4,
                    MetrosCuadrado = 40,
                    Tarifa = 500,
                    Amenidad = "",
                    FechaCreacion = DateTime.Now,
                    FechaActualizacion = DateTime.Now,
                }
                );
        }
    }
}
