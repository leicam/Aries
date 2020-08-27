using Aries.WPF.Classes;

namespace Aries.WPF.Views.Produto.Commands
{
    public class CadastrarProdutoCommand : AbstractCommand
    {
        public override void Execute(object parameter)
        {
            var vm = parameter as ListarProdutoViewModel;

            GerenciadorTelas.CadastrarProduto();
            vm.ExecutarCommand(vm.ListarProdutos);
        }
    }
}