using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aries.Dominio.Entidades.Cliente
{
    public class Documento
    {
        public Guid Id { get; private set; }
        public string Valor { get; private set; }
        public Cliente Cliente { get; private set; }
        public Guid IdCliente { get; private set; }
        public Documento(Cliente cliente, string documento)
        {
            Id = new Guid();
            Cliente = cliente;
            IdCliente = cliente.Id;
            Valor = documento;
            ValidarDocumento();
        }

        private void ValidarDocumento()
        {
            if(!Valor.Length.Equals(11) && !Valor.Length.Equals(14))
                throw new ArgumentException("Documento informado é invalido!");
        }
    }
}