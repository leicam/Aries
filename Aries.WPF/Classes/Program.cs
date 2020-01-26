using Aries.Infraestrutura.IoC;
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
            => StartApplication(WpfInstaller.GetContainer());

        private static void StartApplication(Container container)
        {
            try
            {
                MainWindow
                    .Factory(WindowInstances.Factory(container))
                    .ShowDialog();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}