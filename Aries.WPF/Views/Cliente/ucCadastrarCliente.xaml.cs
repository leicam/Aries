using System.Windows;

namespace Aries.WPF.Views.Cliente
{
    public partial class ucCadastrarCliente : Window
    {
        public ucCadastrarCliente(ClienteViewModel vm)
        {
            InitializeComponent();
            DataContext = vm;
        }

        //public static void Cadastrar() => new ucCadastrarCliente().ShowDialog();
    }
}