using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicando_MVVM.Model
{
    class Cliente : INotifyPropertyChanged
    {

        public int ID { get; set; }
        private string _nome;
        private string _email;
        private string _endereco;

        public string Nome
        {
            get { return _nome; }
            set
            {
                if (_nome != value)
                {
                    _nome = value;
                    RaisePropertyChanged("Nome");
                }
            }
        }

        public string Email
        {
            get { return _email; }
            set
            {
                if (_email != value)
                {
                    _email = value;
                    RaisePropertyChanged("Email");
                }
            }
        }

        public string Endereco
        {
            get { return _endereco; }
            set
            {
                if (_endereco != value)
                {
                    _endereco = value;
                    RaisePropertyChanged("Endereco");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void RaisePropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
    }
}
