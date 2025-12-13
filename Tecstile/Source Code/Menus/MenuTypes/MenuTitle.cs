using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Tecstile.Source_Code.Menus;

namespace Tecstile.Source_Code.Menus;

public class MenuTitle:
MenuBase,
IMenuNodeMap
{
    public MenuTitle()
    {
        nodeMapType = NodeMapType.Linear;

        void addNodes()
        {
            nodes = new List<NodeBase>{};
            // New Game
            nodes.Add(new NodeTitle(
                new Vector2(10, 10),
                "New Game",
                MenuType.NewGame
            ));
            // Load Game
            nodes.Add(new NodeTitle(
                new Vector2(10, 20),
                "Load Game",
                MenuType.LoadGame
            ));
            // Settings
            nodes.Add(new NodeTitle(
                new Vector2(10, 30),
                "Settings",
                MenuType.Settings
            ));
            // Exit
            nodes.Add(new NodeTitleExit(
                new Vector2(10, 40),
                "Quit"
            ));
        }
        addNodes();
    }
    #region Interface Compliance
    public List<NodeBase> nodes{get;set;}
    public int activeNodeIndex{get;set;}
    public bool inspectActive{get;set;}
    public NodeMapType nodeMapType{get;set;}
    #endregion
}
