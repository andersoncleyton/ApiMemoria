using ApiMemoria.Model;
using Microsoft.EntityFrameworkCore;

namespace ApiMemoria.Data
{
    public class DataContext : DbContext
    {
         public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Filme> Filmes{get; set;}
        public DbSet<Categoria> Categorias{get; set;}
    }
}