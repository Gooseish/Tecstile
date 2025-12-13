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

            State.KeyboardMap[Input.CommandName.Confirm] = Keys.Z;
            State.KeyboardMap[Input.CommandName.Cancel] = Keys.X;
            State.KeyboardMap[Input.CommandName.Up] = Keys.Up;
            State.KeyboardMap[Input.CommandName.Down] = Keys.Down;
            State.KeyboardMap[Input.CommandName.Left] = Keys.Left;
            State.KeyboardMap[Input.CommandName.Right] = Keys.Right;
            State.KeyboardMap[Input.CommandName.Start] = Keys.Enter;
            State.KeyboardMap[Input.CommandName.Select] = Keys.Back;
            State.KeyboardMap[Input.CommandName.Tab] = Keys.A;
            State.KeyboardMap[Input.CommandName.Info] = Keys.C;
            State.KeyboardMap[Input.CommandName.Escape] = Keys.Escape;
        }
        Keybinds();
    }
    public void RestoreSavedSettings()
    {
        
    }
}
