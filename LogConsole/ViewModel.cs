using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;

namespace LogConsole
{
    public class ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        protected void SetProperty<T>(ref T var, T value, [CallerMemberName] string propertyName = "")
        {
            var = value;
            OnPropertyChanged(propertyName);
        }

        protected async Task InvokeOnMainThread(Action callback, DispatcherPriority prio = DispatcherPriority.Normal)
            => await Application.Current.Dispatcher.InvokeAsync(callback, prio);

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
