using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aries.Dominio.Entidades.Produto
{
    public class Produto
    {
        public Guid Id { get; private set; }
        public int EAN { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }

        public Produto() 
        {
            Id = Guid.NewGuid();
        }
    }
}