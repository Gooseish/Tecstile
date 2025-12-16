using System;
using System.Collections.Generic;

namespace Tecstile.Game_Board;

public class Terrain
{
    public int id;
    public string name;
    public int avoid;
    public int def;
    public int res;
    public bool heals;
    public int healPercent;
    public Dictionary<MovementType, int> movementCost;
}

public enum MovementType
{
    Light, Heavy, Armor, Mounted, Flying
}