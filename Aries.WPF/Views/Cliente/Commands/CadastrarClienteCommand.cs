using Aries.Aplicacao.Interfaces;
using Aries.Aplicacao.Servicos;
using Aries.DTO.Cliente;
using Aries.WPF.Classes;
using Aries.WPF.Models.Cliente;
using System;
using System.Windows;

namespace Aries.WPF.Views.Cliente.Commands
{
    internal class CadastrarClienteCommand : AbstractCommand, ICadastrarClienteCommand
    {
        private readonly IClienteServico _clienteServico;

        public CadastrarClienteCommand(IClienteServico clienteServico)
        {
            _clienteServico = clienteServico;
        }

        public override void Execute(object parameter)
        {
            var vm = (parameter as ClienteViewModel);

            try
            {
                _clienteServico.AddOrUpdate(new ClienteDTO(
                    vm.Cliente.Nome, vm.Cliente.Sobrenome,
                    vm.Cliente.Documento, vm.Cliente.Email));
            }
            catch(ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            MessageBox.Show("Cliente cadastrado com sucesso!");
            vm.Cliente = new ClienteModel();
        }
    }
}