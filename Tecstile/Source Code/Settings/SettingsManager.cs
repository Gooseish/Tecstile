using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework.Input;
using Tecstile.Input;

namespace Tecstile.Settings;

public class SettingsManager
{
    private SettingsState State;
    public IReadOnlyDictionary<CommandName, Keys> keyboardMap {get {return State.keyboardMap;}}
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
            State.keyboardMap.Clear();

            State.keyboardMap[CommandName.Confirm] = Keys.Z;
            State.keyboardMap[CommandName.Cancel] = Keys.X;
            State.keyboardMap[CommandName.Up] = Keys.Up;
            State.keyboardMap[CommandName.Down] = Keys.Down;
            State.keyboardMap[CommandName.Left] = Keys.Left;
            State.keyboardMap[CommandName.Right] = Keys.Right;
            State.keyboardMap[CommandName.Start] = Keys.Enter;
            State.keyboardMap[CommandName.Select] = Keys.Back;
            State.keyboardMap[CommandName.Tab] = Keys.A;
            State.keyboardMap[CommandName.Info] = Keys.C;
            State.keyboardMap[CommandName.Escape] = Keys.Escape;
        }
        Keybinds();

        void Volume()
        {
            State.masterVolume = 100;
            State.musicVolume = 100;
            State.sfxVolume = 100;
        }
        Volume();
    }
    public void RestoreSavedSettings()
    {
        
    }
}
