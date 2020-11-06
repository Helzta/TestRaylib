using System;
using System.Collections.Generic;
using System.IO;
using Raylib_cs;

namespace TryRL
{
    class Program
    {
        static void Main(string[] args)
        {
            Raylib.InitWindow(800,600, "Hello World!");
            while(!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();
      
                Raylib.ClearBackground(Color.WHITE);
      
                Raylib.DrawCircle(100,100,100,Color.MAGENTA);
      
                Raylib.EndDrawing();
            }
        }
    }
}
