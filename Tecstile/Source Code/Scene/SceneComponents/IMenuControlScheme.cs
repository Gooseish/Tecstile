using System;

namespace Tecstile.Scene;

public interface IMenuControlScheme
{
    public bool menuControlActive { get; set;} // Is the control scheme accepting input?
    public bool inspectActive{get;set;}
}

public partial class SceneManager
{
    private void HandleInput_MenuControlScheme()
    {
        if (!(State.activeScene is IMenuControlScheme activeScene))
            return;
        if (!activeScene.menuControlActive)
            return;

        PipeAllCommands(Global.menu.tryCommand);
    }
    private void UpdateState_MenuControlScheme()
    {
        if (State.activeScene is IMenuControlScheme activeScene)
        {
            activeScene.menuControlActive = Global.menu.menuOpen;
        }
    }
}
