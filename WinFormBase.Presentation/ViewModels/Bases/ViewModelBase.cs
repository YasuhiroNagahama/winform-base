using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WinFormBase.Presentation.ViewModels.Bases;

public abstract class ViewModelBase : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler? PropertyChanged;

    protected bool SetProperty<T>(ref T field,
        T value, [CallerMemberName] string? propertyName = null)
    {
        if (Equals(field, value))
        {
            return false;
        }

        field = value;

        if (PropertyChanged is not null && propertyName is not null)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        return true;
    }
}