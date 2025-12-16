using System;

namespace Tecstile.Scene;

public class SceneMap:
SceneBase,
ISceneBoardControls,
ISceneMenuControls,
ISceneTilemap,
ISceneCutsceneControls,
ISceneBackdrop
{
    public SceneMap()
    {
        sceneType = SceneType.Map;
    }
    #region Interface Compliance
    public bool menuControlActive {get;set;}
    public bool inspectActive{get;set;}
    public bool mapControlActive{get;set;}
    #endregion
}

public partial class SceneManager
{
    private bool HandleInput_Map()
    {
        if (State.activeScene is not SceneMap activeScene)
            return false;
        return true;
    }
    private void UpdateState_Map()
    {
        if (State.activeScene is not SceneMap activeScene)
            return;
    }
}