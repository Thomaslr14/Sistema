using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace systema.Classes
{
    public class Users : INotifyPropertyChanged
    {
        

        Funcoes Funcoes = new Funcoes();

        
        private string _Username { get; set; }
        public string Username 
        { 
            get { return _Username; }
            set
            {
                // Se o Username estiver preenchido ele recebe um valor true
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _Username = value;
                    NotifyPropertyChanged("_Username");
                }

                // Se o Username NÃO estiver preenchido ele recebe um valor false
                
            }
        }



        private bool _Button { get; set; }

        private bool Button
        {
            get { return _Button; }
            set 
            { 
                if (Username != null)
                {
                    _Button = false ;
                }
                
            }
        }



        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] string propertyname = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyname));
            }
        }



    }
}
