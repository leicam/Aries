using Aries.Aplicacao.Interfaces;
using Aries.Aplicacao.Servicos;
using SimpleInjector;

namespace Aries.Infraestrutura.IoC
{
    internal static class ServiceInstaller
    {
        internal static Container Factory(Container container)
        {
            container.Register<IClienteServico, ClienteServico>(Lifestyle.Singleton);
            container.Register<IProdutoServico, ProdutoServico>(Lifestyle.Singleton);

            return container;
        }
    }
}