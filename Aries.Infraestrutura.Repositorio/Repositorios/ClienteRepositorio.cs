using Aries.Dominio.Entidades.Cliente;
using Aries.Infraestrutura.Repositorio.Contexto;
using Aries.Infraestrutura.Repositorio.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aries.Infraestrutura.Repositorio.Repositorios
{
    public class ClienteRepositorio : AbstractRepositorio<Cliente>, IClienteRepositorio
    {
        public ClienteRepositorio(AriesContext context) : base(context) { }

        public IEnumerable<Cliente> CarregarTodos()
            => Set
                .Include(x => x.Documentos.Select(y => y.Cliente))
                .Include(x => x.Emails.Select(y => y.Cliente))
                .AsEnumerable();

        public void AdicionarOuAlterar(Cliente cliente)
        {
            AddOrUpdate(cliente);
            SaveChanges();
        }

        public void Remover(Cliente cliente)
        {
            Remove(cliente);
            SaveChanges();
        }
    }
}