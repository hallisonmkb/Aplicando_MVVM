using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Aplicando_MVVM.Model;

namespace Aplicando_MVVM.ViewModel
{
    class ClienteViewModel
    {
        public ObservableCollection<Cliente> Clientes { get; set; }

        public void LoadClientes()
        {
            ObservableCollection<Cliente> clientes = new ObservableCollection<Cliente>();

            clientes.Add(new Cliente { Nome = "Hallison", Email = "hallisonmkb@gmail.com", Endereco = "Rua Frederico Gassenferth, 78" });
            clientes.Add(new Cliente { Nome = "Bruna", Email = "brunabitten90@gmail.com.br", Endereco = "Rua Dona Francisca, 5216" });

            Clientes = clientes;
        }
    }
}
