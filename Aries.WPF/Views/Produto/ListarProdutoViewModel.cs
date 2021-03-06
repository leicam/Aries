﻿using Aries.WPF.Models.Produto;
using Aries.WPF.Views.Produto.Commands;
using System.Collections.ObjectModel;

namespace Aries.WPF.Views.Produto
{
    public class ListarProdutoViewModel : AbstractViewModel
    {
        #region Variaveis privadas
        private string _ean = string.Empty;
        private bool _isEanFocused;
        private ObservableCollection<ProdutoModel> _produtos = new ObservableCollection<ProdutoModel>();
        private ProdutoModel _produtoSelecionado = new ProdutoModel();
        #endregion Variaveis privadas

        #region Propriedades

        public string EAN
        {
            get => _ean;
            set => SetField(ref _ean, value);
        }

        public bool IsEanFocused
        {
            get => _isEanFocused;
            set => SetField(ref _isEanFocused, value);
        }

        public ObservableCollection<ProdutoModel> Produtos
        {
            get => _produtos;
            set => SetField(ref _produtos, value);
        }

        public ProdutoModel ProdutoSelecionado 
        { 
            get => _produtoSelecionado;
            set => SetField(ref _produtoSelecionado, value);
        }

        #endregion Propriedades

        #region Comandos

        public ListarProdutosCommand ListarProdutos { get; private set; } = new ListarProdutosCommand();
        public ListarProdutoPorEanCommand ListarProdutoPorEan { get; private set; } = new ListarProdutoPorEanCommand();
        public CadastrarProdutoCommand CadastrarProduto { get; private set; } = new CadastrarProdutoCommand();
        public EditarProdutoCommand EditarProduto { get; private set; } = new EditarProdutoCommand();

        #endregion Comandos

    }
}