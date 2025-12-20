using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace TecstileEditor.ViewModels;

public partial class UnitsEditorViewModel : EditorViewModel
{
    public string Test {get;set;} = "Units";
    public UnitsEditorViewModel()
    {
        EditorName = Data.EditorName.Units;
    }
}