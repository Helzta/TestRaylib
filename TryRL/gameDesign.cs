using System;
using Raylib_cs;
using System.Collections.Generic;
using System.Numerics;
using System.IO;

namespace TryRL
{
    public class gameDesign
    {
        static List<gameDesign> structures = new List<gameDesign>();
        public bool isHeader;
        public bool scrlLeft;
        public bool scrlMid;
        public bool scrlRight;
        public int scrlAmnt;
        public int sX;
        public int sY;
        public int sW;
        public int sH;
        public string name;
        public bool current {get; set;}
        public bool isShowing;
        public gameDesign(int sX, int sY, int sW, int sH, string name, bool scrlLeft = false, int scrlAmnt = 0, bool current = false, bool isHeader = false, bool isShowing = false, bool scrlMid = false, bool scrlRight = false)
        {
            structures.Add(this);
            this.scrlLeft = scrlLeft;
            this.scrlMid = scrlMid;
            this.scrlRight = scrlRight;
            this.sX = sX;
            this.sY = sY;
            this.sW = sW;
            this.sH = sH;
            this.scrlAmnt = scrlAmnt;
            this.name = name;
            this.current = current;
            this.isShowing = isShowing;
            this.isHeader = isHeader;
        }
        // Big box
        // Raylib.DrawRectangle(sX -10, sY -10, sW +20, sH +20, Color.SKYBLUE);
        // Raylib.DrawRectangleLines(sX -10, sY -10, sW +20, sH +20, Color.BLACK);
        // Raylib.DrawText(name, sX, sY, 50, Color.ORANGE);
        
        // Little box
        // Raylib.DrawRectangle(sX, sY, sW, sH, Color.SKYBLUE);
        // Raylib.DrawRectangleLines(sX, sY, sW, sH, Color.BLACK);
        // Raylib.DrawText(name, sX + 15, sY + 15, 30, Color.ORANGE);

        // 2 scroll
        // Raylib.DrawCircle((sW / 2) + sX + ((sW / 6)), sY + sH - 30, 15, Color.BLUE);
        // Raylib.DrawCircle((sW / 2) + sX - ((sW / 6)), sY + sH - 30, 15, Color.BLUE);

        // 3 scroll
        // Raylib.DrawCircle((sW / 2) + sX, sY + sH - 30, 15, Color.BLUE);
        // Raylib.DrawCircle((sW / 2) + sX - ((sW / 6)), sY + sH - 30, 15, Color.BLUE);
        // Raylib.DrawCircle((sW / 2) + sX + ((sW / 6)), sY + sH - 30, 15, Color.BLUE);
        public void drawGameHub()
        {
            Font f1 = Raylib.LoadFont("resources/fonts/alagard.png");
            if (current == true && isHeader == true)
            {
                Raylib.DrawRectangle(sX, sY, sW, sH, Color.SKYBLUE);
                Raylib.DrawRectangleLines(sX, sY, sW, sH, Color.BLACK);
                Raylib.DrawTextEx(f1, name,new Vector2(sX + 5, sY + 10), 30, 2, Color.ORANGE);
                Raylib.DrawLineEx(new Vector2(sX + 5, sY + sH - 10), new Vector2(sX + sW - 5, sY + sH - 10), 5, Color.ORANGE);
            }
            else if(isHeader == true)
            {
                Raylib.DrawRectangle(sX, sY, sW, sH, Color.SKYBLUE);
                Raylib.DrawRectangleLines(sX, sY, sW, sH, Color.BLACK);
                Raylib.DrawTextEx(f1, name,new Vector2(sX + 5, sY + 10), 30, 2, Color.ORANGE);
            }
            else if (current == true)
            {
                Raylib.DrawRectangle(sX -10, sY -10, sW +20, sH +20, Color.SKYBLUE);
                Raylib.DrawRectangleLines(sX -10, sY -10, sW +20, sH +20, Color.BLACK);
                Raylib.DrawTextEx(f1, name,new Vector2(sX,sY), 50, 2, Color.ORANGE);
            }
            else if(isShowing == true)
            {
                Raylib.DrawRectangle(sX, sY, sW, sH, Color.SKYBLUE);
                Raylib.DrawRectangleLines(sX, sY, sW, sH, Color.BLACK);
                Raylib.DrawTextEx(f1, name,new Vector2(sX + 15, sY + 15), 30, 2, Color.ORANGE);
            }
            if (scrlRight == true && isShowing == true)
            {
                if (scrlAmnt == 2)
                {
                    Raylib.DrawCircle((sW / 2) + sX + ((sW / 6)), sY + sH - 30, 15, Color.DARKBLUE);
                    Raylib.DrawCircle((sW / 2) + sX - ((sW / 6)), sY + sH - 30, 15, Color.BLUE);
                }
                else
                {
                    Raylib.DrawCircle((sW / 2) + sX, sY + sH - 30, 15, Color.BLUE);
                    Raylib.DrawCircle((sW / 2) + sX - ((sW / 6)), sY + sH - 30, 15, Color.BLUE);
                    Raylib.DrawCircle((sW / 2) + sX + ((sW / 6)), sY + sH - 30, 15, Color.DARKBLUE);
                }
            }
            else if (scrlMid == true && isShowing == true)
            {
                Raylib.DrawCircle((sW / 2) + sX, sY + sH - 30, 15, Color.DARKBLUE);
                Raylib.DrawCircle((sW / 2) + sX - ((sW / 6)), sY + sH - 30, 15, Color.BLUE);
                Raylib.DrawCircle((sW / 2) + sX + ((sW / 6)), sY + sH - 30, 15, Color.BLUE);
            }
            else if (scrlLeft == true && isShowing == true)
            {
                if (scrlAmnt == 2)
                {
                    Raylib.DrawCircle((sW / 2) + sX + ((sW / 6)), sY + sH - 30, 15, Color.BLUE);
                    Raylib.DrawCircle((sW / 2) + sX - ((sW / 6)), sY + sH - 30, 15, Color.DARKBLUE);
                }
                else
                {
                    Raylib.DrawCircle((sW / 2) + sX, sY + sH - 30, 15, Color.BLUE);
                    Raylib.DrawCircle((sW / 2) + sX - ((sW / 6)), sY + sH - 30, 15, Color.DARKBLUE);
                    Raylib.DrawCircle((sW / 2) + sX + ((sW / 6)), sY + sH - 30, 15, Color.BLUE);
                }
            }
        }
        public static void drawGameHubs()
        {
            foreach (gameDesign gD in structures)
            {
                gD.drawGameHub();
            }
        }
    }
}