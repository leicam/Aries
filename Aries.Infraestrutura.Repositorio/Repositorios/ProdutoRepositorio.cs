using Aries.Dominio.Entidades.Produto;
using Aries.Infraestrutura.Repositorio.Contexto;
using Aries.Infraestrutura.Repositorio.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Aries.Infraestrutura.Repositorio.Repositorios
{
    public class ProdutoRepositorio : AbstractRepositorio<Produto>, IProdutoRepositorio
    {
        public ProdutoRepositorio(AriesContext contexto) : base(contexto) { }

        public void AdicionarOuAlterar(Produto produto)
        {
            AddOrUpdate(produto);
            SaveChanges();
        }

        public IEnumerable<Produto> CarregarTodos()
            => GetAll();

        public Produto GetByEAN(int ean)
            => Set.FirstOrDefault(x => x.EAN == ean);

        public void Remover(Produto produto)
        {
            Remove(produto);
            SaveChanges();
        }
    }
}