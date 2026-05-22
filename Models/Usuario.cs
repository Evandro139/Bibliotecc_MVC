using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Bibliotec.Models
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        public string Matricula {get; set;} = null!;

        public bool Ativo { get; set; }

        [Required]
        [StringLength(100)]

        public string Nome {get; set;}=null!;

        [Required]
        [StringLength(50)]

        public string Senha {get; set;}= null!;
    }
}