using System.Security;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using TecstileEditor.Factories;

namespace TecstileEditor.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    [ObservableProperty]
    private EditorViewModel _currentWindow;
    private EditorFactory _editorFactory;
    
    public MainWindowViewModel(EditorFactory editorFactory, TerrainWindowViewModel terrainWindow)
    {
        _editorFactory = editorFactory;
        GoToUnits();
    }
    [RelayCommand]
    private void GoToUnits()
    {
        CurrentWindow = _editorFactory.GetEditorViewModel(Data.EditorName.Units);
    }
    [RelayCommand]
    private void GoToTerrain()
    {
        CurrentWindow = _editorFactory.GetEditorViewModel(Data.EditorName.Terrain);
    }
}
