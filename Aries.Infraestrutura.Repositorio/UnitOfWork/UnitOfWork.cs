using Aries.Dominio.Entidades.Cliente;
using Aries.Infraestrutura.Repositorio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aries.Infraestrutura.Repositorio.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        #region Propriedades
        public IClienteRepositorio ClienteRepositorio { get; }
        #endregion Propriedades

        #region Construtores
        public UnitOfWork(IClienteRepositorio clienteRepositorio)
        {
            ClienteRepositorio = clienteRepositorio;
        }
        #endregion
    }
}