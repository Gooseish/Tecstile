using System;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using TecstileEditor.Factories;

namespace TecstileEditor.ViewModels;

public partial class ChildWindowViewModel: ViewModelBase
{
    [ObservableProperty]
    private EditorViewModel _currentEditor;
    private EditorFactory _editorFactory;

    public ChildWindowViewModel(EditorFactory editorFactory)
    {
        _editorFactory = editorFactory;
        GoToUnits();
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
