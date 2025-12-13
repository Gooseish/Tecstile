using System;

namespace Tecstile.Source_Code.Scene;

public interface IMenuControlScheme
{
    public bool menuControlActive { get; set;} // Is the control scheme accepting input?
    public bool inspectActive{get;set;}
}
