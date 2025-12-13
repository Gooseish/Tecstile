using System;

namespace Tecstile.Source_Code.Input;

/// <summary>
/// Class that represents the key state of a generic key (e.g.
/// "Up", "Down", "Confirm", Etc.)
/// </summary>
public class Command
{
    /// <summary>
    /// New key press detected?
    /// </summary>
    public bool keyPressed;
    /// <summary>
    /// Is the key being help down now?
    /// </summary>
    public bool keyDown;
    /// <summary>
    /// How long has the key been held down?
    /// </summary>
    public int timeSpanHeld;
    /// <summary>
    /// New key release detected?
    /// </summary>
    public bool keyReleased;
    /// <summary>
    /// Result of the command (i.e. has the input been used yet?)
    /// </summary>
    public CommandResult Result;
}

public enum CommandName
{
    Confirm, Cancel, 
    Up, Down, Left, Right,
    Start, Select,
    Tab, Info,
    Escape
}
public enum CommandResult
{
    Null, Accepted, Rejected
}