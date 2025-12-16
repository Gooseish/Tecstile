using System;

namespace Tecstile.Scene;

/// <summary>
/// Interface for the game board control scheme
/// (i.e. moving the cursor around the map and selecting units)
/// </summary>
public interface ISceneBoardControls
{
    public bool mapControlActive { get; set;} // Is the control scheme accepting input?
}
