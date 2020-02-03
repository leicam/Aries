using Aries.WPF.Models.Cliente;
using System.Windows;

namespace Aries.WPF.Views.Cliente
{
    public partial class ucCadastrarCliente : Window
    {
        public ucCadastrarCliente()
        {
            InitializeComponent();
            DataContext = new ClienteViewModel();
        }

        public ucCadastrarCliente(ClienteModel cliente)
        {
            InitializeComponent();
            DataContext = new ClienteViewModel(cliente);
        }
    }
}