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
        private string _Username { get; set; }
        public string Username 
        { 
            get { return _Username; }
            set
            {


                // Se o Username estiver preenchido o Button recebe um valor true
                if (!string.IsNullOrWhiteSpace(value))
                {
                     _Username = value;
                     NotifyPropertyChanged("_Username");
                    
                     Button = true;
                     NotifyPropertyChanged("Button");

                }
                // Se o Username NÃO estiver preenchido o Button recebe um valor false
                else
                {
                    _Username = value;
                    NotifyPropertyChanged("_Username");

                    Button = false;
                    NotifyPropertyChanged("Button");
                }
            }
        }



        private bool _Button { get; set; }

        public bool Button
        {
            get { return _Button; }
            set
            {
                _Button = value;
                NotifyPropertyChanged("_Button");
            }
        }



        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] string propertyname = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
        }



    }
}
