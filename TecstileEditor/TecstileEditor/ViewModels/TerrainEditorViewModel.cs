using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Tecstile.Game_Board;
using TecstileEditor.Models;

namespace TecstileEditor.ViewModels;

public partial class TerrainEditorViewModel : EditorViewModel
{
    [ObservableProperty]
    private int _selectedTerrain;
    
    public ObservableCollection<TerrainDataViewModel> TerrainData {get;} = new();

    public TerrainEditorViewModel()
    {
        EditorName = Data.EditorName.Terrain;

        getTerrainData();
        void getTerrainData()
        {
            foreach (Terrain terrain in TerrainDataModel.terrainData.Values)
                TerrainData.Add(new TerrainDataViewModel(terrain));
        }
    }

    [RelayCommand]
    private void AddTerrainData()
    {
        TerrainData.Add(new TerrainDataViewModel());
    }
    [RelayCommand]
    private void SelectTerrain()
    {
        
    }
}