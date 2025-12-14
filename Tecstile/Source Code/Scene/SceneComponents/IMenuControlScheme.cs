using System;

namespace Tecstile.Scene;

public interface IMenuControlScheme
{
    public bool menuControlActive { get; set;} // Is the control scheme accepting input?
    public bool inspectActive{get;set;}
}
