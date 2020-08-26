using Aries.Aplicacao.Interfaces;
using Aries.Dominio.Builders;
using Aries.Dominio.Entidades.Produto;
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
            => _produtoRepositorio.AdicionarOuAlterar(MontarDados(produtoDTO));

        private Produto MontarDados(ProdutoDTO produtoDTO)
        {
            var produto = _produtoRepositorio.GetByEAN(produtoDTO.EAN);

            if (produto != null)
            {
                produto.Descricao = produtoDTO.Descricao;
                produto.Valor = produtoDTO.Valor;
                produto.Parteleira = produtoDTO.Parteleira;

                return produto;
            }

            return new ProdutoBuilder()
                .ComDescricao(produtoDTO.Descricao)
                .ComEAN(produtoDTO.EAN)
                .ComValor(produtoDTO.Valor)
                .ComParteleira(produtoDTO.Parteleira)
                .Build();
        }

        public IEnumerable<ProdutoDTO> GetAll()
        {
            var lista = new List<ProdutoDTO>();
            var produtos = _produtoRepositorio.CarregarTodos();

            produtos
                .ToList()
                .ForEach(x => { lista.Add(new ProdutoDTO(x.EAN, x.Descricao, x.Valor, x.Parteleira)); });

            return lista.AsEnumerable();
        }

        public void Remove(ProdutoDTO produtoDTO) 
            => _produtoRepositorio.Remover(_produtoRepositorio.GetByEAN(produtoDTO.EAN));
    }
}