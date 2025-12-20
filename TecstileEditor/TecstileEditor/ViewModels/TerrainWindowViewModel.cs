using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace TecstileEditor.ViewModels;

public partial class TerrainWindowViewModel : EditorViewModel
{
    public string Test {get;set;} = "Terrain";
    public TerrainWindowViewModel()
    {
        EditorName = Data.EditorName.Terrain;
    }
}