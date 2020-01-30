using Aries.Infraestrutura.Repositorio.Contexto;
using Aries.Infraestrutura.Repositorio.Interfaces;
using Aries.Infraestrutura.Repositorio.UnitOfWork;
using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aries.Infraestrutura.IoC
{
    internal static class UnitOfWorkInstaller
    {
        internal static Container Factory(Container container)
        {
            container.Register<AriesContext, DataContext>(Lifestyle.Singleton);
            container.Register<IUnitOfWork, UnitOfWork>(Lifestyle.Singleton);

            return container;
        }
    }
}