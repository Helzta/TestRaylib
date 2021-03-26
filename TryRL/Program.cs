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
            Player.initPlayers();
            Teams.initTeams();
            platform.PrintHubMenu();
        }
    }
}
