using System;
using Raylib_cs;
using System.Collections.Generic;
using System.IO;

namespace TryRL
{
    public enum mainHubOpt {
        central,
        transfer,
        squad,
        office,
        myClub,
        header
    }
    public class gameDesign
    {
        static int nextDay = 0;
        static bool gameDay = false;
        static DateTime dtStart = new DateTime(2020, 6, 1);
        static DateTime dtCurrent = dtStart.AddDays(nextDay);
        static List<gameDesign> structures = new List<gameDesign>(); 
        public bool up;
        public bool dwn;
        public bool scrlSide;
        public int scrlAmnt;
        public float sX;
        public float sY;
        public float sW;
        public float sH;
        public string name;
        public bool current;
        public mainHubOpt mHO;
        public gameDesign(bool up, bool dwn, bool scrlSide, int scrlAmnt, float sX, float sY, float sW, float sH, mainHubOpt mHO, string name, bool current = false)
        {
            structures.Add(this);
            this.up = up;
            this.dwn = dwn;
            this.scrlSide = scrlSide;
            this.sX = sX;
            this.sY = sY;
            this.sW = sW;
            this.sH = sH;
            this.scrlAmnt = scrlAmnt;
            this.mHO = mHO;
            this.name = name;
            this.current = current;
        }
        public void drawGameHub()
        {
            Raylib.ClearBackground(Color.DARKBLUE);
            if (current == true)
            {
                Raylib.DrawRectangle((int)sX -10, (int) sY -10, (int) sW +20, (int) sH +20, Color.SKYBLUE);
                Raylib.DrawRectangleLines((int)sX -10, (int) sY -10, (int) sW +20, (int) sH +20, Color.BLACK);
                Raylib.DrawText(name, (int)sX, (int)sY, 50, Color.ORANGE);
            }
            else 
            {
                Raylib.DrawRectangle((int)sX, (int) sY, (int) sW, (int) sH, Color.SKYBLUE);
                Raylib.DrawRectangleLines((int)sX, (int) sY, (int) sW, (int) sH, Color.BLACK);
                Raylib.DrawText(name, (int)sX + 15, (int)sY + 15, 30, Color.ORANGE);
            }
            
            if (scrlSide == true)
            {
                if (scrlAmnt == 2)
                {
                    Raylib.DrawCircle(((int)sW / 2) + (int) sX + (((int)sW / 6)), (int) sY + (int) sH - 30, 15, Color.BLUE);
                    Raylib.DrawCircle(((int)sW / 2) + (int) sX - (((int)sW / 6)), (int) sY + (int) sH - 30, 15, Color.BLUE);
                }
                else if (scrlAmnt == 3)
                {
                    Raylib.DrawCircle(((int)sW / 2) + (int) sX, (int) sY + (int) sH - 30, 15, Color.BLUE);
                    Raylib.DrawCircle(((int)sW / 2) + (int) sX - (((int)sW / 6)), (int) sY + (int) sH - 30, 15, Color.BLUE);
                    Raylib.DrawCircle(((int)sW / 2) + (int) sX + (((int)sW / 6)), (int) sY + (int) sH - 30, 15, Color.BLUE);
                }
                else{}
            }
        }
        public static void drawGameHubs()
        {
            foreach (gameDesign gD in structures)
            {
                gD.drawGameHub();
            }
        }

        public void updateGameHub()
        {
            if (current == true && Raylib.IsKeyPressed(KeyboardKey.KEY_ENTER))
            {
                if (name == "Play Game")
                {
                    playGame();
                }
                
                else if (name == "Sim Game")
                {
                    simGame();
                }

                else if (name == "Simulate")
                {
                    simDate();
                }
                
                else if (name == "News")
                {
                    news();
                }

                else if (name == "Squad Hub")
                {
                    squadHub();
                }

                else if (name == "Table")
                {
                    table();
                }

                else if (name == "Training")
                {
                    training();
                }

                else if (name == "Player Message")
                {
                    playerMsg();
                }
            }
        }

        public static void updateGameHubs()
        {
            foreach (gameDesign gD in structures)
            {
                gD.updateGameHub();
            }
        }
    }
}