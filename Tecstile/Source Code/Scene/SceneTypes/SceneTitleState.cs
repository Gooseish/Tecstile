using System;
using Tecstile.Source_Code.Scene;

namespace Tecstile.Source_Code.Scene;

public class SceneTitleState: 
SceneBase,
IMenuControlScheme
{
    public SceneTitleState()
    {
        sceneType = SceneType.Title;
    }
    #region Interface Compliance
    public bool menuControlActive {get;set;}
    public bool inspectActive{get;set;}
    #endregion
}
