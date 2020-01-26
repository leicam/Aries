using System;
using System.Windows.Input;

namespace Aries.WPF.Classes
{
    internal abstract class AbstractCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter) => true;
        public void RaizeCanExecuteChanged() => CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        public abstract void Execute(object parameter);
    }
}