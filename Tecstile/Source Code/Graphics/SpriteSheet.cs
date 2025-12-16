using System;
using System.ComponentModel;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Tecstile.Graphics;

public class SpriteSheet
{
    /// <summary>
    /// Texture data for the sprite sheet.
    /// </summary>
    public Texture2D texture;
    /// <summary>
    /// Width (in terms of number of cells)
    /// </summary>
    public int width;
    /// <summary>
    /// Height (in terms of number of cells)
    /// </summary>
    public int height;
    /// <summary>
    /// Width (in pixels) of each cell.
    /// </summary>
    public int cellWidth;
    /// <summary>
    /// Height (in pixels) of each cell.
    /// </summary>
    public int cellHeight;

    public SpriteSheet(Texture2D Texture, int CellWidth, int CellHeight)
    {
        texture = Texture;
        cellWidth = CellWidth;
        cellHeight = CellHeight;
        width = texture.Width/cellWidth;
        height = texture.Height/cellHeight;
    }

    #region Accessors
    /// <summary>
    /// Get the source rectangle for a given cell of a sprite sheet.
    /// </summary>
    /// <param name="cellNumber"></param>
    /// <returns></returns>
    public Rectangle sourceRectangle(int cellNumber)
    {
        int x = cellNumber % width;
        int y = cellNumber / width;
        return new Rectangle(x, y, cellWidth, cellHeight);
    }
    #endregion
}
