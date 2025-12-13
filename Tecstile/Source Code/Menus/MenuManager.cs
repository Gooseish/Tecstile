using System;
using System.Collections;
using System.ComponentModel.Design;
using System.Runtime.InteropServices;
using Tecstile.Source_Code.Input;
using Tecstile.Source_Code.Scene;

namespace Tecstile.Source_Code.Menus;

public class MenuManager
{
    #region Fields
    private MenuState State;
    #endregion
    #region Accessors
    public bool menuOpen {get{return State.menus.Count > 0;}}
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
            case CommandName.Confirm:
                result = CallCurrentNode();
                break;
            case CommandName.Info:
                result = TryInspect();
                break;
            case CommandName.Tab:
                result = TryTab();
                break;
            case CommandName.Up:
            case CommandName.Down:
            case CommandName.Left:
            case CommandName.Right:
                result = TryDirectionalInput(command);
                break;
            default:
                break;
        }

        Global.input.commandTried(command, result);
    }
    public void callMenuOpen()
    {
        switch (Global.scene.sceneType)
        {
            case SceneType.Title:
                State.menus.Add(new MenuTitle());
                break;
            default:
                break;
        }
    }
    #endregion
    #region Private Controls
    private void AddMenu(MenuType type)
    {
        switch (type)
        {
            case MenuType.NewGame:
            State.menus.Add(new MenuNewGame());
                break;
            default:
                break;
        }
    }
    private void CloseAllMenus()
    {
        State.menus.Clear();
    }
    // Cancel
    private CommandResult TryCancel()
    {
        CommandResult result = CommandResult.Null;
        try
        {
            CallMenuClose();
            result = CommandResult.Accepted;
        }
        finally { }
        return result;
    }
    private void CallMenuClose()
    {
        State.menus.RemoveAt(State.menus.Count - 1);
    }
    // Confirm
    private CommandResult CallCurrentNode()
    {
        if (State.activeMenu is IMenuNodeMap activeMenu) // Menu has nodes
        {
            if (activeMenu.activeNode is INodeAddMenu activeNode) // Node adds menu
                if (activeNode.openMenuCondition)
                {
                    AddMenu(activeNode.menuToOpen);
                    return CommandResult.Accepted;
                }
                else
                    return CommandResult.Rejected;
            else if (activeMenu.activeNode is INodeExitGame)
            {
                Global.scene.callExit();
                return CommandResult.Accepted;
            }
        }
        return CommandResult.Null;
    }
    // Info
    private CommandResult TryInspect()
    {
        if (State.activeMenu is IMenuNodeMap activeMenu)
            if (activeMenu.inspectable)
            {
                activeMenu.inspectActive = !activeMenu.inspectActive;
                return CommandResult.Accepted;
            }
        return CommandResult.Null;
    }
    // Tab
    private CommandResult TryTab()
    {
        return CommandResult.Null;
    }
    // Directional Input
    private CommandResult TryDirectionalInput(CommandName command)
    {
        if (State.activeMenu is IMenuNodeMap activeMenu)
            switch (activeMenu.nodeMapType)
            {
                case NodeMapType.Linear:
                    switch (command)
                    {
                        case CommandName.Up:
                        case CommandName.Left:
                            DecrementActiveNodeIndex(activeMenu);
                            return CommandResult.Accepted;
                        case CommandName.Down:
                        case CommandName.Right:
                            IncrementActiveNodeIndex(activeMenu);
                            return CommandResult.Accepted;
                    }
                    break;
                default:
                    break;
            }
        return CommandResult.Null;
    }
    private void IncrementActiveNodeIndex(IMenuNodeMap activeMenu)
    {
        activeMenu.activeNodeIndex = (activeMenu.activeNodeIndex + 1) % activeMenu.nodes.Count;
    }
    private void DecrementActiveNodeIndex(IMenuNodeMap activeMenu)
    {
        activeMenu.activeNodeIndex -= 1;
        // Loop back around
        if (activeMenu.activeNodeIndex < 0)
            activeMenu.activeNodeIndex += activeMenu.nodes.Count;
    }
    #endregion
    #region Constructor
    public MenuManager()
    {
        State = new MenuState();
    }
    #endregion
}
