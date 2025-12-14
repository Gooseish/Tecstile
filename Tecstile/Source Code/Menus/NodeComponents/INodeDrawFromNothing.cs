using System;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Tecstile.Menus;

/// <summary>
/// This is a debug interface for drawing placeholder
/// textures. This should not be used in any actual
/// build of a game.
/// </summary>
public interface INodeDrawFromNothing
{
    public int width {get;set;}
    public int height {get;set;}
    public string texture {get;}
}
