using Aries.Infraestrutura.Repositorio.Interfaces;
using Aries.Infraestrutura.Repositorio.Repositorios;
using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aries.Infraestrutura.IoC
{
    internal static class RepositorioInstaller
    {
        internal static Container Factory(Container container)
        {
            container.Register<IClienteRepositorio, ClienteRepositorio>(Lifestyle.Singleton);

            return container;
        }
    }
}