using Aries.Dominio.Entidades.Cliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aries.Dominio.Builders
{
    public class ClienteBuilder
    {
        private readonly Cliente _cliente = new Cliente();

        public ClienteBuilder ComNome(string nome)
        {
            _cliente.Nome = nome;
            return this;
        }

        public ClienteBuilder ComSobrenome(string sobrenome)
        {
            _cliente.Sobrenome = sobrenome;
            return this;
        }

        public ClienteBuilder ComDocumento(string documento)
        {
            _cliente.Documentos = new List<Documento>() { new Documento(_cliente, documento) };
            return this;
        }

        public ClienteBuilder ComEmail(string email)
        {
            _cliente.Emails = new List<Email>() { new Email(_cliente, email) };
            return this;
        }

        public Cliente Build() => _cliente;
    }
}