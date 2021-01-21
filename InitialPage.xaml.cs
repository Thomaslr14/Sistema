using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
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
        public InitialPage()
        {
            InitializeComponent();
        }

        private void Logar_Click(object sender, RoutedEventArgs e)
        {
            /* using (var bd = new ConexaoContext())
            {

                DateTime date = new DateTime(1997,10,14);
                bd.Usuarios.Add(new Usuario { Nome = "Thomas Lidio Rodrigues", Email = "thomas.rodriguestj@gmail.com", DataNasc = date });
                bd.Senhas.Add(new Senha { SenhaUsuario = "Senha@123" });
                bd.SaveChanges();


            } */
            Funcoes f = new Funcoes();
            f.ValidarLogin(Convert.ToString(Usuario_txtbox.Text), Senha_pwdbox.Password);

            //string password = Senha_pwdbox.Password;
            

        }
        

    }
}

