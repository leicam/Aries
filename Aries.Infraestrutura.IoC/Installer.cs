using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aries.Infraestrutura.IoC
{
    public static class Installer
    {
        public static Container Factory()
        {
            var container = new Container();

            container = UnitOfWorkInstaller.Factory(container);
            container = RepositorioInstaller.Factory(container);
            container = ServiceInstaller.Factory(container);

            container.Verify();

            return container;
        }
    }
}
