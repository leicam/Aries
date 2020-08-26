using Aries.WPF.Views.Home.Commands;

namespace Aries.WPF.Views.Home
{
    public class HomeViewModel : AbstractViewModel
    {
        public ListarClienteCommand ListarCliente { get; private set; } = new ListarClienteCommand();
        public CadastrarProdutoCommand CadastrarProduto { get; private set; } = new CadastrarProdutoCommand();
        public ListarProdutoCommand ListarProduto { get; private set; } = new ListarProdutoCommand();
    }
}