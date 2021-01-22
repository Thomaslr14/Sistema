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
        public void LimparCampos(TextBox textbox)
        {
            textbox.Text = "";
        }

        public void ValidarLogin(String nome, String password)
        {
            using (var bd = new ConexaoContext())
            {

                bool ValidaNome()
                {
                    bool nn = bd.Usuarios.Where(b => b.NomeUsuario == nome).Any();
                    if(nn) { return true; } else { return false; }
                }

                bool ValidaSenha()
                {
                    bool pp = bd.Senhas.Where(p => p.SenhaUsuario == password).Any();
                    if (pp) { return true; } else { return false; }
                }

                if (ValidaNome() == true && ValidaSenha() == true)
                { 

                }
                if (ValidaNome() == false && ValidaSenha()  == true)
                { 

                }


                /* bool nn = bd.Usuarios.Where(b => b.NomeUsuario == nome).Any();
                bool pp = bd.Senhas.Where(p => p.SenhaUsuario == password).Any();
                if (nn == true && pp == true)
                {
                    MessageBox.Show("Achei o nome e a senha ");
                } 
                else 
                {
                    MessageBox.Show("Não achei nada");
                } */

                
            }     
        }
    }
}
