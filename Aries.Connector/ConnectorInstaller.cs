using Aries.Infraestrutura.IoC;
using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aries.Connector
{
    public static class ConnectorInstaller
    {
        public static Container ContainerResolver()
            => Installer.Factory();
    }
}