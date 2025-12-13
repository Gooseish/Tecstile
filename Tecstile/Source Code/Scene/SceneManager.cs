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
    }
    #region Handle Input
    private void HandleInput()
    {
        if (inputSleeping)
            return;

        void HandleInputBySceneType()
        {
            if (State.activeScene is SceneTitleState activeScene)
                HandleInputTitle(activeScene);
            else
                throw new Exception("Scene type not recognized.");
        }
        HandleInputBySceneType();

        void HandleInputByComponents()
        {
            if (State.activeScene is IMenuControlScheme activeScene)
                HandleInputMenuControlScheme(activeScene);
        }
        HandleInputByComponents();
    }
    #region Handle Input by Scene Type
    private void HandleInputTitle(SceneTitleState activeScene)
    {
        // If menuing, no nothing
        if (activeScene.menuControlActive)
            return;

        Dictionary<CommandName, Action> commandPipeline = new()
        {
            {CommandName.Start, Global.menu.callMenuOpen},
            {CommandName.Escape, Global.menu.callExit},
        };
        PipeCommands(commandPipeline);
    }
    #endregion
    #region Handle Input by Components
    private void HandleInputMenuControlScheme(IMenuControlScheme activeScene)
    {
        activeScene.menuControlActive = Global.menu.menuOpen;

        if (!activeScene.menuControlActive)
            return;

        PipeAllCommands(Global.menu.tryCommand);

        // Todo
    }
    #endregion
    #endregion
    #endregion
}
