using System;
using Microsoft.Xna.Framework;
using Tecstile.Menus.NodeComponents;

namespace Tecstile.Menus;

/// <summary>
/// Nodes for the title screen menu
/// </summary>
public class NodeTitle:
NodeBase,
INodeAddMenu,
INodeDisplayText,
INodeDrawFromNothing
{
    public NodeTitle(Vector2 Position, string DisplayText, MenuType MenuToOpen)
    {
        menuToOpen = MenuToOpen;
        position = Position;
        displayText = DisplayText;
        width = 100;
        height = 5;
    }
    #region Interface Compliance
    public MenuType menuToOpen {get;set;}
    public bool openMenuCondition {get {return true;}}
    public string displayText {get;set;}
    public int width {get;set;}
    public int height {get;set;}
    #endregion
}
