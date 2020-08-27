using System;

namespace Aries.Dominio.Entidades.Produto
{
    public class Produto
    {
        public Guid Id { get; private set; }
        public string EAN { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public string Prateleira { get; set; }

        public Produto() 
        {
            Id = Guid.NewGuid();
        }
    }
}