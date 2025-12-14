using System;
using Tecstile.Scene;

namespace Tecstile.Scene;

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
