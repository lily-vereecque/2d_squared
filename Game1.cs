using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace _2d_squared;

public class Game1 : Game
{
    private GraphicsDeviceManager _graphics;
    private SpriteBatch _spriteBatch;
    private Player_c player = new Player_c("Hero");
    private pnj_c dagobert = new pnj_c("dagobert");
    public Game1()
    {
        _graphics = new GraphicsDeviceManager(this);
        Content.RootDirectory = "Content";
        IsMouseVisible = true;
    }

    protected override void Initialize()
    {
        // TODO: Add your initialization logic here
        _graphics.PreferredBackBufferWidth = (int)(Math.Ceiling(30f * 32));
        _graphics.PreferredBackBufferHeight = (int)(Math.Ceiling(30f * 32));
        _graphics.ApplyChanges();
        base.Initialize();
    }

    protected override void LoadContent()
    {
        //_spriteBatch_pnj = new SpriteBatch(GraphicsDevice);
        _spriteBatch = new SpriteBatch(GraphicsDevice);
        player.Sprite = Content.Load<Texture2D>("Player");
        dagobert.Sprite_Pnj = Content.Load<Texture2D>("dagobert_pnj");
        Content.Load<Texture2D>("d6");
    }

    protected override void Update(GameTime gameTime)
    {
        if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
            Exit();

        player.state = Keyboard.GetState();
        player.Move_player(player, gameTime);

        base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(Color.CornflowerBlue);
        _spriteBatch.Begin(samplerState: SamplerState.PointClamp);

        _spriteBatch.Draw(dagobert.Sprite_Pnj, new Rectangle(192, 128, 64, 64), Color.White);
        _spriteBatch.Draw(Content.Load<Texture2D>("d6"), new Rectangle(960-128, 0, 128, 128), Color.White);
        _spriteBatch.Draw(Content.Load<Texture2D>("d6"), new Rectangle(960-128, 128, 128, 128), Color.Red);
        _spriteBatch.Draw(player.Sprite, new Rectangle((int)player.Pos_Player.X, (int)player.Pos_Player.Y, 32, 64), Color.White);

        _spriteBatch.End();
        base.Draw(gameTime);
    }
}
