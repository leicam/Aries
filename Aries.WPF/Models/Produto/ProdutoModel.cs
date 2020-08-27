﻿namespace Aries.WPF.Models.Produto
{
    public class ProdutoModel : AbstractModel
    {
        #region Variaveis privadas
        private int _ean = 0;
        private string _descricao = string.Empty;
        private decimal _valor = 0.0m;
        private string _parteleira = string.Empty;
        #endregion Variaveis privadas

        #region Propriedades
        public int EAN 
        { 
            get => _ean;
            set => SetField(ref _ean, value);
        }

        public string Descricao 
        { 
            get => _descricao;
            set => SetField(ref _descricao, value);
        }

        public decimal Valor
        {
            get => _valor;
            set => SetField(ref _valor, value);
        }

        public string Parteleira
        {
            get => _parteleira;
            set => SetField(ref _parteleira, value);
        }

        #endregion Propriedades
    }
}