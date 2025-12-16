using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Tecstile.Config;

namespace Tecstile.Graphics;

public class GraphicalContentManager
{
    private GraphicalContentState State;
    public GraphicalContentManager()
    {
        State = new GraphicalContentState();
    }

    #region Accessors
    public IReadOnlyDictionary<string, Texture2D> menuTextures
    {
        get {return State.menuTextures;}
    }
    public IReadOnlyDictionary<string, SpriteFont> fonts
    {
        get {return State.fonts;}
    }
    #endregion

    #region Public Controls
    public void loadContent()
    {
        ClearContent();

        loadFonts();
        void loadFonts()
        {
            State.fonts["Arial"] = Core.Content.Load<SpriteFont>(@"Fonts/Arial");
        }
    }
    public void initialize()
    {
        State.menuTextures["WhiteSquare"] = TextureFromSize(1, 1);
    }
    public void loadTileset(string tilesetName)
    {
        State.tileset = new SpriteSheet(
            Core.Content.Load<Texture2D>(@"Graphics/Tilesets/" + tilesetName), 
            TecstileConfig.tileWidth, TecstileConfig.tileHeight);
    }
    #endregion

    #region Private Controls
    private void ClearContent()
    {
        State.menuTextures.Clear();
        State.fonts.Clear();
    }
    private Texture2D TextureFromSize(int width, int height)
    {
        Texture2D texture = new Texture2D(Core.GraphicsDevice, width, height);
        Color[] data = new Color[width * height];
        for (int n = 0; n < data.Length; n++)
        {
            data[n] = Color.White;
        }
        texture.SetData(data);
        return texture;
    }
    #endregion
}
