using System;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Vector2 = Microsoft.Xna.Framework.Vector2;

namespace _2d_squared;

public class Player : Game1
{
    public string Name;
    public int Health;
    public bool Is_Alive;
    public float Speed;
    public Vector2 Pos_Player;
    public Texture2D Sprite;
    public Color Color_Player;
    public void Player(string new_name)
    {
        Name = new_name;
        Health = 100;
        Is_Alive = true;
        Pos_Player = new Vector2(700f, 250f);
        Speed = 1f;
    }

    public void move_player(Player player)
    {
        if ()
            player.Pos_Player.X += player.Speed;
        if()
            player.Pos_Player.X -= player.Speed;
        if ()
            player.Pos_Player.Y += player.Speed;
        if()
            player.Pos_Player.Y -= player.Speed;
    }
}