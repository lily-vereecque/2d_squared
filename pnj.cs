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
            if (Math.Abs(player.Pos_Player.X - Pos_Pnj.X) > 64 || Math.Abs(player.Pos_Player.Y - Pos_Pnj.Y) > 64)
                return;

            //The player is 1x2 tiles, and 0,0 is the top left.

            bool E_keypad_down = player.state.IsKeyDown(Keys.E);
            bool E_keypad_Up = player.state.IsKeyUp(Keys.E);

            if (E_keypad_down)
            {
                if (E_keypad_Up)
                {
                    player.Can_Move = false;
                    is_player_ask = true;
                }
            }
        }
        public void speak(Player_c player)
        {
            bool Space_Keypad = player.state.IsKeyDown(Keys.Space);

            if (is_player_ask == true)
            {
                //while (arrivé au dernier message)
                if (Space_Keypad)
                {
                    //change le message;
                }
            }
        }
    }
}   