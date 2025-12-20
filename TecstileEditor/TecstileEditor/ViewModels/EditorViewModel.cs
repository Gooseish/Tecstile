using System;
using CommunityToolkit.Mvvm.ComponentModel;
using TecstileEditor.Data;

namespace TecstileEditor.ViewModels;

public partial class EditorViewModel : ViewModelBase
{
    [ObservableProperty]
    private EditorName _editorName;
}
