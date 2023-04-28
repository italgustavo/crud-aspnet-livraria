using Microsoft.EntityFrameworkCore;
using SistemaBiblioteca.Models;

namespace SistemaBiblioteca.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Endereco> Endereco { get; set; }
        public DbSet<Estoque> Estoques { get; set; }
        public DbSet<Livros> Livros { get; set; }
        public DbSet<Pedidos> Pedidos { get; set; }
        public DbSet<Pessoa> Pessaos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pessoa>()
                .HasOne(p => p.Endereco)
                .WithOne(e => e.Pessoa)
                .HasForeignKey<Endereco>(e => e.Id);

            modelBuilder.Entity<Livros>()
                .HasOne(p => p.Estoque)
                .WithMany(e => e.Livro)
                .HasForeignKey(e => e.Id);

        }

    }

}
