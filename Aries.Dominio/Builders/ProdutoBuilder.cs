using Aries.Dominio.Entidades.Produto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aries.Dominio.Builders
{
    public class ProdutoBuilder
    {
        private readonly Produto _produto = new Produto();
        
        public ProdutoBuilder ComEAN(int ean)
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

        public Produto Build() => _produto;
    }
}