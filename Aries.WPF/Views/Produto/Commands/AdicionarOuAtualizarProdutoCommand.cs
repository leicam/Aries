using Aries.DTO.Produto;

namespace Aries.WPF.Views.Produto.Commands
{
    public class AdicionarOuAtualizarProdutoCommand : AbstractCadastrarProduto
    {
        public override void Execute(object parameter)
        {
            _vm = (parameter as ProdutoViewModel);
            Commit();
        }

        protected override ProdutoDTO MontarDados()
            => new ProdutoDTO(_vm.Produto.EAN,
                              _vm.Produto.Descricao,
                              _vm.Produto.Valor,
                              _vm.Produto.Parteleira);
    }
}
