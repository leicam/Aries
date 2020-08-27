namespace Aries.DTO.Produto
{
    public class ProdutoDTO
    {
        public string EAN { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public string Prateleira { get; set; }

        public ProdutoDTO() { }

        public ProdutoDTO(string ean, string descricao, decimal valor, string prateleira)
        {
            EAN = ean;
            Descricao = descricao;
            Valor = valor;
            Prateleira = prateleira;
        }
    }
}