using System;
using Microsoft.Xna.Framework.Input;
using Tecstile.Input;

namespace Tecstile.Source_Code.Settings;

public class SettingsManager
{
    public SettingsState state;

    public SettingsManager()
    {
        state = new SettingsState();
        RestoreDefaultSettings();
        RestoreSavedSettings();
    }

    public void RestoreDefaultSettings()
    {
        void Keybinds()
        {
            state.KeyboardMap.Clear();

            state.KeyboardMap[Input.CommandName.confirm] = Keys.Z;
            state.KeyboardMap[Input.CommandName.cancel] = Keys.X;
            state.KeyboardMap[Input.CommandName.up] = Keys.Up;
            state.KeyboardMap[Input.CommandName.down] = Keys.Down;
            state.KeyboardMap[Input.CommandName.left] = Keys.Left;
            state.KeyboardMap[Input.CommandName.right] = Keys.Right;
            state.KeyboardMap[Input.CommandName.start] = Keys.Enter;
            state.KeyboardMap[Input.CommandName.select] = Keys.Back;
            state.KeyboardMap[Input.CommandName.tab] = Keys.A;
            state.KeyboardMap[Input.CommandName.info] = Keys.C;
            state.KeyboardMap[Input.CommandName.escape] = Keys.Escape;
        }
        Keybinds();
    }
    public void RestoreSavedSettings()
    {
        
    }
}
