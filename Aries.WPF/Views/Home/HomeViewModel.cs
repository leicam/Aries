using Aries.WPF.Views.Home.Commands;

namespace Aries.WPF.Views.Home
{
    public class HomeViewModel : AbstractViewModel
    {
        public ListarClienteCommand ListarCliente { get; private set; } = new ListarClienteCommand();
        public ListarProdutoCommand ListarProduto { get; private set; } = new ListarProdutoCommand();
    }
}