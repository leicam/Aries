using System.Windows;

namespace Aries.WPF.Views.Produto
{
    public partial class ucListarProdutos : Window
    {
        public ucListarProdutos()
        {
            InitializeComponent();
            DataContext = new ListarProdutoViewModel();
        }
    }
}