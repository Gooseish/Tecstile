using System;
using System.Collections.Generic;
using Tecstile.Game_Board;

namespace Tecstile.Data;

public class DataContentManager
{
    private DataContentState State;
    public DataContentManager()
    {
        State = new DataContentState();
    }
    #region Accessors
    public IReadOnlyDictionary<int, Terrain> terrainData
        {get {return State.terrainData;}}
    public GameMap gameMap(string name)
    {
        // TODO: Read gameMap data and return new object
        return new GameMap();
    }
    #endregion
    #region Public Controls
    public void loadContent()
    {
        loadTerrainData();
        void loadTerrainData()
        {
            
        }
    }
    #endregion
    #region Private Controls
    #endregion
}
