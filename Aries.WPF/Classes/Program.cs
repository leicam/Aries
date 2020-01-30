using Aries.Connector;
using Aries.WPF.Views.Cliente;
using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aries.WPF.Classes
{
    public static class Program
    {
        [STAThread]
        public static void Main()
            => StartApplication();

        private static void StartApplication()
        {
            try
            {
                GerenciadorTelas.MainWindow();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}