using CatalogoMagic.Models;
using Microsoft.EntityFrameworkCore;

namespace CatalogoMagic.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Categoria>? Categorias { get; set; }
        public DbSet<Carta>? Cartas { get; set; }
    }
}
