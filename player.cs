using System;
using System.Collections;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Vector2 = Microsoft.Xna.Framework.Vector2;

namespace _2d_squared{

    internal class Player_c(string new_name)
        {
        public string Name = new_name;
        public int Health = 100;
        public bool Is_Alive = true;
        public Vector2 Pos_Player = new Vector2(0f, 0f);
        public float Speed = 32f;
        public float MoveCooldown = 0f;
        public KeyboardState state = Keyboard.GetState();
        public Texture2D Sprite;
        public Color Color_Player;
        public bool Can_Move = true;

        public void Move_player(Player_c player, GameTime gameTime)
        {
            player.MoveCooldown -= (float)gameTime.ElapsedGameTime.TotalSeconds;

            if (player.MoveCooldown > 0f && player.Can_Move == false)
                return;

            //The player is 1x2 tiles, and 0,0 is the top left.
            bool left = player.state.IsKeyDown(Keys.Left)
                && !player.Collision(player.Pos_Player.X - player.Speed, player.Pos_Player.Y)
                && !player.Collision(player.Pos_Player.X - player.Speed, player.Pos_Player.Y - 32f);
            bool right = player.state.IsKeyDown(Keys.Right)
                && !player.Collision(player.Pos_Player.X + player.Speed, player.Pos_Player.Y)
                && !player.Collision(player.Pos_Player.X + player.Speed, player.Pos_Player.Y - 32f);
            bool up = player.state.IsKeyDown(Keys.Up)
                && !player.Collision(player.Pos_Player.X, player.Pos_Player.Y + player.Speed);
            bool down = player.state.IsKeyDown(Keys.Down)
                && !player.Collision(player.Pos_Player.X, player.Pos_Player.Y - player.Speed - 64f);

            if (left) player.Pos_Player.X -= player.Speed;
            if (right) player.Pos_Player.X += player.Speed;
            if (up) player.Pos_Player.Y -= player.Speed;
            if (down) player.Pos_Player.Y += player.Speed;

            player.Pos_Player.X = Math.Clamp(player.Pos_Player.X, 0f, 960f - 32f);
            player.Pos_Player.Y = Math.Clamp(player.Pos_Player.Y, 0f, 540f - 64f);
            if (left || right || up || down)
            {
                player.MoveCooldown = (1f / 60f * 5f);
            }
        }

        public bool Collision(float x, float y)
        {
            //Logic to be implemented later.
            return false;
        }
    }
}