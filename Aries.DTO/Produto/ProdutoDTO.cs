namespace Aries.DTO.Produto
{
    public class ProdutoDTO
    {
        public int EAN { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }

        public ProdutoDTO(int ean, string descricao, decimal valor)
        {
            EAN = ean;
            Descricao = descricao;
            Valor = valor;
        }
    }
}