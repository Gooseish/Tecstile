using System;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Tecstile.Scene;
using System.Collections.Generic;
using Tecstile.Config;

namespace Tecstile.Graphics;

public static partial class Renderer
{
    #region Render Targeting
    private static RenderTarget2D[] StableRenderTargets = new RenderTarget2D[2];
    private static RenderTarget2D[] VolatileRenderTargets = new RenderTarget2D[2];
    private static int StableIndex = 0;
    private static int VolatileIndex = 0;
    #endregion
    #region Drawing
    public static void draw(GraphicsDevice graphicsDevice)
    {
        RenderTarget2D renderTarget = new RenderTarget2D(
            graphicsDevice, TecstileConfig.sourceResolutionWidth, TecstileConfig.sourceResolutionHeight);

        graphicsDevice.SetRenderTarget(renderTarget);
        graphicsDevice.Clear(Color.CornflowerBlue);
        
        SpriteBatch spriteBatch = new SpriteBatch(graphicsDevice);

        DrawAtSourceResolution(spriteBatch);

        graphicsDevice.SetRenderTarget(null);

        DrawToTargetResolution(spriteBatch, renderTarget);
    }
    private static void DrawAtSourceResolution(SpriteBatch spriteBatch)
    {
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
    private static void DrawToTargetResolution(SpriteBatch spriteBatch, RenderTarget2D renderTarget)
    {
        spriteBatch.Begin();
        spriteBatch.Draw(renderTarget, Global.settings.letterboxPicture, Color.White);
        spriteBatch.End();
    }
    #endregion
}
