using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework.Graphics;

namespace Tecstile.Graphics;

public class GraphicalContentState
{
    public Dictionary<string, Texture2D> menuTextures;

    public GraphicalContentState()
    {
        menuTextures = new Dictionary<string, Texture2D>{};
    }
}
