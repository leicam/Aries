using Aries.WPF.Models.Cliente;
using Aries.WPF.Models.Produto;
using Aries.WPF.Views.Cliente;
using Aries.WPF.Views.Home;
using Aries.WPF.Views.Produto;

namespace Aries.WPF.Classes
{
    internal static class GerenciadorTelas
    {
        #region Home
        public static void MainWindow() => new ucHome().Show();
        #endregion Home

        #region Cliente
        public static void ListarCliente() => new ucListarCliente().ShowDialog();
        public static void CadastrarCliente() => new ucCadastrarCliente().ShowDialog();
        public static void EditarCliente(ClienteModel cliente) => new ucCadastrarCliente(cliente);
        #endregion Cliente

        #region Produto
        public static void ListarProduto() => new ucListarProdutos().ShowDialog();
        public static void CadastrarProduto() => new ucCadastrarProduto().ShowDialog();
        public static void EditarProduto(ProdutoModel produto) => new ucCadastrarProduto(produto).ShowDialog();
        #endregion Produto
    }
}