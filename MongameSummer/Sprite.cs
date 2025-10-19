using System.Numerics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Vector2 = Microsoft.Xna.Framework.Vector2;

namespace MongameSummer;

public class Sprite : IUpdateable, IDrawable
{
    public Vector2 position = Vector2.Zero;
    public float rotation = 0.0f;
    public float scale = 1.0f;
    public float depthLayer = 0.0f;
    
    protected Texture2D _texture;
    
    protected Vector2 _origin;
    
    public Sprite(ContentManager content, string spriteName)
    {
        _texture = content.Load<Texture2D>(spriteName);

        _origin = new Vector2(_texture.Width * 0.5f, _texture.Height * 0.5f);
    }

    public virtual void Update(GameTime gameTime)
    {
        
    }
    
    public virtual void Draw(SpriteBatch _spriteBatch)
    {
        
        _spriteBatch.Draw(
            _texture,
            position,
            null,
            Color.White,
            MathHelper.ToRadians(rotation),
            _origin,
            scale,
            SpriteEffects.None,
            depthLayer
        );
    }
}