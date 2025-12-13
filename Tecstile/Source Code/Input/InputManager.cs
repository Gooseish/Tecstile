using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Tecstile.Source_Code.Input;

namespace Tecstile.Input;

public class InputManager
{
    private InputState State;
    
    #region Accessors
    public bool keyPressed(CommandName commandName)
    {
        return State.commands[commandName].keyPressed;
    }
    /// <summary>
    /// Check if a command has been consumed yet or not. After commands
    /// are used, their result should be assigned a value of either 
    /// confirmed or rejected.
    /// </summary>
    /// <param name="commandName"></param>
    /// <returns></returns>
    public bool commandConsumed(CommandName commandName)
    {
        return (State.commands[commandName].Result != CommandResult.Null);
    }
    #endregion
    #region Public Controls
    /// <summary>
    /// Let the input manager know whether a command has been consumed or not.
    /// </summary>
    /// <param name="command"></param>
    /// <param name="result"></param>
    public void commandTried(CommandName command, CommandResult result)
    {
        State.commands[command].Result = result;
    }
    #endregion
    //private KeyboardState PreviousKeyboardState;
    private KeyboardState CurrentKeyboardState;
    public InputManager()
    {
        State = new InputState();

        //PreviousKeyboardState = new KeyboardState();
        CurrentKeyboardState = Keyboard.GetState();
    }
    public void update()
    {
        //PreviousKeyboardState = CurrentKeyboardState;
        void updateCommands()
        {
            CurrentKeyboardState = Keyboard.GetState();
            foreach(var (commandName, key) in Global.settings.keyboardMap)
            {
                Command command = State.commands[commandName];
                command.Result = CommandResult.Null;

                command.keyDown = CurrentKeyboardState.IsKeyDown(key);
                command.keyPressed = command.keyDown && command.timeSpanHeld == 0;
                command.keyReleased = !command.keyDown && command.timeSpanHeld > 0;

                if (command.keyDown)
                    command.timeSpanHeld += 1;
                else
                    command.timeSpanHeld = 0;

                State.commands[commandName] = command;
            }
        }
        updateCommands();
    }
}
