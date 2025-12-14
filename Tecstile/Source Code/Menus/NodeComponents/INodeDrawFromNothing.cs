using System;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Tecstile.Menus;

/// <summary>
/// This is a debug interface for drawing placeholder
/// textures. This should not be used in any actual
/// build of a game.
/// </summary>
public interface INodeDrawFromNothing
{
    public int width {get;set;}
    public int height {get;set;}
    public Texture2D texture {get;set;}

    public static Texture2D new_texture(int width, int height)
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
}
