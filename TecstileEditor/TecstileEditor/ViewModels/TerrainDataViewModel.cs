using System;
using System.Collections.Generic;
using System.ComponentModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Tecstile.Game_Board;
using TecstileEditor.Models;

namespace TecstileEditor.ViewModels;

public partial class TerrainDataViewModel : ObservableObject
{
    /// <summary>
    /// Create a new TerrainDataViewModel by creating a new
    /// terrain instance and registering it in the dictionary
    /// of all terrain data.
    /// </summary>
    public TerrainDataViewModel()
    {
        Terrain terrain = TerrainDataModel.newTerrain();
        _id = terrain.id;
        _name = terrain.name;
        _avoid = terrain.avoid;
        _def = terrain.def;
        _res = terrain.res;
        _heals = terrain.heals;
        _healPercent = terrain.healPercent;
        _movementCost = terrain.movementCost;
    }
    public TerrainDataViewModel(Terrain terrain)
    {
        _id = terrain.id;
        _name = terrain.name;
        _avoid = terrain.avoid;
        _def = terrain.def;
        _res = terrain.res;
        _heals = terrain.heals;
        _healPercent = terrain.healPercent;
        _movementCost = terrain.movementCost;
    }
    #region Boilerplate Properties
    [ObservableProperty]
    private int _id;
    partial void OnIdChanged(int oldValue, int newValue)
    {
        TerrainDataModel.terrainData.Remove(oldValue);
        TerrainDataModel.terrainData[newValue] = GetTerrain();
    }
    [ObservableProperty]
    private string _name;
    partial void OnNameChanged(string? oldValue, string newValue)
    {
        TerrainDataModel.terrainData[Id].name = newValue;
    }
    [ObservableProperty]
    private int _avoid;
    partial void OnAvoidChanged(int oldValue, int newValue)
    {
        TerrainDataModel.terrainData[Id].avoid = newValue;
    }
    [ObservableProperty]
    private int _def;
    partial void OnDefChanged(int oldValue, int newValue)
    {
        TerrainDataModel.terrainData[Id].def = newValue;
    }
    [ObservableProperty]
    private int _res;
    partial void OnResChanged(int oldValue, int newValue)
    {
        TerrainDataModel.terrainData[Id].res = newValue;
    }
    [ObservableProperty]
    private bool _heals;
    partial void OnHealsChanged(bool oldValue, bool newValue)
    {
        TerrainDataModel.terrainData[Id].heals = newValue;
    }
    [ObservableProperty]
    private int _healPercent;
    partial void OnHealPercentChanged(int oldValue, int newValue)
    {
        TerrainDataModel.terrainData[Id].healPercent = newValue;
    }
    [ObservableProperty]
    private Dictionary<MovementType, int> _movementCost;
    partial void OnMovementCostChanged(Dictionary<MovementType, int>? oldValue, Dictionary<MovementType, int> newValue)
    {
        TerrainDataModel.terrainData[Id].movementCost = newValue;
    }
    #endregion
    public Terrain GetTerrain()
    {
        return new Terrain()
        {
            id = Id,
            name = Name,
            avoid = Avoid,
            def = Def,
            res = Res,
            heals = Heals,
            healPercent = HealPercent,
            movementCost = MovementCost,
        };
    }
}
