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
        PreviousKeyboardState = new KeyboardState();
        CurrentKeyboardState = Keyboard.GetState();

    }
    public void update(GameTime gameTime)
    {
        PreviousKeyboardState = CurrentKeyboardState;
        CurrentKeyboardState = Keyboard.GetState();
        foreach(Keys key in Global.settings.state.KeyboardMap.Values)
        {
            
        }
    }
}
