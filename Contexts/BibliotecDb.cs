using Microsoft.EntityFrameworkCore;
using MVC_Biblioteca.Models;

namespace MVC_Biblioteca.Contexts
{
    public class BibliotecDb : DbContext
    {
        public BibliotecDb(DbContextOptions<BibliotecDb> options)
            : base(options){}

        public DbSet<Usuario> Usuario { get; set; } = null!;
        public DbSet<Categoria> Categoria { get; set; } = null!;
        public DbSet<Livro> Livro { get; set; } = null!;
        public DbSet<LivroCategoria> LivroCategoria { get; set; } = null!;
        public DbSet<Reserva> Reserva { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<LivroCategoria>()
                .HasKey(lc => new { lc.LivroId, lc.CategoriaId });
        }
    }
}