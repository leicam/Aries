using Aries.Aplicacao.Interfaces;
using Aries.DTO.Cliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aries.Connector.Cliente
{
    public class ClienteConnector
    {
        private IClienteServico _clienteServico;

        public ClienteConnector(IClienteServico clienteServico)
        {
            _clienteServico = clienteServico;
        }

        public void AddOrUpdate(ClienteDTO cliente)
            => _clienteServico.AddOrUpdate(cliente);
    }
}