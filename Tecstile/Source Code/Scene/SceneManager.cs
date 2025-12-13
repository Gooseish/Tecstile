using System;
using System.ComponentModel;
using Microsoft.Xna.Framework;

namespace Tecstile.Source_Code.Scene;

public class SceneManager
{
    private SceneState State;
    public SceneType sceneType;
    public SceneManager()
    {
        State = new SceneState();
    }
    public void update()
    {
        switch (sceneType)
        {
            case SceneType.Title:
                updateSceneTitle();
                break;
            default:
                throw new Exception("Scene type not recognized.");
        }


    }
    public void updateSceneTitle()
    {
        
    }
}
