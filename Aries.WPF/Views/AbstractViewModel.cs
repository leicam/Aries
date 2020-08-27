using Aries.Connector;
using Aries.WPF.Classes;

namespace Aries.WPF.Views
{
    public class AbstractViewModel : AbstractNotifyPropertyChanged
    {
        internal Connectors Connector => new Connectors();

        public void ExecutarCommand(AbstractCommand command)
        {
            if (command.CanExecute(this))
                command.Execute(this);
        }
    }
}