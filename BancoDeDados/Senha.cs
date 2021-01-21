using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace systema.BancoDeDados
{
    public class Senha
    {
        
        [Key]
        public int Id { get; set; }
        [Required]
        public string SenhaUsuario { get; set; }

        public int SenhaId { get; set; }

        [ForeignKey("SenhaId")]
        public Usuario Usuario { get; set; }
    }
}
