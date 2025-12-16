using System;
using System.Collections.Generic;
using Tecstile.Game_Board;

namespace Tecstile.Data;

public class DataContentState
{
    public Dictionary<int, Terrain> terrainData;
    public Dictionary<string, GameMap> mapData;
    public DataContentState()
    {
        terrainData = new Dictionary<int, Terrain>{};
        mapData = new Dictionary<string, GameMap>{};
    }
}
