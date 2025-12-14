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

        void BySceneType()
        {
            bool drawTitle()
            {
                if (Global.scene.activeScene is SceneTitle scene)
                    if (!scene.menuControlActive)
                    {
                        DrawTitleText(spriteBatch);
                        return true;
                    }
                    return false;
            }
            if (drawTitle())
                return;
        }
        BySceneType();

        void ByComponent()
        {
            void drawMenus()
            {
                if (Global.scene.activeScene is IMenuControlScheme scene)
                    if (scene.menuControlActive)
                    {
                        DrawNodes(spriteBatch);
                    }
            }
            drawMenus();
        }
        ByComponent();
    }
}
