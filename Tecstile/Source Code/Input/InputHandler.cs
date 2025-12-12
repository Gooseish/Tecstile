using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Tecstile.Source_Code.Input;

namespace Tecstile.Input;

public class InputHandler
{
    public InputState state;
    
    private KeyboardState PreviousKeyboardState;
    private KeyboardState CurrentKeyboardState;
    public InputHandler()
    {
        state = new InputState();
        
        PreviousKeyboardState = new KeyboardState();
        CurrentKeyboardState = Keyboard.GetState();
    }
    public void update(GameTime gameTime)
    {
        PreviousKeyboardState = CurrentKeyboardState;
        CurrentKeyboardState = Keyboard.GetState();
        foreach(var (commandName, key) in Global.settings.state.KeyboardMap)
        {
            
        }
    }
}
