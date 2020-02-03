using Aries.DTO.Cliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aries.WPF.Views.Cliente.Commands
{
    public class AtualizarCadastroClienteCommand : AbstractCadastroCliente
    {
        public override void Execute(object parameter)
        {
            _vm = parameter as ClienteViewModel;

        }

        protected override ClienteDTO MontarDados()
        {
            throw new NotImplementedException();
        }
    }
}
