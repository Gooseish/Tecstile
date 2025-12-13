using System;

namespace Tecstile.Source_Code.Menus;

public class MenuManager
{
    private MenuState State;
    #region Accessors
    public bool menuOpen {get{return State.menuOpen;}}
    #endregion
    #region Public Controls
    public void callMenuOpen()
    {
        State.menuOpen = true;
    }
    public void callMenuClose()
    {
        State.menuOpen = false;
    }
    public void callExit()
    {
        Exit_Calling = true;
    }
    #endregion
    public MenuManager()
    {
        State = new MenuState();
    }
    private bool Exit_Calling = false;
    public bool exit_calling { get { return Exit_Calling; } }
}
