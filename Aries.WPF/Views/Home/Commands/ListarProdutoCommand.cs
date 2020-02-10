using Aries.WPF.Classes;

namespace Aries.WPF.Views.Home.Commands
{
    public class ListarProdutoCommand : AbstractCommand
    {
        public override void Execute(object parameter) => GerenciadorTelas.ListarProduto();
    }
}