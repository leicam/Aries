using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aries.Dominio.Entidades.Cliente
{
    public class Email
    {
        public Guid Id { get; private set; }
        public string Valor { get; private set; }
        public Cliente Cliente { get; private set; }


        public Email(Cliente cliente, string email)
        {
            Id = new Guid();
            Cliente = cliente;
            Valor = email;
            ValidarEmail();
        }

        private void ValidarEmail()
        {
            if (!Valor.Contains("@"))
                throw new ArgumentException("E-mail informado é invalido!");
        }
    }
}
