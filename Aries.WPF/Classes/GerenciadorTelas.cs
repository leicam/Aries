using Aries.WPF.Views.Cliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aries.WPF.Classes
{
    internal static class GerenciadorTelas
    {
        private static MainWindow _mainWindow = new MainWindow();
        private static ucCadastrarCliente _cadastrarCliente = new ucCadastrarCliente();

        public static void MainWindow() => _mainWindow.ShowDialog();
        public static void CadastrarCliente() => _cadastrarCliente.ShowDialog();
    }
}