using Aries.Connector;
using Aries.WPF.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aries.WPF.Views
{
    public class AbstractViewModel : AbstractNotifyPropertyChanged
    {
        internal Connectors Connector => new Connectors();
    }
}