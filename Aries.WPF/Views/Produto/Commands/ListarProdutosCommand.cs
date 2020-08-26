using Aries.DTO.Produto;
using Aries.Infraestrutura.Utilidades.Converter;
using Aries.Infraestrutura.Utilidades.Extensions;
using Aries.WPF.Classes;
using Aries.WPF.Models.Produto;
using System.Collections.Generic;
using System.Linq;

namespace Aries.WPF.Views.Produto.Commands
{
    public class ListarProdutosCommand : AbstractCommand
    {
        public override void Execute(object parameter)
        {
            var vm = parameter as ListarProdutoViewModel;
            var produtos = vm.Connector.Produto.GetAll();

            vm.Produtos.Clear();
            vm.Produtos.AddRange(Mapper.Map<List<ProdutoDTO>, List<ProdutoModel>>(produtos.ToList()));
        }
    }
}