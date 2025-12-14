using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Tecstile.Scene;


namespace Tecstile.Graphics;

public static partial class Renderer
{
    private static bool DrawTitle(SpriteBatch spriteBatch)
    {
        if (!(Global.scene.activeScene is SceneTitle scene))
            return false;
        if (scene.menuControlActive)
            return true;
        
        DrawTitleText(spriteBatch);
        return true;
    }
    private static void DrawTitleText(SpriteBatch spriteBatch)
    {
        spriteBatch.Begin();
        spriteBatch.DrawString(
            Global.graphicalContent.fonts["Arial"],
            "Press Start",
            new Vector2(600, 300),  // Should have a vector extension that points to the center of the game window
            Color.Black
            );
        spriteBatch.End();
    }
}
