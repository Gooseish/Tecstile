using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Tecstile.Menus.NodeComponents;

namespace Tecstile.Menus;

/// <summary>
/// Special node for the "quit game" node on the game's title menu
/// </summary>
public class NodeTitleExit:
NodeBase,
INodeExitGame,
INodeDisplayText,
INodeDrawFromNothing
{
    public NodeTitleExit(Vector2 Position, string DisplayText)
    {
        position = Position;
        displayText = DisplayText;
        width = 1000;
        height = 50;
    }
    #region Interface Compliance
    public string displayText {get;set;}
    public int width {get;set;}
    public int height {get;set;}
    public string texture{get {return "WhiteSquare";}}
    #endregion
}