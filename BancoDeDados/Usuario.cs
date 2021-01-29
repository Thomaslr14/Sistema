using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace systema.BancoDeDados
{
    [Table("USUARIOS")]
    public class Usuario
    {
        
        [Key]
        public int Id { get; set; }

        [Required,MaxLength(20)]
        public string NomeUsuario { get; set; }

        [Required, MaxLength(30)]
        public string SenhaLogin { get; set; }

        [Required,MaxLength(120),MinLength(10)]
        public string Nome { get; set; }

        [Required,MaxLength(50)]
        public string Email { get; set; }

        [Required]
        public DateTime DataNasc { get; set; }
        
        
    }
}
