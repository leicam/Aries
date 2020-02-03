using Aries.DTO.Cliente;
using Aries.WPF.Classes;
using Aries.WPF.Models.Cliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Aries.WPF.Views.Cliente.Commands
{
    public abstract class AbstractCadastroCliente : AbstractCommand
    {
        protected ClienteViewModel _vm;
        
        protected void Commit()
        {
            try
            {
                _vm.Connector.Cliente.AddOrUpdate(MontarDados());
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            MessageBox.Show("Cliente cadastrado com sucesso!");
            _vm.Cliente = new ClienteModel();
        }

        protected abstract ClienteDTO MontarDados();
    }
}
