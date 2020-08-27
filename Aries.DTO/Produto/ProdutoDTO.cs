namespace Aries.DTO.Produto
{
    public class ProdutoDTO
    {
        public int EAN { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public string Parteleira { get; set; }

        public ProdutoDTO() { }

        public ProdutoDTO(int ean, string descricao, decimal valor, string parteleira)
        {
            EAN = ean;
            Descricao = descricao;
            Valor = valor;
            Parteleira = parteleira;
        }
    }
}