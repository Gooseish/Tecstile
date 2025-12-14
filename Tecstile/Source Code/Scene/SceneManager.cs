using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Microsoft.Xna.Framework;
using Tecstile.Input;

namespace Tecstile.Scene;

public class SceneManager
{
    private SceneState State;
    public SceneManager()
    {
        State = new SceneState();
    }
    #region Accessors
    public SceneBase activeScene {get{return State.activeScene;}}
    public bool inputSleeping {get{return State.inputSleepTimer > 0;}}
    public bool exitCalling {get{return State.exitCalling;}}
    public SceneType sceneType {get{return State.activeScene.sceneType;}}
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
    public void callExit()
    {
        State.exitCalling = true;
    }
    #endregion
    #region Private Controls
    private void PipeCommands(Dictionary<CommandName, Action> commandPipeline)
    {
        foreach (CommandName command in commandPipeline.Keys)
        {
            // Don't use consumed commands
            if (Global.input.commandConsumed(command))
                continue;
            // Check if the command is calling
            if (!Global.input.keyPressed(command))
                continue;

            commandPipeline[command]();
        }
    }
    private void PipeAllCommands(Action<CommandName> action)
    {
        foreach (CommandName command in Enum.GetValues(typeof(CommandName)))
        {
            // Don't use consumed commands
            if (Global.input.commandConsumed(command))
                continue;
            // Check if the command is calling
            if (!Global.input.keyPressed(command))
                continue;

            action(command);
        }
    }
    #endregion
    #region Update Loop
    public void update()
    {
        HandleInput();
        UpdateState();
    }
    #region Update State
    private void UpdateState()
    {
        void Universal()
        {
            if (State.inputSleepTimer > 0)
            {
                State.inputSleepTimer -= 1;
            }
        }
        Universal();

        void BySceneType()
        {
            if (UpdateState_Title())
                return;
            throw new Exception("Scene type not recognized.");
        }
        BySceneType();

        void ByComponents()
        {
            UpdateState_MenuControlScheme();
        }
        ByComponents();
    }
    #region Update State by Scene Type
    private bool UpdateState_Title()
    {
        if (State.activeScene is SceneTitle activeScene)
        {
            // Update logic goes here
            return true;
        }
        return false;
    }
    #endregion
    #region Update State by Scene Type
    private void UpdateState_MenuControlScheme()
    {
        if (State.activeScene is IMenuControlScheme activeScene)
        {
            activeScene.menuControlActive = Global.menu.menuOpen;
        }
    }
    #endregion
    #endregion
    #region Handle Input
    private void HandleInput()
    {
        if (inputSleeping)
            return;

        void BySceneType()
        {
            if (HandleInput_Title())
                return;
            throw new Exception("Scene type not recognized.");
        }
        BySceneType();

        void ByComponents()
        {
            HandleInput_MenuControlScheme();
        }
        ByComponents();
    }
    #region Handle Input by Scene Type
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
    #endregion
    #region Handle Input by Components
    private void HandleInput_MenuControlScheme()
    {
        if (!(State.activeScene is IMenuControlScheme activeScene))
            return;
        if (!activeScene.menuControlActive)
            return;

        PipeAllCommands(Global.menu.tryCommand);
    }
    #endregion
    #endregion
    #endregion
}
