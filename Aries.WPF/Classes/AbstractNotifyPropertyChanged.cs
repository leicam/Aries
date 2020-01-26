﻿using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Aries.WPF.Classes
{
    public abstract class AbstractNotifyPropertyChanged : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void SetField<T>(ref T field, T value, [CallerMemberName] string nameProperty = null)
        {
            if(!EqualityComparer<T>.Default.Equals(field, value))
            {
                field = value;
                RaizePropertyChange(nameProperty);
            }
        }

        private void RaizePropertyChange(string nameProperty) 
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameProperty));
    }
}