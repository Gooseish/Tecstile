using System;
using System.Collections.Generic;
using System.Linq;
using Tecstile.Data;
using Tecstile.Game_Board;

namespace TecstileEditor.Models;

public static class DataContentManager
{
    private static DataContentState dataContent;

    public static IReadOnlyDictionary<int, string> TerrainDict
    {
        get {return dataContent.terrainData.ToDictionary(t => t.Key, t => t.Value.name);}
    }
    public static Terrain GetTerrain(int id)
    {
        return dataContent.terrainData[id];
    }
}
