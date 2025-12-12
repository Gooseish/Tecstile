using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework.Input;
using Tecstile.Input;

namespace Tecstile.Source_Code.Settings;

public class SettingsManager
{
    private SettingsState State;

    public Dictionary<Input.CommandName, Keys> keyboardMap {get {return State.KeyboardMap;}}
    public SettingsManager()
    {
        State = new SettingsState();
        RestoreDefaultSettings();
        RestoreSavedSettings();
    }

    public void RestoreDefaultSettings()
    {
        void Keybinds()
        {
            State.KeyboardMap.Clear();

            State.KeyboardMap[Input.CommandName.confirm] = Keys.Z;
            State.KeyboardMap[Input.CommandName.cancel] = Keys.X;
            State.KeyboardMap[Input.CommandName.up] = Keys.Up;
            State.KeyboardMap[Input.CommandName.down] = Keys.Down;
            State.KeyboardMap[Input.CommandName.left] = Keys.Left;
            State.KeyboardMap[Input.CommandName.right] = Keys.Right;
            State.KeyboardMap[Input.CommandName.start] = Keys.Enter;
            State.KeyboardMap[Input.CommandName.select] = Keys.Back;
            State.KeyboardMap[Input.CommandName.tab] = Keys.A;
            State.KeyboardMap[Input.CommandName.info] = Keys.C;
            State.KeyboardMap[Input.CommandName.escape] = Keys.Escape;
        }
        Keybinds();
    }
    public void RestoreSavedSettings()
    {
        
    }
}
