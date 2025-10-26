using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace MongameSummer;

public class Collider : Sprite
{
    public Collider() : base("pixel")
    {
    }
    
    
    int thickness = 5;
    Color color = Color.White;
    
    public override void Draw(SpriteBatch _spriteBatch)
    {
 
        
#if DEBUG
    
        // Draw outline
         
        // top
        _spriteBatch.Draw(_texture,
            new Rectangle(
                DestRectangle.Value.X,
                DestRectangle.Value.Y,
                DestRectangle.Value.Width,
                thickness
            ), 
            color);
        
        // left
        _spriteBatch.Draw(_texture,
            new Rectangle(
                DestRectangle.Value.X,
                DestRectangle.Value.Y,
                thickness,
                DestRectangle.Value.Height
            ), 
            color);
        
        // right
        _spriteBatch.Draw(_texture,
            new Rectangle(
                DestRectangle.Value.X + DestRectangle.Value.Width - thickness,
                DestRectangle.Value.Y,
                thickness,
                DestRectangle.Value.Height
            ), 
            color);
        
        // bottom
        _spriteBatch.Draw(_texture,
            new Rectangle(
                DestRectangle.Value.X,
                DestRectangle.Value.Y + DestRectangle.Value.Height - thickness,
                DestRectangle.Value.Width,
                thickness
            ), 
            color);
    #endif
        
        
    }
}
    