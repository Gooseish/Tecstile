using System;

namespace Tecstile.Source_Code.Menus;

public class MenuManager
{
    private MenuState State;
    private bool Exit_Calling = false;
    public bool exit_calling { get { return Exit_Calling; } }
}
