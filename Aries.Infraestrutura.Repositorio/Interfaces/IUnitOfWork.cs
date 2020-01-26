using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aries.Infraestrutura.Repositorio.Interfaces
{
    public interface IUnitOfWork
    {
        IClienteRepositorio ClienteRepositorio { get; }
    }
}