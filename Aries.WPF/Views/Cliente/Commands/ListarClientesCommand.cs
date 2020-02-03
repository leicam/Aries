using Aries.DTO.Cliente;
using Aries.Infraestrutura.Utilidades.Extensions;
using Aries.WPF.Classes;
using Aries.WPF.Models.Cliente;
using Nelibur.ObjectMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aries.WPF.Views.Cliente.Commands
{
    public class ListarClientesCommand : AbstractCommand
    {
        public override void Execute(object parameter)
        {
            var vm = (parameter as ListarClienteViewModel);
            var clientes = vm.Connector.Cliente.GetAll();

            TinyMapper.Bind<List<ClienteDTO>, List<ClienteModel>>();

            vm.Clientes.Clear();
            vm.Clientes.AddRange(TinyMapper.Map<List<ClienteModel>>(clientes));
        }
    }
}
