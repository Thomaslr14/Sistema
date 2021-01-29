using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using systema.BancoDeDados;
using systema.Classes;

namespace systema
{
    /// <summary>
    /// Interaction logic for InitialPage.xaml
    /// </summary>
    public partial class InitialPage : Window
    {
        Funcoes Funcoes = new Funcoes();

        public InitialPage()
        {

        }

        private void Logar_Click(object sender, RoutedEventArgs e)
        {
            //Salt.GetSalt();
            var hash = Hash.GenerateHash(Senha_pwdbox.Password);
            Hash.Enconding(hash);
            Funcoes.ValidarConexaoBD(Usuario_txtbox.Text);

           // Funcoes.IniciarConexaoBD(users.Username);
            

            /* using (var bd = new ConexaoContext())
            {

                DateTime date = new DateTime(1997,10,14);
                bd.Usuarios.Add(new Usuario { Nome = "Thomas Lidio Rodrigues", Email = "thomas.rodriguestj@gmail.com", DataNasc = date });
                bd.Senhas.Add(new Senha { SenhaUsuario = "Senha@123" });
                bd.SaveChanges();


            } */

        }

        private void WindowLoaded(object sender, RoutedEventArgs e)
        {
            InitializeComponent();
            
        }


    }
}


