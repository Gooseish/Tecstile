using System;
using System.Collections.Generic;

namespace Tecstile.Game_Board;

public class GameMap
{
    #region Fields
    public string tileset;
    public int height;
    public int width;
    /// <summary>
    /// Terrain map of the tileset. Keys represent 
    /// tile ids, values represent terrain types.
    /// </summary>
    public Dictionary<int, Terrain> terrainMap;
    /// <summary>
    /// The int for each element of tileData corresponds to a specific tile 
    /// on the tileset. The position of each element in the array corresponds
    /// to the map coordinates.
    /// </summary>
    public int[,] tileData;
    #endregion

    #region Accessors
    /// <summary>
    /// Retrieve the terrain data at location x, y
    /// </summary>
    /// <param name="x"></param>
    /// <param name="y"></param>
    /// <returns></returns>
    public Terrain terrainAtLocation(int x, int y)
    {
        return terrainMap[tileData[x, y]];
    }
    #endregion
}
