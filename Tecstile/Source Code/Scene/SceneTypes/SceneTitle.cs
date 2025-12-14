using System;
using System.Collections.Generic;
using Tecstile.Input;

namespace Tecstile.Scene;

public class SceneTitle: 
SceneBase,
IMenuControlScheme
{
    public SceneTitle()
    {
        sceneType = SceneType.Title;
    }
    #region Interface Compliance
    public bool menuControlActive {get;set;}
    public bool inspectActive{get;set;}
    #endregion
}

public partial class SceneManager
{
    private bool HandleInput_Title()
    {
        if (!(State.activeScene is SceneTitle activeScene))
            return false;
        // If menuing, no nothing
        if (activeScene.menuControlActive)
            return true;

        Dictionary<CommandName, Action> commandPipeline = new()
        {
            {CommandName.Start, Global.menu.callMenuOpen},
            {CommandName.Escape, callExit},
        };
        PipeCommands(commandPipeline);
        return true;
    }
    private bool UpdateState_Title()
    {
        if (State.activeScene is SceneTitle activeScene)
        {
            // Update logic goes here
            return true;
        }
        return false;
    }

}