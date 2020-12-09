using System;
using System.Collections.Generic;
using System.IO;
using Raylib_cs;

namespace TryRL
{
    class Program
    {
        static void printHubMenu()
        {
            Raylib.InitWindow(1200,750, "GameHub");
            Raylib.SetTargetFPS(60);

            while(!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.DARKBLUE);
                

                Raylib.EndDrawing();
            }
            
        }
        static void Main(string[] args)
        {
            bool gameOn = true;

            while(gameOn)
            {
                printHubMenu();
            }
        }
    }
}
