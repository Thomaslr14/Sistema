using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace systema.BancoDeDados
{
    // Classe para iniciar conexão ao banco de dados
    class ConexaoContext : DbContext
    {
        public ConexaoContext()
            : base("name=connect_SysStema")
        { }

        // Tabelas que serão criadas no Banco
        
        public DbSet<Usuario> Usuarios { get; set; }
       
    }
}
        