using Aries.Aplicacao.Interfaces;
using Aries.Connector.Cliente;
using Aries.Connector.Produto;
using SimpleInjector;

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
        public ProdutoConnector Produto => new ProdutoConnector(_container.GetInstance<IProdutoServico>());
    }
}
