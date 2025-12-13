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
        // TODO: Add your initialization logic here

        base.Initialize();
    }

    protected override void LoadContent()
    {
        // TODO: use this.Content to load your game content here

        base.LoadContent();
    }

    protected override void Update(GameTime gameTime)
    {
        //if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
        if (Global.menu.exitCalling)
            Exit();

        Global.clock.update(gameTime);
        Global.input.update();
        Global.scene.update();

        base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime)
    {
        Renderer.draw(GraphicsDevice);

        base.Draw(gameTime);
    }
}
