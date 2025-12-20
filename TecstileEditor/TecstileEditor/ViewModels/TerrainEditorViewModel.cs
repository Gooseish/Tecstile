using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace TecstileEditor.ViewModels;

public partial class TerrainEditorViewModel : EditorViewModel
{
    public string Test {get;set;} = "Terrain";
    public TerrainEditorViewModel()
    {
        EditorName = Data.EditorName.Terrain;
    }
}