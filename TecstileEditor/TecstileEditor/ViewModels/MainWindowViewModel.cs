using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace TecstileEditor.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    [ObservableProperty]
    private string? _celsius;
    [ObservableProperty]
    private string? _fahrenheit;

    [RelayCommand]
    private void Calculate()
    {
        if (double.TryParse(Celsius, out double C))
        {
            var F = C * (9d / 5d) + 32;
            Fahrenheit = F.ToString("0.0");
        }
        else
        {
            Fahrenheit = "0";
            Celsius = "0";
        }
    }
    public string Greeting { get; } = "Welcome to Avalonia!";
}
