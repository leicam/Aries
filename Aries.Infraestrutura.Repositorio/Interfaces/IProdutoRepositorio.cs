using Aries.Dominio.Entidades.Produto;
using System.Collections.Generic;

namespace Aries.Infraestrutura.Repositorio.Interfaces
{
    public interface IProdutoRepositorio
    {
        IEnumerable<Produto> CarregarTodos();
        Produto GetByEAN(string ean);
        void AdicionarOuAlterar(Produto produto);
        void Remover(Produto produto);
    }
}