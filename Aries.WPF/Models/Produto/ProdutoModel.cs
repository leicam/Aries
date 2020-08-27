namespace Aries.WPF.Models.Produto
{
    public class ProdutoModel : AbstractModel
    {
        #region Variaveis privadas
        private string _ean = string.Empty;
        private string _descricao = string.Empty;
        private decimal _valor = 0.0m;
        private string _prateleira = string.Empty;
        #endregion Variaveis privadas

        #region Propriedades
        public string EAN 
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

        public string Prateleira
        {
            get => _prateleira;
            set => SetField(ref _prateleira, value);
        }

        #endregion Propriedades
    }
}