using Aries.Aplicacao.Interfaces;
using Aries.DTO.Cliente;
using System.Collections.Generic;

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

        public List<ClienteDTO> GetAll()
            => _clienteServico.GetAll();
    }
}