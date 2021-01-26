using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace systema.BancoDeDados
{
    public class Usuario
    {
        
        [Key]
        public int Id { get; set; }

        [Required]
        public string NomeUsuario { get; set; }

        [Required,MaxLength(120),MinLength(10)]
        public string Nome { get; set; }

        [Required,MaxLength(50)]
        public string Email { get; set; }

        public DateTime DataNasc { get; set; }
        public List<Senha> Senhas { get; set; }
        
    }
}
