using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MVC_Biblioteca.Models
{
    public class Categoria
    {
        [Key]
        public int Id { get; set; }

        public ICollection<Reserva> Reservas { get; set; } = new List<Reserva>();

        public ICollection<LivroCategoria> LivroCategorias { get; set; } = new List<LivroCategoria>();
    }
}