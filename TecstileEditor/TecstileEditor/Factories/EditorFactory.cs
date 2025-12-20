using System;
using TecstileEditor.Data;
using TecstileEditor.ViewModels;

namespace TecstileEditor.Factories;

public class EditorFactory
{
    private readonly Func<EditorName, EditorViewModel> editorFactory;
    public EditorFactory(Func<EditorName, EditorViewModel> factory)
    {
        editorFactory = factory;
    }
    public EditorViewModel GetEditorViewModel(EditorName editorName)
    {
        return editorFactory.Invoke(editorName);
    }
}
