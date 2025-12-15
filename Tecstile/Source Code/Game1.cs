using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Tecstile.Graphics;

namespace Tecstile;

public class Game1 
: Core
{
    public Game1() : base("Tecstile", 1280, 720, false)
    {
        
    }

    protected override void Initialize()
    {
        base.Initialize();

        Global.graphicalContent.initialize();
    }

    protected override void LoadContent()
    {
        // TODO: use this.Content to load your game content here
        Global.graphicalContent.loadContent();

        base.LoadContent();
    }

    protected override void Update(GameTime gameTime)
    {
        if (Global.scene.exitCalling)
            Exit();

        Global.clock.update(gameTime);
        Global.input.update();
        Global.scene.update();

        base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime)
    {
        Renderer.draw();

        base.Draw(gameTime);
    }
}
