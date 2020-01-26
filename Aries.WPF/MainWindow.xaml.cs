using Aries.WPF.Classes;
using Aries.WPF.Views.Cliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Aries.WPF
{
    public partial class MainWindow : Window
    {
        private WindowInstances WindowInstances { get; set; }

        private MainWindow(WindowInstances windowInstances)
        {
            WindowInstances = windowInstances;
            InitializeComponent();
        }

        internal static MainWindow Factory(WindowInstances windowInstances)
            => new MainWindow(windowInstances);

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            WindowInstances.ucCadastrarCliente.ShowDialog();
        }
    }
}