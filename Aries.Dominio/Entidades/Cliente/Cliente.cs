using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aries.Dominio.Entidades.Cliente
{
    public class Cliente
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public List<Documento >Documentos { get; set; }
        public List<Email> Emails { get; set; }

        public Cliente()
        {
            Id = Guid.NewGuid();
        }
    }
}
