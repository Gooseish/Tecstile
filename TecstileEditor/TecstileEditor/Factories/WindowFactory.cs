using System;
using TecstileEditor.Data;
using TecstileEditor.Views;

namespace TecstileEditor.Factories;

public class WindowFactory
{
    private readonly Func<EditorName, ChildWindowView> windowFactory;

    public WindowFactory(Func<EditorName, ChildWindowView> factory)
    {
        windowFactory = factory;
    }

    public void LaunchNewChildWindow(EditorName name)
    {
        var window = windowFactory.Invoke(name);
        window.Show();
    }
}
