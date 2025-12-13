using System;
using System.Collections;
using Tecstile.Source_Code.Input;

namespace Tecstile.Source_Code.Menus;

public class MenuManager
{
    #region Fields
    private MenuState State;
    #endregion
    #region Accessors
    public bool exitCalling { get { return State.exitCalling; } }
    public bool menuOpen {get{return State.menuOpen;}}
    #endregion
    #region Public Controls 
    public void tryCommand(CommandName command)
    {
        CommandResult result = CommandResult.Null;
        switch(command)
        {
            default:
                break;
        }

        Global.input.commandTried(command, result);
    }
    public void callMenuOpen()
    {
        State.menuOpen = true;
    }
    public void callMenuClose()
    {
        State.menuOpen = false;
    }
    #endregion
    #region Private Controls
    
    public void callExit()
    {
        State.exitCalling = true;
    }
    #endregion
    #region Constructor
    public MenuManager()
    {
        State = new MenuState();
    }
    #endregion
}
