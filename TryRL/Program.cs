using System;
using System.Collections.Generic;
using System.IO;
using Raylib_cs;

namespace TryRL
{
    class Program
    {
        static int nextDay = 0;
        static bool gameDay = false;
        static DateTime dtStart = new DateTime(2020, 6, 1);
        static DateTime dtCurrent = dtStart.AddDays(nextDay);        
        static void Main(string[] args)
        {
            bool gameOn = true;

            while(gameOn)
            {
                platform.printHubMenu();
            }
        }
    }
}
