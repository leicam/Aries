using Aries.Dominio.Entidades.Produto;
using Aries.Infraestrutura.Repositorio.Contexto;
using Aries.Infraestrutura.Repositorio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public void Remover(Produto produto)
        {
            Remove(produto);
            SaveChanges();
        }
    }
}