using Aries.WPF.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aries.WPF.Views.Home.Commands
{
    public class ListarClienteCommand : AbstractCommand
    {
        public override void Execute(object parameter)
            => GerenciadorTelas.ListarCliente();
    }
}
