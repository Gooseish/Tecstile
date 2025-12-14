using System;
using Tecstile.Scene;

namespace Tecstile.Scene;

public class SceneTitle: 
SceneBase,
IMenuControlScheme
{
    public SceneTitle()
    {
        sceneType = SceneType.Title;
    }
    #region Interface Compliance
    public bool menuControlActive {get;set;}
    public bool inspectActive{get;set;}
    #endregion
}
