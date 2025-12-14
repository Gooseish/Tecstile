using System;

namespace Tecstile.Scene;

public class SceneState
{
    public SceneBase activeScene;
    public int inputSleepTimer;
    public int fadeTime;
    public int fadeTimer;
    public bool exitCalling;

    public SceneState()
    {
        inputSleepTimer = 0;

        activeScene = new SceneTitle();
    }
}

