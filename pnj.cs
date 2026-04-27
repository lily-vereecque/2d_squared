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

    internal class pnj_c(string new_name)
    {
        public string Name = new_name;
        public bool is_player_ask =  false;
        public Vector2 Pos_Pnj = new Vector2(0f, 0f);
        public KeyboardState state = Keyboard.GetState();
        public Texture2D Sprite_Pnj;
        public Color Color_Pnj;
        public Texture2D message;
        public Color Color_message;

        public void is_asking(Player_c player)
        {
            if (Math.Abs(player.Pos_Player.X - Pos_Pnj.X) > 128 && Math.Abs(player.Pos_Player.Y - Pos_Pnj.Y) > 128)
                return;

            bool E_keypad_down = player.state.IsKeyDown(Keys.E);

            if (E_keypad_down)
            {
                player.Can_Move = false;
                is_player_ask = true;
            }
        }
        public void speak(Player_c player)
        {
            bool Space_Keypad = player.state.IsKeyDown(Keys.Space);

            if (is_player_ask)
            {
                if (Space_Keypad)
                {
                    Console.WriteLine("Hello, Adventurer!");
                    Console.WriteLine("I am Dagobert, the greatest king of all.");
                    Console.WriteLine("I have a quest for you, if you want to accept it.");
                    Console.WriteLine("Well, I had one... Another adventurer took it");
                    Console.WriteLine("I guess you're useless...");
                    Console.WriteLine("Oh well, might as well let you die.");
                    Console.WriteLine("GUARDS!")
                    is_player_ask = false;
                    player.Can_Move = true;   
                }
            }
        }
    }
}   