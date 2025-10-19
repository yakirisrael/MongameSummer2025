using System;
using System.Runtime.InteropServices.ComTypes;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MongameSummer;
using System.Collections.Generic;
public class Game1 : Game
{
    private GraphicsDeviceManager _graphics;
    private SpriteBatch _spriteBatch;
    private static List<IDrawable> _drawables = new List<IDrawable>();
    private static List<IUpdateable> _updateables= new List<IUpdateable>();
    public Game1()
    {
        _graphics = new GraphicsDeviceManager(this);
        Content.RootDirectory = "Content";
        IsMouseVisible = true;
        _graphics.IsFullScreen = true;
        _graphics.PreferredBackBufferWidth = 1920;
        _graphics.PreferredBackBufferHeight = 1080;
    }

    protected override void Initialize()
    {
        // TODO: Add your initialization logic here

        ScreenCenterWidth = GraphicsDevice.Viewport.Width * 0.5f;
        ScreenCenterHeight = GraphicsDevice.Viewport.Height * 0.5f;
        
        base.Initialize();
    }

    private Sprite pacman;
    private SpriteFont oswaldFont;

    public static float ScreenCenterWidth;
    public static float ScreenCenterHeight;
    
    protected override void LoadContent()
    {
        _spriteBatch = new SpriteBatch(GraphicsDevice);

        pacman = new Player(Content, "Images/pacman");
        
        Content.Load<Texture2D>("Images/logo");
        Content.Load<Texture2D>("Images/pong-atlas");
        
        _updateables.Add(pacman);
        _drawables.Add(pacman);

        pacman.position = new Vector2(Game1.ScreenCenterWidth, Game1.ScreenCenterHeight);
        pacman.scale = 0.2f;
        
        oswaldFont = Content.Load<SpriteFont>("Fonts/Oswald");
        
        // TODO: use this.Content to load your game content here
    }

    protected override void Update(GameTime gameTime)
    {
        if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed ||
            Keyboard.GetState().IsKeyDown(Keys.Escape))
            Exit();

        // TODO: Add your update logic here

        foreach (var UpdateVar in _updateables)
        {
            UpdateVar.Update(gameTime);
        }
        
        base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(Color.DarkRed);

        // TODO: Add your drawing code here
        _spriteBatch.Begin();
        
        foreach (var DrawVar in _drawables)
        {
            DrawVar.Draw(_spriteBatch);
        }
        
        

        string text = "Hello Monogame!";
        _spriteBatch.DrawString(
            oswaldFont,
            text,
            new Vector2(ScreenCenterWidth, 50.0f),
            Color.White,
            MathHelper.ToRadians(0.0f),
            new Vector2(oswaldFont.MeasureString(text).X * 0.5f, oswaldFont.MeasureString(text).Y * 0.5f),
            1.0f,
            SpriteEffects.None,
            0
            );
        
        _spriteBatch.End();
        base.Draw(gameTime);
    }
}