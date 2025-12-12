using System;

namespace Tecstile.Source_Code.Input;

/// <summary>
/// Struct that represents the key state of a generic key (e.g.
/// "Up", "Down", "Confirm", Etc.)
/// </summary>
public struct Command
{
    public bool KeyPressed;     // New key press
    public bool KeyDown;        // Key state is down
    public int TimeSpanHeld;    // How long the key has been held down
    public bool KeyReleased;    // New key release
}

public enum CommandName
{
    confirm, cancel, 
    up, down, left, right,
    start, select,
    tab, info,
    escape
}