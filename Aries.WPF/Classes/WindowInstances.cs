using Aries.WPF.Views.Cliente;
using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aries.WPF.Classes
{
    internal class WindowInstances
    {
        public ucCadastrarCliente ucCadastrarCliente { get; private set; }

        private WindowInstances(Container container)
        {
            ucCadastrarCliente = container.GetInstance<ucCadastrarCliente>();
        }

        public static WindowInstances Factory(Container container)
            => new WindowInstances(container);
    }
}