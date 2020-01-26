using System.Linq;
using System.Windows;

namespace Aries.WPF.Classes
{
    internal class BaseInteractions
    {
        private Window _currentWindow = Application.Current.Windows.OfType<Window>().SingleOrDefault(x => x.IsActive);

        public void CloseWindow() => _currentWindow.Close();
    }
}