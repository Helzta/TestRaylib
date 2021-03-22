using System;
using Raylib_cs;

namespace TryRL
{
    public class platform
    {
        static public void printHubMenu()
        {
            int nextDay = 0;
            bool gameDay = false;
            DateTime dtStart = new DateTime(2020, 6, 1);
            DateTime dtCurrent = dtStart.AddDays(nextDay);
            Raylib.InitWindow(1200,750, "");
            Raylib.SetTargetFPS(60);
            gameDesign play = new gameDesign(true, true, false, 0, (int) 20, (int) 140, (int) 540, (int) 190, mainHubOpt.central, "Play Game", false);
            gameDesign simD = new gameDesign(true, true, false, 0, (int) 20, (int) 140, (int) 540, (int) 190, mainHubOpt.central, "Simulate", true);
            gameDesign news = new gameDesign(true, true, true, 3, (int) 580, (int) 140, (int) 600, (int) 340, mainHubOpt.central, "News", false);
            gameDesign cHubs = new gameDesign(true, false, true, 2, (int) 20, (int) 350, (int) 260, (int) 380, mainHubOpt.central, "Squad Hub", false);
            gameDesign cTableStats = new gameDesign(true, false, true, 2, (int) 300, (int) 350, (int) 260, (int) 380, mainHubOpt.central, "Table", false);
            gameDesign cTraining = new gameDesign(true, false, true, 2, (int) 580, (int) 500, (int) 290, (int) 230, mainHubOpt.central, "Training", false);
            gameDesign cPlayerMsg = new gameDesign(true, false, false, 2, (int) 890, (int) 500, (int) 290, (int) 230, mainHubOpt.central, "Player Message", false);
            string screen = "centralHub";
            while(!Raylib.WindowShouldClose())
            {
                if (screen == "centralHub")
                {
                    if(simD.current == true)
                    {
                        if(Raylib.IsKeyPressed(KeyboardKey.KEY_W))
                        {
                            simD.current = false;
                            //centralTab.current = true;
                        }
                        if(Raylib.IsKeyPressed(KeyboardKey.KEY_A))
                        {
                            simD.current = false;
                            //trophy.current = true;
                            screen = "My Club";
                        }
                        if(Raylib.IsKeyPressed(KeyboardKey.KEY_S))
                        {
                            simD.current = false;
                            cHubs.current = true;
                        }
                        if(Raylib.IsKeyPressed(KeyboardKey.KEY_D))
                        {
                            simD.current = false;
                            news.current = true;
                        }
                    }
                    else if(play.current == true)
                    {
                        if(Raylib.IsKeyPressed(KeyboardKey.KEY_W))
                        {
                            play.current = false;
                            //centralTab.current = true;
                        }
                        if(Raylib.IsKeyPressed(KeyboardKey.KEY_A))
                        {
                            play.current = false;
                            //trophy.current = true;
                            screen = "My Club";
                        }
                        if(Raylib.IsKeyPressed(KeyboardKey.KEY_S))
                        {
                            play.current = false;
                            cHubs.current = true;
                        }
                        if(Raylib.IsKeyPressed(KeyboardKey.KEY_D))
                        {
                            play.current = false;
                            news.current = true;
                        }
                    }
                    
                    else if(news.current == true)
                    {
                        if(Raylib.IsKeyPressed(KeyboardKey.KEY_W))
                        {
                            news.current = false;
                            //centralTab.current = true;
                        }
                        if(Raylib.IsKeyPressed(KeyboardKey.KEY_A))
                        {
                            news.current = false;
                            if (gameDay == false)
                            {
                                simD.current = true;
                            }
                            else
                            {
                                play.current = true;
                            }
                        }
                        if(Raylib.IsKeyPressed(KeyboardKey.KEY_S))
                        {
                            news.current = false;
                            cTraining.current = true;
                        }
                        if(Raylib.IsKeyPressed(KeyboardKey.KEY_D))
                        {
                            news.current = false;
                            //lineUp.current = true;
                            screen = "Squad";
                        }
                        
                    }
                    else if(cHubs.current == true)
                    {
                        if(Raylib.IsKeyPressed(KeyboardKey.KEY_W))
                        {
                            cHubs.current = false;
                            if (gameDay == false)
                            {
                                simD.current = true;
                            }
                            else
                            {
                                play.current = true;
                            }
                        }
                        if(Raylib.IsKeyPressed(KeyboardKey.KEY_A))
                        {
                            cHubs.current = false;
                            //motto.current = true;
                            screen = "My Club";
                        }
                        if(Raylib.IsKeyPressed(KeyboardKey.KEY_D))
                        {
                            cHubs.current = false;
                            cTableStats.current = true;
                        }
                    }
                    else if(cTableStats.current == true)
                    {
                        if(Raylib.IsKeyPressed(KeyboardKey.KEY_W))
                        {
                            cTableStats.current = false;
                            if (gameDay == false)
                            {
                                simD.current = true;
                            }
                            else
                            {
                                play.current = true;
                            }
                        }
                        if(Raylib.IsKeyPressed(KeyboardKey.KEY_A))
                        {
                            cTableStats.current = false;
                            cHubs.current = true;
                        }
                        if(Raylib.IsKeyPressed(KeyboardKey.KEY_D))
                        {
                            cTableStats.current = false;
                            cTraining.current = true;
                        }
                    }
                    else if(cTraining.current == true)
                    {
                        if(Raylib.IsKeyPressed(KeyboardKey.KEY_W))
                        {
                            cTraining.current = false;
                            news.current = true;
                        }
                        if(Raylib.IsKeyPressed(KeyboardKey.KEY_A))
                        {
                            cTraining.current = false;
                            cTableStats.current = true;
                        }
                        if(Raylib.IsKeyPressed(KeyboardKey.KEY_D))
                        {
                            cTraining.current = false;
                            cPlayerMsg.current = true;
                        }
                    }
                    else if(cPlayerMsg.current == true)
                    {
                        if(Raylib.IsKeyPressed(KeyboardKey.KEY_W))
                        {
                            cPlayerMsg.current = false;
                            news.current = true;
                        }
                        if(Raylib.IsKeyPressed(KeyboardKey.KEY_A))
                        {
                            cPlayerMsg.current = false;
                            cTraining.current = true;
                        }
                        if(Raylib.IsKeyPressed(KeyboardKey.KEY_D))
                        {
                            cPlayerMsg.current = false;
                            //lineUp.current = true;
                            screen = "Squad";
                        }
                    }
                }
                gameDesign.updateGameHubs();
                
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.DARKBLUE);

                gameDesign.drawGameHubs();

                Raylib.EndDrawing();
            }
        }
    }
}
