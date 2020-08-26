using Aries.DTO.Cliente;
using Aries.Infraestrutura.Utilidades.Converter;
using Aries.Infraestrutura.Utilidades.Extensions;
using Aries.WPF.Classes;
using Aries.WPF.Models.Cliente;
using System.Collections.Generic;

namespace Aries.WPF.Views.Cliente.Commands
{
    public class ListarClientesCommand : AbstractCommand
    {
        public override void Execute(object parameter)
        {
            var vm = (parameter as ListarClienteViewModel);
            var clientes = vm.Connector.Cliente.GetAll();

            vm.Clientes.Clear();
            vm.Clientes.AddRange(Mapper.Map<List<ClienteDTO>, List<ClienteModel>>(clientes));
        }
    }
}