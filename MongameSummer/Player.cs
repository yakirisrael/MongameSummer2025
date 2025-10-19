using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Input;

namespace MongameSummer;

public class Player : Sprite
{
    public Player(ContentManager content, string spriteName) : base(content, spriteName)
    {
    }

    private float speed = 2f;
    public override void Update(GameTime gameTime)
    {
        KeyboardState state = Keyboard.GetState();


        if (state.IsKeyDown(Keys.Right))
        {
            position += speed * Vector2.UnitX;
        }
        if (state.IsKeyDown(Keys.Left))
        {
            position += -(speed * Vector2.UnitX);
        }

        base.Update(gameTime);  
    }
}