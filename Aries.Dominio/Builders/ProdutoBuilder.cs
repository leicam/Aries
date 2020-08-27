using Aries.Dominio.Entidades.Produto;

namespace Aries.Dominio.Builders
{
    public class ProdutoBuilder
    {
        private readonly Produto _produto = new Produto();
        
        public ProdutoBuilder ComEAN(string ean)
        {
            _produto.EAN = ean;
            return this;
        }

        public ProdutoBuilder ComDescricao(string descricao)
        {
            _produto.Descricao = descricao;
            return this;
        }

        public ProdutoBuilder ComValor(decimal valor)
        {
            _produto.Valor = valor;
            return this;
        }

        public ProdutoBuilder ComParteleira(string parteleira)
        {
            _produto.Prateleira = parteleira;
            return this;
        }

        public Produto Build() => _produto;
    }
}