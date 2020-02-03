using Aries.WPF.Views.Home.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aries.WPF.Views.Home
{
    public class HomeViewModel : AbstractViewModel
    {
        public ListarClienteCommand ListarCliente { get; private set; } = new ListarClienteCommand();
    }
}
