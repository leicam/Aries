using Aries.Dominio.Entidades.Produto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aries.Infraestrutura.Repositorio.Interfaces
{
    public interface IProdutoRepositorio
    {
        IEnumerable<Produto> CarregarTodos();
        void AdicionarOuAlterar(Produto produto);
        void Remover(Produto produto);
    }
}