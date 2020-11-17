using System;
using Raylib_cs;
using System.Collections.Generic;
using System.IO;

namespace TryRL
{
    public class player
    {
        static List<player> players = new List<player>();
        public string name = "";
        public string number = "";
        public string team = "";
        public float x = 0;
        public float y = 0;

        public player(string name, string number, float x, float y)
        {
            players.Add(this);
            this.name = name;
            this.number = number;
            this.x = x;
            this.y = y;
        }

        public void Draw()
        {
            Raylib.DrawCircle((int) x, (int) y, 40, Color.BLACK);
            if(number.Length == 1)
            {
                Raylib.DrawText(number , (int) x - 10, (int) y - 15, 40, Color.ORANGE);
            }
            else
            {
                Raylib.DrawText(number , (int) x - 17, (int) y - 15, 40, Color.ORANGE);
            }
        }

        public static void DrawAll()
        {
            foreach (player p in players)
                {
                    p.Draw();                    
                }
        }
    }
}
