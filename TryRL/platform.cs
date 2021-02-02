using System;
using Raylib_cs;

namespace TryRL
{
    public class platform
    {
        static public void printHubMenu()
        {
            Raylib.InitWindow(1200,750, "");
            Raylib.SetTargetFPS(60);
            
            gameDesign play = new gameDesign(true, true, false, 0, (int) 20, (int) 140, (int) 260, (int) 190, mainHubOpt.central, "Play Game");
            gameDesign simG = new gameDesign(true, true, false, 0, (int) 300, (int) 140, (int) 260, (int) 190, mainHubOpt.central, "Sim Game");
            gameDesign simD = new gameDesign(true, true, false, 0, (int) 20, (int) 140, (int) 540, (int) 190, mainHubOpt.central, "Simulate", true);
            gameDesign news = new gameDesign(true, true, true, 3, (int) 580, (int) 140, (int) 600, (int) 340, mainHubOpt.central, "News");
            gameDesign cHubs = new gameDesign(true, false, true, 2, (int) 20, (int) 350, (int) 260, (int) 380, mainHubOpt.central, "Squad Hub");
            gameDesign cTableStats = new gameDesign(true, false, true, 2, (int) 300, (int) 350, (int) 260, (int) 380, mainHubOpt.central, "Table");
            gameDesign cTraining = new gameDesign(true, false, true, 2, (int) 580, (int) 500, (int) 290, (int) 230, mainHubOpt.central, "Training");
            gameDesign cSmth = new gameDesign(true, false, false, 2, (int) 890, (int) 500, (int) 290, (int) 230, mainHubOpt.central, "Player Message");

            while(!Raylib.WindowShouldClose())
            {
                gameDesign.updateGameHubs();
                
                Raylib.BeginDrawing();

                gameDesign.drawGameHubs();

                Raylib.EndDrawing();
            }
            
        }
    }
}
