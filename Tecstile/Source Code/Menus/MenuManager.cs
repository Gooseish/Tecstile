using System;

namespace Tecstile.Source_Code.Menus;

public class MenuManager
{
    public MenuState state;
    public MenuManager()
    {
        state = new MenuState();
    }
    private bool Exit_Calling = false;
    public bool exit_calling { get { return Exit_Calling; } }
}
