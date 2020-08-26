using Aries.WPF.Classes;

namespace Aries.WPF.Views.Produto.Commands
{
    public class EditarProdutoCommand : AbstractCommand
    {
        public override void Execute(object parameter) 
            => GerenciadorTelas.EditarProduto((parameter as ListarProdutoViewModel).ProdutoSelecionado);
    }
}