using Aries.Aplicacao.Interfaces;
using Aries.Dominio.Builders;
using Aries.DTO.Produto;
using Aries.Infraestrutura.Repositorio.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Aries.Aplicacao.Servicos
{
    public class ProdutoServico : IProdutoServico
    {
        private readonly IProdutoRepositorio _produtoRepositorio;

        public ProdutoServico(IProdutoRepositorio produtoRepositorio)
        {
            _produtoRepositorio = produtoRepositorio;
        }

        public void AddOrUpdate(ProdutoDTO produtoDTO)
        {
            _produtoRepositorio.AdicionarOuAlterar(new ProdutoBuilder()
                .ComDescricao(produtoDTO.Descricao)
                .ComEAN(produtoDTO.EAN)
                .ComValor(produtoDTO.Valor)
                .Build());
        }

        public IEnumerable<ProdutoDTO> GetAll()
        {
            var lista = new List<ProdutoDTO>();
            var produtos = _produtoRepositorio.CarregarTodos();

            produtos
                .ToList()
                .ForEach(x => { lista.Add(new ProdutoDTO(x.EAN, x.Descricao, x.Valor)); });

            return lista.AsEnumerable();
        }

        public void Remove(ProdutoDTO produtoDTO)
        {
            var produto = _produtoRepositorio
                .CarregarTodos()
                .ToList()
                .FirstOrDefault(x => x.EAN.Equals(produtoDTO.EAN));

            _produtoRepositorio.Remover(produto);
        }
    }
}