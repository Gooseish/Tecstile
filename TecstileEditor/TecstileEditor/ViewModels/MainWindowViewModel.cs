using System.Security;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace TecstileEditor.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    [ObservableProperty]
    private ViewModelBase _currentWindow;
    
    public MainWindowViewModel()
    {
        _currentWindow = _unitsWindow;
    }

    private readonly TerrainWindowViewModel _terrainWindow = new();
    private readonly UnitsWindowViewModel _unitsWindow = new();
}
