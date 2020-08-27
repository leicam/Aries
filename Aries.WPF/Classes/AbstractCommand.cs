using System;
using System.Linq;
using System.Windows;
using System.Windows.Input;

namespace Aries.WPF.Classes
{
    public abstract class AbstractCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        private Window CurrentWindow => Application.Current.Windows.OfType<Window>().SingleOrDefault(x => x.IsActive);

        public void CloseWindow() => CurrentWindow?.Close();
        public virtual bool CanExecute(object parameter) => true;
        public void RaizeCanExecuteChanged() => CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        public abstract void Execute(object parameter);

    }
}