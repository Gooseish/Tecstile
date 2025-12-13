using System;

namespace Tecstile.Source_Code.Scene;

public struct SceneState
{
    public SceneBase activeScene;
    public int inputSleepTimer;
    public int fadeTime;
    public int fadeTimer;

    public SceneState()
    {
        inputSleepTimer = 0;

        activeScene = new SceneTitleState();
    }
}

