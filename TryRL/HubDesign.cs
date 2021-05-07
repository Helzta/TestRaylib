using System;
using Raylib_cs;
using System.Collections.Generic;
using System.Numerics;

namespace TryRL
{
    public class HubDesign
    {
        // static List<HubDesign> rayStuff = new List<HubDesign>();
        public int x {get; set;}
        public int y {get; set;}
        public int w {get; set;}
        public int h {get; set;}
        public string tag {get; set;}
        public bool header = false;
        public HubDesign toUp {get; set;}
        public HubDesign toDown {get; set;}
        public HubDesign toRight {get; set;}
        public HubDesign toLeft {get; set;}
        public List<HubDesign> visable;
        public List<HubDesign> whatTab;

        public Action action;

        // public HubDesign(int x, int y, int w, int h, string tag, bool header = false)
        // {
        //     rayStuff.Add(this);
        //     this.x = x;
        //     this.y = y;
        //     this.w = w;
        //     this.h = h;
        //     this.tag = tag;
        //     this.header = header;
        // }
        public void DrawBox()
        {
            if(header == true)
            {
                Raylib.DrawRectangleGradientEx(new Rectangle(x, y, w, h), Color.VIOLET, Color.DARKPURPLE, Color.DARKPURPLE , Color.DARKPURPLE);
                Raylib.DrawRectangleLines(x, y, w, h, Color.BLACK);
                Raylib.DrawText(tag, x + 10, y + 10, 30, Color.YELLOW);
            }
            else
            {
                Raylib.DrawRectangleGradientEx(new Rectangle(x, y, w, h), Color.BLUE, Color.DARKBLUE, Color.DARKBLUE , Color.DARKBLUE);
                Raylib.DrawRectangleLines(x, y, w, h, Color.BLACK);
                Raylib.DrawText(tag, x + 15, y + 15, 30, Color.ORANGE);
            }
            {
                // smoll
                // Raylib.DrawRectangle(x, y, w, h, Color.SKYBLUE);
                // Raylib.DrawRectangleLines(x, y, w, h, Color.BLACK);
                // Raylib.DrawText(tag, x + 15, y + 15, 30, Color.ORANGE);

                // bick
                // Raylib.DrawRectangle(x -10, y -10, w +20, h +20, Color.SKYBLUE);
                // Raylib.DrawRectangleLines(x -10, y -10, w +20, h +20, Color.BLACK);
                // Raylib.DrawText(tag, x, y, 50, Color.ORANGE);
            }
        }
        public void DrawTab()
        {
            Raylib.DrawRectangleGradientEx(new Rectangle(x, y, w, h), Color.MAGENTA, Color.VIOLET, Color.DARKPURPLE , Color.VIOLET);
            Raylib.DrawRectangleLines(x, y, w, h, Color.BLACK);
            Raylib.DrawText(tag, x + 10, y + 10, 30, Color.YELLOW);
        }
        static public void currentBox(HubDesign current)
        {
            if(current.header == true)
            {
                Raylib.DrawRectangleGradientEx(new Rectangle(current.x, current.y, current.w, current.h), Color.MAGENTA, Color.VIOLET, Color.DARKPURPLE , Color.VIOLET);
                Raylib.DrawRectangleLines(current.x, current.y, current.w, current.h, Color.BLACK);
                Raylib.DrawText(current.tag, current.x + 10, current.y + 10, 30, Color.YELLOW);
                Raylib.DrawLineEx(new Vector2(current.x + 10, current.y + current.h - 10), new Vector2(current.x + current.w - 5, current.y + current.h - 10), 5, Color.YELLOW);
            }
            else
            {
                Raylib.DrawRectangleGradientEx(new Rectangle(current.x -10, current.y -10, current.w +20, current.h +20), Color.SKYBLUE, Color.BLUE, Color.DARKBLUE , Color.BLUE);
                Raylib.DrawRectangleLines(current.x -10, current.y -10, current.w +20, current.h +20, Color.BLACK);
                Raylib.DrawText(current.tag, current.x, current.y, 45, Color.ORANGE);
            }
        }   
    }
}