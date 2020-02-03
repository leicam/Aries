using Aries.Infraestrutura.Repositorio.Interfaces;
using Aries.Infraestrutura.Repositorio.Repositorios;
using SimpleInjector;

namespace Aries.Infraestrutura.IoC
{
    internal static class RepositorioInstaller
    {
        internal static Container Factory(Container container)
        {
            container.Register<IClienteRepositorio, ClienteRepositorio>(Lifestyle.Singleton);
            container.Register<IProdutoRepositorio, ProdutoRepositorio>(Lifestyle.Singleton);

            return container;
        }
    }
}