using Aries.DTO.Produto;
using System.Collections.Generic;

namespace Aries.Aplicacao.Interfaces
{
    public interface IProdutoServico
    {
        void AddOrUpdate(ProdutoDTO produtoDTO);
        void Remove(ProdutoDTO produtoDTO);
        IEnumerable<ProdutoDTO> GetAll();
    }
}