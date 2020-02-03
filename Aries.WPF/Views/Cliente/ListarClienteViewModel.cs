using Aries.Infraestrutura.Utilidades.Extensions;
using Aries.WPF.Models.Cliente;
using Aries.WPF.Views.Cliente.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aries.WPF.Views.Cliente
{
    public class ListarClienteViewModel : AbstractViewModel
    {
        private ObservableCollection<ClienteModel> _clientes = new ObservableCollection<ClienteModel>();
        private ClienteModel _clienteSelecionado = new ClienteModel();

        public ObservableCollection<ClienteModel> Clientes
        {
            get => _clientes;
            set => SetField(ref _clientes, value);
        }

        public ClienteModel ClienteSelecionado
        {
            get => _clienteSelecionado;
            set => SetField(ref _clienteSelecionado, value);
        }

        public ListarClientesCommand ListarClientes { get; private set; } = new ListarClientesCommand();
        public CadastrarClienteCommand CadastrarCliente { get; private set; } = new CadastrarClienteCommand();
    }
}