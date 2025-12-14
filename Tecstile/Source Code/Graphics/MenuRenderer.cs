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
            if (testNode == Global.menu.activeNode)
                color = Color.Gray;
            if (testNode is INodeDrawFromNothing node)
                spriteBatch.Draw(
                    Global.graphicalContent.menuTextures[node.texture], 
                    new Rectangle((int)testNode.position.X, (int)testNode.position.Y, node.width, node.height), 
                    color);
        }
        spriteBatch.End();
    }
}
