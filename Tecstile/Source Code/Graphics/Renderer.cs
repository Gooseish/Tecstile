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

        void drawMenus()
        {
            DrawNodes(spriteBatch);
        }
        if (Global.scene.activeScene is IMenuControlScheme sceneMCS)
            if (sceneMCS.menuControlActive)
                drawMenus();
        
        void drawTitle()
        {
            DrawTitleText(spriteBatch);
        }
        if (Global.scene.activeScene is SceneTitle sceneTitle)
            if (!sceneTitle.menuControlActive)
                drawTitle();
    }
}
