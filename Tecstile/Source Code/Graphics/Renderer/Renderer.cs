using System;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Tecstile.Config;

namespace Tecstile.Graphics;

public static partial class Renderer
{
    #region Drawing
    public static void draw()
    {
        graphicsDevice.SetRenderTarget(CurrentStable);
        graphicsDevice.Clear(Color.CornflowerBlue);
        
        SpriteBatch spriteBatch = new SpriteBatch(graphicsDevice);
        DrawAtSourceResolution(spriteBatch);
        DrawToTargetResolution(spriteBatch, CurrentStable);
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
        graphicsDevice.SetRenderTarget(null);
        spriteBatch.Begin();
        spriteBatch.Draw(renderTarget, Global.settings.letterboxPicture, Color.White);
        spriteBatch.End();
    }
    #endregion
    #region Render Targeting
    /// <summary>
    /// Stable render targets are used to store the cumulative image built
    /// during the drawing process.
    /// </summary>
    private static RenderTarget2D[] StableRenderTargets = new RenderTarget2D[2];
    /// <summary>
    /// Volatile render targets are used to store temporary image data.
    /// </summary>
    private static RenderTarget2D[] VolatileRenderTargets = new RenderTarget2D[2];
    private static int StableIndex = 0;
    private static int VolatileIndex = 0;
    private static RenderTarget2D CurrentVolatile {
        get {return VolatileRenderTargets[VolatileIndex];}
        set {VolatileRenderTargets[VolatileIndex] = value;}}
    private static RenderTarget2D PreviousVolatile {
        get {return VolatileRenderTargets[(VolatileIndex + 1) % 2];}
        set {VolatileRenderTargets[(VolatileIndex + 1) % 2] = value;}}
    private static RenderTarget2D CurrentStable {
        get {return StableRenderTargets[StableIndex];}
        set {StableRenderTargets[StableIndex] = value;}}
    private static RenderTarget2D PreviousStable {
        get {return StableRenderTargets[(StableIndex + 1) % 2];}
        set {StableRenderTargets[(StableIndex + 1) % 2] = value;}}
    private static void NextVolatile()
    {
        VolatileIndex = (VolatileIndex + 1) % 2;
        graphicsDevice.SetRenderTarget(CurrentVolatile);
        graphicsDevice.Clear(Color.Transparent);
    }
    private static void NextStable()
    {
        StableIndex = (StableIndex + 1) % 2;
        graphicsDevice.SetRenderTarget(CurrentStable);
        graphicsDevice.Clear(Color.Transparent);
    }
    public static void initializeRenderTargets()
    {
        for (int n = 0; n < StableRenderTargets.Length; n++)
            StableRenderTargets[n] = new RenderTarget2D(
                graphicsDevice, TecstileConfig.sourceResolutionWidth, TecstileConfig.sourceResolutionHeight);

        for (int n = 0; n < VolatileRenderTargets.Length; n++)
            VolatileRenderTargets[n] = new RenderTarget2D(
                graphicsDevice, TecstileConfig.sourceResolutionWidth, TecstileConfig.sourceResolutionHeight);
    }
    #endregion
    #region Alias
    public static GraphicsDevice graphicsDevice {get{return Core.GraphicsDevice;}}
    #endregion
}
