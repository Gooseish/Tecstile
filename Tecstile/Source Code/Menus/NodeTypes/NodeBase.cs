using System;
using Microsoft.Xna.Framework;

namespace Tecstile.Source_Code.Menus;

public abstract class NodeBase
{
    public NodeType type;
    public Vector2 position;
}
public enum NodeType
{
    NodeTitle,
}