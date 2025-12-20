using System;
using TecstileEditor.Data;
using TecstileEditor.Views;

namespace TecstileEditor.Factories;

public class WindowFactory
{
    private readonly Func<EditorName, ChildWindow> windowFactory;

    public WindowFactory(Func<EditorName, ChildWindow> factory)
    {
        windowFactory = factory;
    }

    public void LaunchNewChildWindow(EditorName name)
    {
        var window = windowFactory.Invoke(name);
        window.Show();
    }
}
