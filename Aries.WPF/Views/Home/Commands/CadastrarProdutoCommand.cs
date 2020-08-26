using Aries.WPF.Classes;

namespace Aries.WPF.Views.Home.Commands
{
    public class CadastrarProdutoCommand : AbstractCommand
    {
        public override void Execute(object parameter) => GerenciadorTelas.CadastrarProduto();
    }
}