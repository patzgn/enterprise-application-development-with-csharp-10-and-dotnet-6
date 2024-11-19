using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CallerArguments;

public class Gift : INotifyPropertyChanged
{
    private string? _description;

    public string? Description
    {
        get => _description;
        set
        {
            _description = value;
            OnPropertyChanged();
        }
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    private void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
