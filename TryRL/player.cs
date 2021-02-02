using System;
using Raylib_cs;
using System.Collections.Generic;
using System.IO;

namespace TryRL
{
    public enum roles {
        setter,
        oppositeHitter,
        outsideHitter,
        libero,
        middleBlocker,
        defensiveSpecialist
    }
    public class player
    {
        static Random generator = new Random();
        static List<player> players = new List<player>();
        //public string name = "";
        public string surName = "";
        public string number = "";
        //public string team = "";
        public float x = 0;
        public float y = 0;
        /*public int schoolYear = 0;
        public int age = 0;
        public string arm = "";
        public float height = 0;
        public float weight = 0;
        public float marking = 0;
        public float blocking = 0;
        public float reading = 0;
        public float dig = 0;
        public float timing = 0;
        public float controll = 0;
        public float reaction = 0;
        public float atkP = 0;
        public float defP = 0;
        public float vision = 0;
        public float coolness = 0;
        public float sett = 0;
        public float uaPass = 0;
        public float oaPass = 0;
        public float stamina = 0;
        public float balance = 0;
        public float speed = 0;
        public float mobility = 0;
        public float elasticity = 0;
        public float power = 0;
        public float spike = 0;
        public float curve = 0;
        public float serve = 0;
        public float directly = 0;*/

        public player(string surName, string number, float x, float y)
        {
            players.Add(this);
            this.surName = surName;
            this.number = number;
            this.x = x;
            this.y = y;
        }

        public void Draw()
        {
            Raylib.DrawCircle((int) x, (int) y, 40, Color.BLACK);
            if(number.Length == 1)
            {
                Raylib.DrawText(number , (int) x - 10, (int) y - 15, 40, Color.YELLOW);
            }
            else
            {
                Raylib.DrawText(number , (int) x - 17, (int) y - 15, 40, Color.YELLOW);
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
