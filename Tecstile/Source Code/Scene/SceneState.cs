using System;
using Tecstile.Source_Code.Scene.SceneTypes;

namespace Tecstile.Source_Code.Scene;

public struct SceneState
{
    public int inputSleepTimer;
    public SceneBase activeScene;

    public SceneState()
    {
        inputSleepTimer = 0;

        activeScene = new SceneTitleState();
    }
}

