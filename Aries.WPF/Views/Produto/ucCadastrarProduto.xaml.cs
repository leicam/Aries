using Aries.WPF.Models.Produto;
using System.Windows;

namespace Aries.WPF.Views.Produto
{
    public partial class ucCadastrarProduto : Window
    {
        public ucCadastrarProduto()
        {
            InitializeComponent();
            DataContext = new ProdutoViewModel();
        }

        public ucCadastrarProduto(ProdutoModel produto)
        {
            InitializeComponent();
            DataContext = new ProdutoViewModel(produto);
        }
    }
}