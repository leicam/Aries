using System;

namespace Aries.Dominio.Entidades.Produto
{
    public class Produto
    {
        public Guid Id { get; private set; }
        public int EAN { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public string Parteleira { get; set; }

        public Produto() 
        {
            Id = Guid.NewGuid();
        }
    }
}