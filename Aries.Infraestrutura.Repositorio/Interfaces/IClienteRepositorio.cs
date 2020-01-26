using Aries.Dominio.Entidades.Cliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aries.Infraestrutura.Repositorio.Interfaces
{
    public interface IClienteRepositorio
    {
        void Adicionar(Cliente cliente);
        void Remover(Cliente cliente);
        List<Cliente> Listar();
    }
}
