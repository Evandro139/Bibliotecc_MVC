using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace MVC_Biblioteca.Models
{
    public class Livro
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Titulo { get; set; } = null!;

        [Required]
        [StringLength(100)]
        public string Autor { get; set; } = null!;

        public int AnoPublicado { get; set; }

        [Required]
        [StringLength(1)]
        public string Status { get; set; } = null!;

        // D = Disponível
        // E = Emprestado
        // I = Indisponível

        public string Sinopse { get; set; } = null!;

        [Required]
        [StringLength(50)]
        public string Editora { get; set; } = null!;

        public string? Imagem { get; set; }

        public ICollection<Reserva> Reservas { get; set; } = new List<Reserva>();

        public ICollection<LivroCategoria> LivroCategorias { get; set; } = new List<LivroCategoria>();
    }
}