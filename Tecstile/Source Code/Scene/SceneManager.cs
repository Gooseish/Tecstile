using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Microsoft.Xna.Framework;
using Tecstile.Input;

namespace Tecstile.Scene;

public partial class SceneManager
{
    private SceneState State;
    public SceneManager()
    {
        State = new SceneState();
    }
    #region Accessors
    public SceneBase activeScene {get{return State.activeScene;}}
    public SceneType sceneType {get{return State.activeScene.sceneType;}}
    public bool inputSleeping {get{return State.inputSleepTimer > 0;}}
    public bool exitCalling {get{return State.exitCalling;}}
    #endregion
    #region Public Controls
    public void callExit()
    {
        State.exitCalling = true;
    }
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
        void HandleInput()
        {
            if (inputSleeping)
                return;
            
            BySceneType();
            void BySceneType()
            {
                if (HandleInput_Title())
                    return;
                throw new Exception("Scene type not recognize by scene manager.");
            }
            ByComponents();
            void ByComponents()
            {
                HandleInput_MenuControlScheme();
            }
        }
        HandleInput();
        void UpdateState()
        {
            Universal();
            void Universal()
            {
                if (State.inputSleepTimer > 0)
                {
                    State.inputSleepTimer -= 1;
                }
            }
            BySceneType();
            void BySceneType()
            {
                if (UpdateState_Title())
                    return;
                throw new Exception("Scene type not recognized.");
            }
            ByComponents();
            void ByComponents()
            {
                UpdateState_MenuControlScheme();
            }
        }
        UpdateState();
    }
    #endregion
}
