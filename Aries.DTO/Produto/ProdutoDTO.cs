using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aries.DTO.Produto
{
    public class ProdutoDTO
    {
        public uint EAN { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }

        public ProdutoDTO(uint ean, string descricao, decimal valor)
        {
            EAN = ean;
            Descricao = descricao;
            Valor = valor;
        }
    }
}