using System;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Tecstile.Scene;

namespace Tecstile.Graphics;

public static partial class Renderer
{
    public static void draw(GraphicsDevice graphicsDevice)
    {
        graphicsDevice.Clear(Color.CornflowerBlue);

        void drawMenus()
        {
            DrawNodes(graphicsDevice);
        }
        if (Global.scene is IMenuControlScheme scene)
            if (scene.menuControlActive)
                drawMenus();
    }
}
