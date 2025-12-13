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
            case CommandName.Cancel:
                result = TryCancel();
                break;
            default:
                break;
        }

        Global.input.commandTried(command, result);
    }
    public void callMenuOpen()
    {
        State.menuOpen = true;
    }
    public void callExit()
    {
        State.exitCalling = true;
    }
    #endregion
    #region Private Controls
    private CommandResult TryCancel()
    {
        CommandResult result = CommandResult.Null;
        CallMenuClose();
        result = CommandResult.Accepted;
        return result;
    }
    private void CallMenuClose()
    {
        State.menuOpen = false;
    }
    #endregion
    #region Constructor
    public MenuManager()
    {
        State = new MenuState();
    }
    #endregion
}
