using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using TecstileEditor.Factories;

namespace TecstileEditor.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    [ObservableProperty]
    private EditorViewModel _currentEditor;
    private EditorFactory _editorFactory;
    private WindowFactory _windowFactory;
    
    public MainWindowViewModel(EditorFactory editorFactory, WindowFactory windowFactory)
    {
        _editorFactory = editorFactory;
        _windowFactory = windowFactory;
        GoToUnits();
    }
    [RelayCommand]
    private void EjectEditor()
    {
        _windowFactory.LaunchNewChildWindow(_currentEditor.EditorName);
    }
    [RelayCommand]
    private void GoToUnits()
    {
        CurrentEditor = _editorFactory.GetEditorViewModel(Data.EditorName.Units);
    }
    [RelayCommand]
    private void GoToTerrain()
    {
        CurrentEditor = _editorFactory.GetEditorViewModel(Data.EditorName.Terrain);
    }
}
