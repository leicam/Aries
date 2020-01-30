using Aries.DTO.Cliente;
using System.Collections.Generic;

namespace Aries.Aplicacao.Interfaces
{
    public interface IClienteServico
    {
        void AddOrUpdate(ClienteDTO dto);
        void Remove(ClienteDTO dto);
        List<ClienteDTO> GetAll();
    }
}
