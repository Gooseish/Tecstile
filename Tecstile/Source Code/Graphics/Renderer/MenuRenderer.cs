using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Tecstile.Menus;
using Tecstile.Menus.NodeComponents;
using Tecstile.Scene;

namespace Tecstile.Graphics;

public static partial class Renderer
{
    private static void DrawMenus(SpriteBatch spriteBatch)
    {
        if (!(Global.scene.activeScene is IMenuControlScheme scene))
            return;
        if (!(scene.menuControlActive))
            return;
        
        DrawNodes(spriteBatch);
    }
    private static void DrawNodes(SpriteBatch spriteBatch)
    {
        spriteBatch.Begin();
        foreach (NodeBase testNode in Global.menu.nodes)
        {
            Color color = Color.White;
            if (testNode == Global.menu.activeNode)
                color = Color.Gray;
            if (testNode is INodeDrawFromNothing nodeDFN)
                spriteBatch.Draw(
                    Global.graphicalContent.menuTextures[nodeDFN.texture], 
                    new Rectangle((int)testNode.position.X, (int)testNode.position.Y, nodeDFN.width, nodeDFN.height), 
                    color);
            if (testNode is INodeDisplayText nodeDT)
                spriteBatch.DrawString(
                    Global.graphicalContent.fonts["Arial"], 
                    nodeDT.displayText, 
                    testNode.position, 
                    Color.Black);
        }
        spriteBatch.End();
    }
}
