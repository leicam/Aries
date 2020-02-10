using Aries.Aplicacao.Interfaces;
using Aries.DTO.Produto;
using System.Collections.Generic;

namespace Aries.Connector.Produto
{
    public class ProdutoConnector
    {
        private readonly IProdutoServico _produtoServico;

        public ProdutoConnector(IProdutoServico produtoServico)
        {
            _produtoServico = produtoServico;
        }

        void AddOrUpdate(ProdutoDTO dto) => _produtoServico.AddOrUpdate(dto);
        void Remove(ProdutoDTO dto) => _produtoServico.Remove(dto);
        IEnumerable<ProdutoDTO> GetAll() => _produtoServico.GetAll();
    }
}