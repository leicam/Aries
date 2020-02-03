using Aries.Aplicacao.Interfaces;
using Aries.Connector.Cliente;
using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aries.Connector
{
    public class Connectors
    {
        private static Container _container;

        public Connectors()
        {
            _container = ConnectorInstaller.ContainerResolver();
        }

        public ClienteConnector Cliente => new ClienteConnector(_container.GetInstance<IClienteServico>());
    }
}
