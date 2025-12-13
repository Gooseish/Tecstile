using System;

namespace Tecstile.Source_Code.Scene;

public struct SceneState
{
    public SceneTitleState sceneTitleState;
    public SceneType activeScene;

    public SceneState()
    {
        sceneTitleState = new SceneTitleState();
        activeScene = SceneType.Title;
    }
}
public enum SceneType
{
    Title
}
