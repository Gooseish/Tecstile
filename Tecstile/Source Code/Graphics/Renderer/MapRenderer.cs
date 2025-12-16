using System;
using Tecstile.Scene;

namespace Tecstile.Graphics;

public class MapRenderer
{
    private static bool DrawMap()
    {
        if (Global.scene.activeScene is not SceneMap scene)
            return false;
        
        return true;
    }
}
