using Aries.DTO.Produto;
using Aries.WPF.Classes;
using Aries.WPF.Models.Produto;
using System;
using System.Windows;

namespace Aries.WPF.Views.Produto.Commands
{
    public abstract class AbstractCadastrarProduto : AbstractCommand
    {
        protected ProdutoViewModel _vm;

        protected void Commit()
        {
            try
            {
                _vm.Connector.Produto.AddOrUpdate(MontarDados());
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            if(_vm.IsEdicao)
            {
                MessageBox.Show("Produto alterado com sucesso!");
                CloseWindow();
            }
            else
            {
                MessageBox.Show("Produto cadastrado com sucesso!"); 
                _vm.Produto = new ProdutoModel();
            }
        }

        protected abstract ProdutoDTO MontarDados();
    }
}