using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace TecstileEditor.ViewModels;

public partial class UnitsWindowViewModel : EditorViewModel
{
    public string Test {get;set;} = "Units";
    public UnitsWindowViewModel()
    {
        EditorName = Data.EditorName.Units;
    }
}