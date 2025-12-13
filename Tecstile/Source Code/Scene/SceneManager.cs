using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Microsoft.Xna.Framework;
using Tecstile.Source_Code.Input;

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
    private void FadeToBlack(int time)
    {
        State.fadeTime = time;
        State.fadeTimer = time;
    }
    #endregion
    #region Public Controls
    #endregion
    #region Private Controls
    public void PipeCommands(Dictionary<CommandName, Action> pipeline)
    {
        foreach (Input.CommandName command in Enum.GetValues(typeof(Input.CommandName)))
        {
            // Don't use consumed commands
            if (Global.input.commandConsumed(command))
                continue;
            // Check if the command is calling
            if (!Global.input.keyPressed(command))
                continue;

            if (pipeline.ContainsKey(command))
                pipeline[command]();
        }
    }
    #endregion
    #region Update Loop
    public void update()
    {
        HandleInput();
    }
    #region Handle Input
    private void HandleInput()
    {
        void HandleInputBySceneType()
        {
            switch (State.activeScene.sceneType)
            {
                case SceneType.Title:
                    HandleInputTitle((SceneTitleState)State.activeScene);
                    break;
                default:
                    throw new Exception("Scene type not recognized.");
            }   
        }
        HandleInputBySceneType();

        void HandleInputByComponents()
        {
            if (State.activeScene is IMenuControlScheme)
                HandleInputMenuControlScheme((IMenuControlScheme)State.activeScene);
        }
        HandleInputByComponents();
    }
    #region Handle Input by Scene Type
    private void HandleInputTitle(SceneTitleState activeScene)
    {
        // If menuing, no nothing
        if (activeScene.menuControlActive)
            return;

        // Is there a way to abstract this code block into a method that depends only on a dictionary of lambda expressions?
        // Maybe call it "pipe inputs?"
        // Iterate over all commands
        foreach (Input.CommandName command in Enum.GetValues(typeof(Input.CommandName)))
        {
            // Don't use consumed commands
            if (Global.input.commandConsumed(command))
                continue;
            // Check if the command is calling
            if (!Global.input.keyPressed(command))
                continue;

            switch(command)
            {
                case Input.CommandName.Start:
                    Global.menu.callMenuOpen();
                    break;
                case Input.CommandName.Escape:
                    Global.menu.callExit();
                    break;
                default:
                    break;
            }
        }
    }
    #endregion
    #region Handle Input by Components
    private void HandleInputMenuControlScheme(IMenuControlScheme activeScene)
    {
        activeScene.menuControlActive = Global.menu.menuOpen;
        if (inputSleeping || !activeScene.menuControlActive)
            return;
        if (Global.input.keyPressed(Input.CommandName.Cancel))
            Global.menu.callMenuClose();
        // Todo
    }
    #endregion
    #endregion
    #endregion
}
