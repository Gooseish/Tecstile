using System;
using System.Collections.Generic;

namespace Tecstile.Game_Board;

public class Terrain
{
    public int id {get;set;}
    public string name {get;set;}
    public int avoid {get;set;}
    public int def {get;set;}
    public int res {get;set;}
    public bool heals {get;set;}
    public int healPercent {get;set;}
    public Dictionary<MovementType, int> movementCost {get;set;}
}

public enum MovementType
{
    Light, Heavy, Armor, Mounted, Flying
}