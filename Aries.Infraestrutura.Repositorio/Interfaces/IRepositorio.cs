using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aries.Infraestrutura.Repositorio.Interfaces
{
    public interface IRepositorio<T> where T : class
    {
        IEnumerable<T> GetAll();
        void AddOrUpdate(T entidade);
        void Remove(T entidade);
    }
}