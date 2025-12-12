using System;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Tecstile.Graphics;

public static class Renderer
{
    public static void draw(GraphicsDevice graphicsDevice)
    {
        graphicsDevice.Clear(Color.CornflowerBlue);
    }
}
