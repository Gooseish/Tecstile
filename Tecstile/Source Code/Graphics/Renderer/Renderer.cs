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
        SpriteBatch spriteBatch = new SpriteBatch(graphicsDevice);

        BySceneType();
        void BySceneType()
        {
            if (DrawTitle(spriteBatch))
                return;
            throw new Exception("Renderer could not recognize scene type.");
        }

        ByComponent();
        void ByComponent()
        {
            DrawMenus(spriteBatch);
        }
    }
}
