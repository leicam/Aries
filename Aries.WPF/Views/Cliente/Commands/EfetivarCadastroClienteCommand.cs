using Aries.DTO.Cliente;

namespace Aries.WPF.Views.Cliente.Commands
{
    public class EfetivarCadastroClienteCommand : AbstractCadastroCliente
    {
        public override void Execute(object parameter)
        {
            _vm = (parameter as ClienteViewModel);
            Commit();
        }

        protected override ClienteDTO MontarDados()
            => new ClienteDTO(_vm.Cliente.Nome,
                              _vm.Cliente.Sobrenome,
                              _vm.Cliente.Documento,
                              _vm.Cliente.Email);
    }
}