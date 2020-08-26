using System.Windows;

namespace Aries.WPF.Views.Cliente
{
    public partial class ucListarCliente : Window
    {
        public ucListarCliente()
        {
            InitializeComponent();
            DataContext = new ListarClienteViewModel();
        }
    }
}