using Aries.WPF.Models.Produto;
using Aries.WPF.Views.Produto.Commands;

namespace Aries.WPF.Views.Produto
{
    public class ProdutoViewModel : AbstractViewModel
    {
        private bool _isEanEnable = true;
        private ProdutoModel _produto = new ProdutoModel();

        internal bool IsEdicao { get; private set; } = false;

        public bool IsEanEnable
        {
            get => _isEanEnable;
            set => SetField(ref _isEanEnable, value);
        }

        public ProdutoModel Produto
        {
            get => _produto;
            set => SetField(ref _produto, value);
        }

        public AdicionarOuAtualizarProdutoCommand AdicionarOuAtualizarProduto { get; private set; } = new AdicionarOuAtualizarProdutoCommand();

        public ProdutoViewModel() { }

        public ProdutoViewModel(ProdutoModel produto)
        {
            IsEanEnable = false;
            IsEdicao = true;
            Produto = produto;
        }
    }
}