using Microsoft.EntityFrameworkCore;
using SistemaBiblioteca.Models;

namespace SistemaBiblioteca.Data
{
    public class ApplicatinDbContext : DbContext
    {
        public DbSet<Endereco> Endereco { get; set; }
        public DbSet<Estoque> Estoques { get; set; }
        public DbSet<Livros> Livros { get; set; }
        public DbSet<Pedidos> Pedidos { get; set; }
        public DbSet<Pessoa> Pessaos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost;Database=SistemaBiblioteca;User=root;Password=12345;");
        }
    }
}
