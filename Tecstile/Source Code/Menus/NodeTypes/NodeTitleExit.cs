using System;
using Microsoft.Xna.Framework;
using Tecstile.Source_Code.Menus.NodeComponents;

namespace Tecstile.Source_Code.Menus;

/// <summary>
/// Special node for the "quit game" node on the game's title menu
/// </summary>
public class NodeTitleExit:
NodeBase,
INodeExitGame,
INodeDisplayText
{
    public NodeTitleExit(Vector2 Position, string DisplayText)
    {
        displayText = DisplayText;
    }
    #region Interface Compliance
    public string displayText {get;set;}
    #endregion
}