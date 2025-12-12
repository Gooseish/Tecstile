using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Tecstile.Source_Code.Input;

namespace Tecstile.Input;

public class InputHandler
{
    private InputState State;
    
    //private KeyboardState PreviousKeyboardState;
    private KeyboardState CurrentKeyboardState;
    public InputHandler()
    {
        State = new InputState();

        //PreviousKeyboardState = new KeyboardState();
        CurrentKeyboardState = Keyboard.GetState();
    }
    public void update(GameTime gameTime)
    {
        //PreviousKeyboardState = CurrentKeyboardState;
        void updateCommands()
        {
            CurrentKeyboardState = Keyboard.GetState();
            foreach(var (commandName, key) in Global.settings.keyboardMap)
            {
                Command command = State.commands[commandName];

                command.KeyDown = CurrentKeyboardState.IsKeyDown(key);
                command.KeyPressed = (command.KeyDown && command.TimeSpanHeld == 0);
                command.KeyReleased = (!command.KeyDown && command.TimeSpanHeld > 0);

                if (command.KeyDown)
                    command.TimeSpanHeld += 1;
                else
                    command.TimeSpanHeld = 0;

                State.commands[commandName] = command;
            }
        }
        updateCommands();

    }
}
