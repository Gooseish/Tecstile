using System;
using Tecstile.Source_Code.Scene;

namespace Tecstile.Source_Code.Scene;

public struct SceneTitleState: 
IMenuControlScheme
{
    #region Interface Complaince
    public bool menuControlActive {get;set;}
    public bool inspectActive{get;set;}
    #endregion
}
