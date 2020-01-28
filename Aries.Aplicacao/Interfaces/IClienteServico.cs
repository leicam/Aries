using Aries.DTO.Cliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aries.Aplicacao.Interfaces
{
    public interface IClienteServico
    {
        string AddOrUpdate(ClienteDTO dto);
        string Remove(ClienteDTO dto);
        List<ClienteDTO> GetAll();
    }
}
