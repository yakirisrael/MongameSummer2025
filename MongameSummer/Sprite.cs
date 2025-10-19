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

    public SpriteEffects effects = SpriteEffects.None;
    
    protected Vector2 _origin;
    
    protected Spritesheet _spritesheet;

    protected Rectangle? sourceRectangle = null;
    
    public Sprite(string spriteName)
    {
        _spritesheet = SpriteManager.GetSprite(spriteName);
        _texture = _spritesheet.texture;

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
            sourceRectangle,
            Color.White,
            MathHelper.ToRadians(rotation),
            _origin,
            scale,
            effects,
            depthLayer
        );
    }
}