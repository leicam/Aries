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

        public void AddOrUpdate(ProdutoDTO dto) => _produtoServico.AddOrUpdate(dto);
        public void Remove(ProdutoDTO dto) => _produtoServico.Remove(dto);
        public IEnumerable<ProdutoDTO> GetAll() => _produtoServico.GetAll();
    }
}