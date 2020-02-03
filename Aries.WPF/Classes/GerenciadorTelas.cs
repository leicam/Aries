using Aries.WPF.Models.Cliente;
using Aries.WPF.Views.Cliente;
using Aries.WPF.Views.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aries.WPF.Classes
{
    internal static class GerenciadorTelas
    {
        #region Home
        public static void MainWindow() => new ucHome().Show();
        #endregion Home

        #region Cliente
        public static void ListarCliente() => new ucListarCliente().ShowDialog();
        public static void CadastrarCliente() => new ucCadastrarCliente().ShowDialog();
        public static void EditarCliente(ClienteModel cliente) => new ucCadastrarCliente(cliente);
        #endregion Cliente
    }
}