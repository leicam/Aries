using Aries.Dominio.Entidades.Produto;
using Aries.Infraestrutura.Repositorio.Contexto;
using Aries.Infraestrutura.Repositorio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Aries.Infraestrutura.Repositorio.Repositorios
{
    public class ProdutoRepositorio : AbstractRepositorio<Produto>, IProdutoRepositorio
    {
        public ProdutoRepositorio(AriesContext contexto) : base(contexto) { }

        public void AdicionarOuAlterar(Produto produto)
        {
            if (string.IsNullOrWhiteSpace(produto.EAN))
                throw new ArgumentException("Informe o código de barras do produto!");
            else if (string.IsNullOrWhiteSpace(produto.Descricao))
                throw new ArgumentException("Informe a descrição do produto!");
            else if (produto.Valor <= 0)
                throw new ArgumentException("Informe o valor do produto!");

            AddOrUpdate(produto);
            SaveChanges();
        }

        public IEnumerable<Produto> CarregarTodos()
            => GetAll();

        public Produto GetByEAN(string ean)
            => Set.FirstOrDefault(x => x.EAN == ean);

        public void Remover(Produto produto)
        {
            Remove(produto);
            SaveChanges();
        }
    }
}