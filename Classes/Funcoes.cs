using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;
using systema.BancoDeDados;


namespace systema.Classes
{
    class Funcoes 
    {
        
        public void ValidarConexaoBD (string username)
        {
            using (var bd = new ConexaoContext())
            {
                // Procura pelo usuario no Banco de Dados
                var result = bd.Usuarios.Where(u => u.NomeUsuario == username).FirstOrDefault();

                if (result != null)
                {
                    MessageBox.Show("Usuario true");
                }
                else
                {
                    MessageBox.Show("Usuario false");
                }

               
                


            }
        }




        
    }
}
