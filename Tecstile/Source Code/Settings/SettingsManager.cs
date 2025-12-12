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

            state.KeyboardMap[Keys.Z] = Input.CommandName.confirm;
            state.KeyboardMap[Keys.X] = Input.CommandName.cancel;
            state.KeyboardMap[Keys.Up] = Input.CommandName.up;
            state.KeyboardMap[Keys.Down] = Input.CommandName.down;
            state.KeyboardMap[Keys.Left] = Input.CommandName.left;
            state.KeyboardMap[Keys.Right] = Input.CommandName.right;
            state.KeyboardMap[Keys.Enter] = Input.CommandName.start;
            state.KeyboardMap[Keys.Back] = Input.CommandName.select;
            state.KeyboardMap[Keys.A] = Input.CommandName.tab;
            state.KeyboardMap[Keys.C] = Input.CommandName.info;
            state.KeyboardMap[Keys.Escape] = Input.CommandName.escape;
        }
        Keybinds();
    }
    public void RestoreSavedSettings()
    {
        
    }
}
