﻿using Aries.DTO.Produto;
using Aries.Infraestrutura.Utilidades.Converter;
using Aries.WPF.Classes;
using Aries.WPF.Models.Produto;
using System;
using System.Windows;

namespace Aries.WPF.Views.Produto.Commands
{
    public class ListarProdutoPorEanCommand : AbstractCommand
    {
        public override bool CanExecute(object parameter)
            => !string.IsNullOrWhiteSpace((parameter as ListarProdutoViewModel).EAN)
            && !(parameter as ListarProdutoViewModel).EAN.Equals("0");

        public override void Execute(object parameter)
        {
            var vm = parameter as ListarProdutoViewModel;

            try
            {
                var produto = vm.Connector.Produto.GetByEan(vm.EAN);

                vm.Produtos.Clear();
                vm.Produtos.Add(Mapper.Map<ProdutoDTO, ProdutoModel>(produto));
                vm.IsEanFocused = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                vm.EAN = string.Empty;
            }
        }
    }
}