using Aries.WPF.Classes;
using Aries.WPF.Views.Cliente;
using Aries.WPF.Views.Home;
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

namespace Aries.WPF.Views.Home
{
    public partial class ucHome : Window
    {
        public ucHome()
        {
            InitializeComponent();
            DataContext = new HomeViewModel();
        }
    }
}