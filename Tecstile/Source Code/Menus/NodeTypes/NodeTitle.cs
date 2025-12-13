using System;
using Microsoft.Xna.Framework;
using Tecstile.Source_Code.Menus.NodeComponents;

namespace Tecstile.Source_Code.Menus;

/// <summary>
/// Nodes for the title screen menu
/// </summary>
public class NodeTitle:
NodeBase,
INodeAddMenu,
INodeDisplayText
{
    public NodeTitle(Vector2 Position, string DisplayText, MenuType MenuToOpen)
    {
        menuToOpen = MenuToOpen;
        position = Position;
        displayText = DisplayText;
    }
    #region Interface Compliance
    public MenuType menuToOpen {get;set;}
    public bool openMenuCondition {get {return true;}}
    public string displayText {get;set;}
    #endregion
}
