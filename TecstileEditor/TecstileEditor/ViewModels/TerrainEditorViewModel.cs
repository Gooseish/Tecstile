using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Tecstile.Game_Board;
using TecstileEditor.Models;

namespace TecstileEditor.ViewModels;

public partial class TerrainEditorViewModel : EditorViewModel
{
    [ObservableProperty]
    private int _selectedTerrain;
    private Terrain _selectedTerrainData{get {return DataContentManager.GetTerrain(_selectedTerrain);}}
    public TerrainEditorViewModel()
    {
        EditorName = Data.EditorName.Terrain;
    }
}