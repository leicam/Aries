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
    }
}