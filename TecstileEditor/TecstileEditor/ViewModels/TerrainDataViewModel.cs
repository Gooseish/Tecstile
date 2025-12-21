using System;
using System.Collections.Generic;
using CommunityToolkit.Mvvm.ComponentModel;
using Tecstile.Game_Board;
using TecstileEditor.Models;

namespace TecstileEditor.ViewModels;

public partial class TerrainDataViewModel : ViewModelBase
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
    [ObservableProperty]
    private string _name;
    [ObservableProperty]
    private int _avoid;
    [ObservableProperty]
    private int _def;
    [ObservableProperty]
    private int _res;
    [ObservableProperty]
    private bool _heals;
    [ObservableProperty]
    private int _healPercent;
    [ObservableProperty]
    private Dictionary<MovementType, int> _movementCost;
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
