using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using Tecstile.Data;
using Tecstile.Game_Board;

namespace TecstileEditor.Models;

public static class TerrainDataModel
{
    public static void Save()
    {
        System.Console.WriteLine("Ding!");
    }
    public static Dictionary<int, Terrain> terrainData = new();
    public static Terrain newTerrain()
    {
        Terrain result = new Terrain()
        {
            id = NextTerrainId(),
            name = "New Terrain",
            avoid = 0,
            def = 0,
            res = 0,
            heals = false,
            healPercent = 0,
            movementCost = DefaultMoveCost(),
        };
        terrainData[result.id] = result;
        return result;
    }
    private static int NextTerrainId()
    {
        int n = 0;
        while (terrainData.Keys.Contains(n))
            n++;
        return n;
    }
    private static Dictionary<MovementType, int> DefaultMoveCost()
    {
        Dictionary<MovementType, int> result = new();
        foreach(MovementType movementType in Enum.GetValues(typeof(MovementType)))
            result[movementType] = 1;
        return result;
    }
}
