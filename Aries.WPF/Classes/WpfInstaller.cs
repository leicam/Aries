using Aries.Infraestrutura.IoC;
using Aries.WPF.Views.Cliente;
using Aries.WPF.Views.Cliente.Commands;
using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aries.WPF.Classes
{
    public static class WpfInstaller
    {
        public static Container GetContainer()
            => Factory();

        private static Container Factory()
        {
            var container = ServiceInstaller.Factory();

            #region Commands
            container.Register<ICadastrarClienteCommand, CadastrarClienteCommand>(Lifestyle.Singleton);
            #endregion

            #region View Models
            container.Register<ClienteViewModel>();
            #endregion View Models

            #region Windows
            container.Register<ucCadastrarCliente>();
            #endregion Windows

            container.Verify();

            return container;
        }
    }
}