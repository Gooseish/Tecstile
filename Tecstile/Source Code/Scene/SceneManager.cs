using System;
using System.ComponentModel;
using Microsoft.Xna.Framework;

namespace Tecstile.Source_Code.Scene;

public class SceneManager
{
    private SceneState State;
    public SceneManager()
    {
        State = new SceneState();
    }
    #region Accessors
    public bool inputSleeping{get{return State.inputSleepTimer > 0;}}
    #endregion
    #region Private Controls
    private void InputSleep(int time)
    {
        State.inputSleepTimer = time;
    }
    #endregion
    #region Public Controlse
    #endregion
    #region Update Loop
    public void update()
    {
        void updateBySceneType()
        {
            if (State.activeScene is SceneTitleState)
                UpdateTitle((SceneTitleState)State.activeScene);
        }
        updateBySceneType();

        void updateByComponents()
        {
            if (State.activeScene is IMenuControlScheme)
                UpdateMenuControlScheme((IMenuControlScheme)State.activeScene);
        }
        updateByComponents();
    }
    #region Update by Scene Type
    private void UpdateTitle(SceneTitleState activeScene)
    {
        if (activeScene.menuControlActive)
            return;

        if (Global.input.command(Input.CommandName.start).KeyPressed)
            activeScene.menuControlActive = true;
    }
    #endregion
    #region Update by Components
    private void UpdateMenuControlScheme(IMenuControlScheme activeScene)
    {
        if (inputSleeping || !activeScene.menuControlActive)
            return;
        // Todo
    }
    #endregion
    #endregion
}
