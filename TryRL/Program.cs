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
            bool gameOn = true;
            Player.initPlayers();
            while(gameOn)
            {
                platform.PrintHubMenu();
            }
        }
    }
}
