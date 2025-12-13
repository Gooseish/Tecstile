using System;

namespace Tecstile.Source_Code.Scene;

public struct SceneState
{
    public int inputSleepTimer;
    public object activeScene;

    public SceneState()
    {
        inputSleepTimer = 0;

        activeScene = new SceneTitleState();
    }
}

