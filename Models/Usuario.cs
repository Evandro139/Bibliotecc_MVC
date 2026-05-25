using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MVC_Biblioteca.Models
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        public string Matricula { get; set; } = null!;

        public bool Ativo { get; set; }

        [Required]
        [StringLength(70)]
        public string Nome { get; set; } = null!;

        [Required]
        [StringLength(70)]
        [EmailAddress]
        public string Email { get; set; } = null!;

        [Required]
        [StringLength(50)]
        public string Senha { get; set; } = null!;

        // true = bibliotecário
        // false = usuário comum
        public bool TipoBib { get; set; }

        [StringLength(20)]
        public string? NumCel { get; set; }

        public ICollection<Reserva> Reservas { get; set; } = new List<Reserva>();
    }
}
