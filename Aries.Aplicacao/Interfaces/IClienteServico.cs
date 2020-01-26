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
        string Adicionar(ClienteDTO dto);
        string Remover(ClienteDTO dto);
        List<ClienteDTO> Listar();
    }
}
