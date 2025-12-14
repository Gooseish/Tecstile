using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Tecstile.Menus;

namespace Tecstile.Graphics;

public static partial class Renderer
{
    private static void DrawNodes(SpriteBatch spriteBatch)
    {
        spriteBatch.Begin();
        foreach (NodeBase testNode in Global.menu.nodes)
        {
            Color color = Color.White;
            if (testNode == ((IMenuNodeMap)Global.menu.state.activeMenu).activeNode)
                color = Color.Gray;
            if (testNode is INodeDrawFromNothing node)
                spriteBatch.Draw(node.texture, testNode.position, color);
        }
        spriteBatch.End();
    }
}
