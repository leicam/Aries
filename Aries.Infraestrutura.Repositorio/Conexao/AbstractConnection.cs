using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aries.Infraestrutura.Repositorio.Conexao
{
    internal abstract class AbstractConnection
    {
        public abstract object GetConnection();
    }
}
