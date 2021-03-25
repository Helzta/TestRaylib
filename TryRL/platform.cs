using System;
using Raylib_cs;
using System.Numerics;

namespace TryRL
{
    public class platform
    {
        public enum GameScreen 
        {
            Central,
            Transfer,
            Squad,
            Office,
            MyClub,
            Start
        }
        static public void PrintHubMenu()
        {
            int nextDay = 0;
            bool gameDay = false;
            Raylib.InitWindow(1200,750, "");
            Raylib.SetTargetFPS(60);
 
            HubDesign centralTab = new HubDesign(20, 70, 216, 50, "Central", false, 0, false, true);
            HubDesign squadTab = new HubDesign(256, 70, 216, 50, "Squad", false, 0, false, true);
            HubDesign transferTab = new HubDesign(492, 70, 216, 50, "Transfer", false, 0, false, true);
            HubDesign officeTab = new HubDesign(718, 70, 216, 50, "Office", false, 0, false, true);
            HubDesign myClubTab = new HubDesign(954, 70, 216, 50, "My Club", false, 0, false, true);
            
            HubDesign play = new HubDesign(20, 140, 540, 190, "Play Game");
            HubDesign simulateDay = new HubDesign(20, 140, 540, 190, "Simulate Day", false, 0, true);
            HubDesign news = new HubDesign(580, 140, 600, 340, "News", true, 3);
            HubDesign cHubs = new HubDesign(20, 350, 260, 380, "Squad Hub", true, 2);
            HubDesign league = new HubDesign(300, 350, 260, 380, "Table", true, 2);
            HubDesign cTraining = new HubDesign(580, 500, 290, 230, "Training");
            HubDesign cInbox = new HubDesign(890, 500, 290, 230, "Inbox", true, 2);

            HubDesign lineUp = new HubDesign(20, 140, 590, 590, "Rotational 7");
            HubDesign training = new HubDesign(630, 530, 550, 200, "Training");
            HubDesign squadHub = new HubDesign(630, 140, 265, 175, "Squad Hub");
            HubDesign youthSquad = new HubDesign(915, 140, 265, 175, "Academy");
            HubDesign teamSheet = new HubDesign(630, 335, 550, 175, "Team Rotation");

            HubDesign serachPlayer = new HubDesign(20, 140, 275, 285, "Search\n Players");
            HubDesign transferHub = new HubDesign(315, 140, 275, 285, "Transfer\n Hub");
            HubDesign transferHistory = new HubDesign(610, 140, 275, 285, "Transfer\n History");
            HubDesign finances = new HubDesign(905, 140, 275, 285, "Financial");
            HubDesign scouts = new HubDesign(905, 445, 275, 285, "Scout\n Network");
            HubDesign recommended = new HubDesign(20, 445, 865, 285, "Scouted Players");

            HubDesign inbox = new HubDesign(20, 140, 570, 285, "Inbox", true, 2);
            HubDesign vision = new HubDesign(610, 140, 570, 285, "Vision and\n Expectations");
            HubDesign contracts = new HubDesign(20, 445, 550, 285, "Player \n Contracts");
            HubDesign manageStaff = new HubDesign(590, 445, 285, 285, "Staff");
            HubDesign browseJobs = new HubDesign(895, 445, 285, 285, "Browse \n Jobs");

            HubDesign kits = new HubDesign(20, 140, 570,285, "Game Kits");
            HubDesign arrangeFriendlies = new HubDesign(610, 140, 570, 285, "Arrange Friendly");
            HubDesign trophies = new HubDesign(20, 445, 320, 285, "Club History");
            HubDesign otherLeagues = new HubDesign(360, 445, 400, 285, "Other \n Leagues");
            HubDesign top25 = new HubDesign(780, 445, 400, 285, "All Statistics");
            GameScreen screen = GameScreen.Central;
            while(!Raylib.WindowShouldClose())
            {
                
                DateTime dtStart = new DateTime(2020, 6, 1);
                DateTime dtCurrent = dtStart.AddDays(nextDay);
                string dtString = dtCurrent.ToString("dd MMMM yyyy");
                {
                // WASD buttons
                // if(Raylib.IsKeyPressed(KeyboardKey.KEY_W))
                //         {
                //             .current = false;
                //             .current = true;
                //         }
                //         else if(Raylib.IsKeyPressed(KeyboardKey.KEY_A))
                //         {
                //             .current = false;
                //             .current = true;
                //         }
                //         else if(Raylib.IsKeyPressed(KeyboardKey.KEY_S))
                //         {
                //             .current = false;
                //             .current = true;
                //         }
                //         else if(Raylib.IsKeyPressed(KeyboardKey.KEY_D))
                //         {
                //             .current = false;
                //             .current = true;
                //         }

                // 3 SCRLAMNT
                // else if (.scrlLeft == true)
                //         {
                //             if(Raylib.IsKeyPressed(KeyboardKey.KEY_LEFT))
                //             {
                //                 .scrlLeft = false;
                //                 .scrlRight = true;
                //             }
                //             else if(Raylib.IsKeyPressed(KeyboardKey.KEY_RIGHT))
                //             {
                //                 .scrlLeft = false;
                //                 .scrlMid = true;
                //             }
                //         }
                //         else if (.scrlMid == true)
                //         {
                //             if(Raylib.IsKeyPressed(KeyboardKey.KEY_LEFT))
                //             {
                //                 .scrlMid = false;
                //                 .scrlLeft = true;
                //             }
                //             else if(Raylib.IsKeyPressed(KeyboardKey.KEY_RIGHT))
                //             {
                //                 .scrlMid = false;
                //                 .scrlRight = true;
                //             }
                //         }
                //         else if (.scrlRight == true)
                //         {
                //             if(Raylib.IsKeyPressed(KeyboardKey.KEY_LEFT))
                //             {
                //                 .scrlRight = false;
                //                 .scrlMid = true;
                //             }
                //             else if(Raylib.IsKeyPressed(KeyboardKey.KEY_RIGHT))
                //             {
                //                 .scrlRight = false;
                //                 .scrlLeft = true;
                //             }
                //         }

                // 2 SCRLAMNT
                // else if (.scrlLeft == true)
                //         {
                //             if(Raylib.IsKeyPressed(KeyboardKey.KEY_LEFT) || Raylib.IsKeyPressed(KeyboardKey.KEY_RIGHT))
                //             {
                //                 .scrlLeft = false;
                //                 .scrlRight = true;
                //             }
                //         }
                //         else if (.scrlRight == true)
                //         {
                //             if(Raylib.IsKeyPressed(KeyboardKey.KEY_LEFT) || Raylib.IsKeyPressed(KeyboardKey.KEY_RIGHT))
                //             {
                //                 .scrlRight = false;
                //                 .scrlLeft = true;
                //             }
                //         }
                }
                Raylib.BeginDrawing();
                HubDesign.DrawGameHubs();
                if (screen != GameScreen.Central)
                {
                    news.isShowing = false;
                    cHubs.isShowing = false;
                    league.isShowing = false;
                    cTraining.isShowing = false;
                    cInbox.isShowing = false;
                    simulateDay.isShowing = false;
                    play.isShowing = false;
                }
                if (screen != GameScreen.Squad)
                {
                    lineUp.isShowing = false;
                    training.isShowing = false;
                    squadHub.isShowing = false;
                    youthSquad.isShowing = false;
                    teamSheet.isShowing = false;
                }
                if (screen != GameScreen.Transfer)
                {
                    recommended.isShowing = false;
                    finances.isShowing = false;
                    serachPlayer.isShowing = false;
                    scouts.isShowing = false;
                    transferHistory.isShowing = false;
                    transferHub.isShowing = false;
                }
                if (screen != GameScreen.Office)
                {
                    inbox.isShowing = false;
                    vision.isShowing = false;
                    contracts.isShowing = false;
                    manageStaff.isShowing = false;
                    browseJobs.isShowing = false;
                }
                if (screen != GameScreen.MyClub)
                {
                    kits.isShowing = false;
                    arrangeFriendlies.isShowing = false;
                    trophies.isShowing = false;
                    otherLeagues.isShowing = false;
                    top25.isShowing = false;
                }
                if (screen == GameScreen.Central)
                {
                    if (gameDay == false)
                    {
                        simulateDay.isShowing = true;
                        play.isShowing = false;
                    }
                    else
                    {
                        simulateDay.isShowing = false;
                        play.isShowing = true;
                    }
                    news.isShowing = true;
                    cHubs.isShowing = true;
                    league.isShowing = true;
                    cTraining.isShowing = true;
                    cInbox.isShowing = true;

                    if(simulateDay.isShowing == true && simulateDay.current == false)
                    {
                        Raylib.DrawText(dtString, simulateDay.sX + 15, simulateDay.sY + 45, 20, Color.ORANGE);
                    }
                    if(simulateDay.current == true)
                    {
                        if(Raylib.IsKeyPressed(KeyboardKey.KEY_W))
                        {
                            simulateDay.current = false;
                            centralTab.current = true;
                        }
                        else if(Raylib.IsKeyPressed(KeyboardKey.KEY_ENTER))
                        {
                            nextDay++;
                        }
                        else if(Raylib.IsKeyPressed(KeyboardKey.KEY_A))
                        {
                            simulateDay.current = false;
                            arrangeFriendlies.current = true;
                            screen = GameScreen.MyClub;
                        }
                        else if(Raylib.IsKeyPressed(KeyboardKey.KEY_S))
                        {
                            simulateDay.current = false;
                            cHubs.current = true;
                        }
                        else if(Raylib.IsKeyPressed(KeyboardKey.KEY_D))
                        {
                            simulateDay.current = false;
                            news.current = true;
                        }
                        Raylib.DrawText(dtString, simulateDay.sX, simulateDay.sY + 50, 30, Color.ORANGE);
                    }
                    else if(play.current == true)
                    {
                        if(Raylib.IsKeyPressed(KeyboardKey.KEY_W))
                        {
                            play.current = false;
                            centralTab.current = true;
                        }
                        else if(Raylib.IsKeyPressed(KeyboardKey.KEY_A))
                        {
                            play.current = false;
                            arrangeFriendlies.current = true;
                            screen = GameScreen.MyClub;
                        }
                        else if(Raylib.IsKeyPressed(KeyboardKey.KEY_S))
                        {
                            play.current = false;
                            cHubs.current = true;
                        }
                        else if(Raylib.IsKeyPressed(KeyboardKey.KEY_D))
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
                            centralTab.current = true;
                        }
                        else if(Raylib.IsKeyPressed(KeyboardKey.KEY_A))
                        {
                            news.current = false;
                            if (gameDay == false)
                            {
                                simulateDay.current = true;
                            }
                            else
                            {
                                play.current = true;
                            }
                        }
                        else if(Raylib.IsKeyPressed(KeyboardKey.KEY_S))
                        {
                            news.current = false;
                            cTraining.current = true;
                        }
                        else if(Raylib.IsKeyPressed(KeyboardKey.KEY_D))
                        {
                            news.current = false;
                            lineUp.current = true;
                            screen = GameScreen.Squad;
                        }
                        else if (news.scrlLeft == true)
                        {
                            if(Raylib.IsKeyPressed(KeyboardKey.KEY_LEFT))
                            {
                                news.scrlLeft = false;
                                news.scrlRight = true;
                            }
                            else if(Raylib.IsKeyPressed(KeyboardKey.KEY_RIGHT))
                            {
                                news.scrlLeft = false;
                                news.scrlMid = true;
                            }
                        }
                        else if (news.scrlMid == true)
                        {
                            if(Raylib.IsKeyPressed(KeyboardKey.KEY_LEFT))
                            {
                                news.scrlMid = false;
                                news.scrlLeft = true;
                            }
                            else if(Raylib.IsKeyPressed(KeyboardKey.KEY_RIGHT))
                            {
                                news.scrlMid = false;
                                news.scrlRight = true;
                            }
                        }
                        else if (news.scrlRight == true)
                        {
                            if(Raylib.IsKeyPressed(KeyboardKey.KEY_LEFT))
                            {
                                news.scrlRight = false;
                                news.scrlMid = true;
                            }
                            else if(Raylib.IsKeyPressed(KeyboardKey.KEY_RIGHT))
                            {
                                news.scrlRight = false;
                                news.scrlLeft = true;
                            }
                        }
                    }
                    else if(cHubs.current == true)
                    {
                        if(Raylib.IsKeyPressed(KeyboardKey.KEY_W))
                        {
                            cHubs.current = false;
                            if (gameDay == false)
                            {
                                simulateDay.current = true;
                            }
                            else
                            {
                                play.current = true;
                            }
                        }
                        else if(Raylib.IsKeyPressed(KeyboardKey.KEY_A))
                        {
                            cHubs.current = false;
                            top25.current = true;
                            screen = GameScreen.MyClub;
                        }
                        else if(Raylib.IsKeyPressed(KeyboardKey.KEY_D))
                        {
                            cHubs.current = false;
                            league.current = true;
                        }
                        else if (cHubs.scrlLeft == true)
                        {
                            if(Raylib.IsKeyPressed(KeyboardKey.KEY_LEFT) || Raylib.IsKeyPressed(KeyboardKey.KEY_RIGHT))
                            {
                                cHubs.scrlLeft = false;
                                cHubs.scrlRight = true;
                            }
                        }
                        else if (cHubs.scrlRight == true)
                        {
                            if(Raylib.IsKeyPressed(KeyboardKey.KEY_LEFT) || Raylib.IsKeyPressed(KeyboardKey.KEY_RIGHT))
                            {
                                cHubs.scrlRight = false;
                                cHubs.scrlLeft = true;
                            }
                        }
                    }
                    else if(league.current == true)
                    {
                        if(Raylib.IsKeyPressed(KeyboardKey.KEY_W))
                        {
                            league.current = false;
                            if (gameDay == false)
                            {
                                simulateDay.current = true;
                            }
                            else
                            {
                                play.current = true;
                            }
                        }
                        else if(Raylib.IsKeyPressed(KeyboardKey.KEY_A))
                        {
                            league.current = false;
                            cHubs.current = true;
                        }
                        else if(Raylib.IsKeyPressed(KeyboardKey.KEY_D))
                        {
                            league.current = false;
                            cTraining.current = true;
                        }
                        else if (league.scrlLeft == true)
                        {
                            if(Raylib.IsKeyPressed(KeyboardKey.KEY_LEFT) || Raylib.IsKeyPressed(KeyboardKey.KEY_RIGHT))
                            {
                                league.scrlLeft = false;
                                league.scrlRight = true;
                            }
                        }
                        else if (league.scrlRight == true)
                        {
                            if(Raylib.IsKeyPressed(KeyboardKey.KEY_LEFT) || Raylib.IsKeyPressed(KeyboardKey.KEY_RIGHT))
                            {
                                league.scrlRight = false;
                                league.scrlLeft = true;
                            }
                        }
                    }
                    else if(cTraining.current == true)
                    {
                        if(Raylib.IsKeyPressed(KeyboardKey.KEY_W))
                        {
                            cTraining.current = false;
                            news.current = true;
                        }
                        else if(Raylib.IsKeyPressed(KeyboardKey.KEY_A))
                        {
                            cTraining.current = false;
                            league.current = true;
                        }
                        else if(Raylib.IsKeyPressed(KeyboardKey.KEY_D))
                        {
                            cTraining.current = false;
                            cInbox.current = true;
                        }
                        else if (cTraining.scrlLeft == true)
                        {
                            if(Raylib.IsKeyPressed(KeyboardKey.KEY_LEFT))
                            {
                                cTraining.scrlLeft = false;
                                cTraining.scrlRight = true;
                            }
                            else if(Raylib.IsKeyPressed(KeyboardKey.KEY_RIGHT))
                            {
                                cTraining.scrlLeft = false;
                                cTraining.scrlMid = true;
                            }
                        }
                        else if (cTraining.scrlMid == true)
                        {
                            if(Raylib.IsKeyPressed(KeyboardKey.KEY_LEFT))
                            {
                                cTraining.scrlMid = false;
                                cTraining.scrlLeft = true;
                            }
                            else if(Raylib.IsKeyPressed(KeyboardKey.KEY_RIGHT))
                            {
                                cTraining.scrlMid = false;
                                cTraining.scrlRight = true;
                            }
                        }
                        else if (cTraining.scrlRight == true)
                        {
                            if(Raylib.IsKeyPressed(KeyboardKey.KEY_LEFT))
                            {
                                cTraining.scrlRight = false;
                                cTraining.scrlMid = true;
                            }
                            else if(Raylib.IsKeyPressed(KeyboardKey.KEY_RIGHT))
                            {
                                cTraining.scrlRight = false;
                                cTraining.scrlLeft = true;
                            }
                        }
                    }
                    else if(cInbox.current == true)
                    {
                        if(Raylib.IsKeyPressed(KeyboardKey.KEY_W))
                        {
                            cInbox.current = false;
                            news.current = true;
                        }
                        else if(Raylib.IsKeyPressed(KeyboardKey.KEY_A))
                        {
                            cInbox.current = false;
                            cTraining.current = true;
                        }
                        else if(Raylib.IsKeyPressed(KeyboardKey.KEY_D))
                        {
                            cInbox.current = false;
                            lineUp.current = true;
                            screen = GameScreen.Squad;
                        }
                        else if (cInbox.scrlLeft == true)
                        {
                            if(Raylib.IsKeyPressed(KeyboardKey.KEY_LEFT) || Raylib.IsKeyPressed(KeyboardKey.KEY_RIGHT))
                            {
                                cInbox.scrlLeft = false;
                                cInbox.scrlRight = true;
                            }
                        }
                        else if (cInbox.scrlRight == true)
                        {
                            if(Raylib.IsKeyPressed(KeyboardKey.KEY_LEFT) || Raylib.IsKeyPressed(KeyboardKey.KEY_RIGHT))
                            {
                                cInbox.scrlRight = false;
                                cInbox.scrlLeft = true;
                            }
                        }
                    }
                    else if(centralTab.current == true)
                    {
                        if(Raylib.IsKeyPressed(KeyboardKey.KEY_A))
                        {
                            centralTab.current = false;
                            myClubTab.current = true;
                            screen = GameScreen.MyClub;
                        }
                        else if(Raylib.IsKeyPressed(KeyboardKey.KEY_S))
                        {
                            centralTab.current = false;
                            if (gameDay == false)
                            {
                                simulateDay.current = true;
                            }
                            else
                            {
                                play.current = true;
                            }                            
                        }
                        else if(Raylib.IsKeyPressed(KeyboardKey.KEY_D))
                        {
                            centralTab.current = false;
                            squadTab.current = true;
                            screen = GameScreen.Squad;
                        }
                    }
                }
                else if (screen == GameScreen.Squad)
                {
                    lineUp.isShowing = true;
                    squadHub.isShowing = true;
                    youthSquad.isShowing = true;
                    teamSheet.isShowing = true;
                    training.isShowing = true;
                    
                    if(lineUp.current == true)
                    {
                        if(Raylib.IsKeyPressed(KeyboardKey.KEY_W))
                        {
                            lineUp.current = false;
                            squadTab.current = true;
                        }
                        else if(Raylib.IsKeyPressed(KeyboardKey.KEY_A))
                        {
                            lineUp.current = false;
                            news.current = true;
                            screen = GameScreen.Central;
                        }
                        else if(Raylib.IsKeyPressed(KeyboardKey.KEY_D))
                        {
                            lineUp.current = false;
                            squadHub.current = true;
                        }

                    }
                    else if(squadHub.current == true)
                    {
                        if(Raylib.IsKeyPressed(KeyboardKey.KEY_W))
                        {
                            squadHub.current = false;
                            squadTab.current = true;
                        }
                        else if(Raylib.IsKeyPressed(KeyboardKey.KEY_A))
                        {
                            squadHub.current = false;
                            lineUp.current = true;
                        }
                        else if(Raylib.IsKeyPressed(KeyboardKey.KEY_S))
                        {
                            squadHub.current = false;
                            teamSheet.current = true;
                        }
                        else if(Raylib.IsKeyPressed(KeyboardKey.KEY_D))
                        {
                            squadHub.current = false;
                            youthSquad.current = true;
                        }
                    }
                    else if(youthSquad.current == true)
                    {
                        if(Raylib.IsKeyPressed(KeyboardKey.KEY_W))
                        {
                            youthSquad.current = false;
                            squadTab.current = true;
                        }
                        else if(Raylib.IsKeyPressed(KeyboardKey.KEY_A))
                        {
                            youthSquad.current = false;
                            squadHub.current = true;
                        }
                        else if(Raylib.IsKeyPressed(KeyboardKey.KEY_S))
                        {
                            youthSquad.current = false;
                            teamSheet.current = true;
                        }
                        else if(Raylib.IsKeyPressed(KeyboardKey.KEY_D))
                        {
                            youthSquad.current = false;
                            serachPlayer.current = true;
                            screen = GameScreen.Transfer;
                        }
                    }
                    else if(teamSheet.current == true)
                    {
                        if(Raylib.IsKeyPressed(KeyboardKey.KEY_W))
                        {
                            teamSheet.current = false;
                            squadHub.current = true;
                        }
                        else if(Raylib.IsKeyPressed(KeyboardKey.KEY_A))
                        {
                            teamSheet.current = false;
                            lineUp.current = true;
                        }
                        else if(Raylib.IsKeyPressed(KeyboardKey.KEY_S))
                        {
                            teamSheet.current = false;
                            training.current = true;
                        }
                        else if(Raylib.IsKeyPressed(KeyboardKey.KEY_D))
                        {
                            teamSheet.current = false;
                            serachPlayer.current = true;
                            screen = GameScreen.Transfer;
                        }
                    }
                    else if(training.current == true)
                    {
                        if(Raylib.IsKeyPressed(KeyboardKey.KEY_W))
                        {
                            training.current = false;
                            teamSheet.current = true;
                        }
                        else if(Raylib.IsKeyPressed(KeyboardKey.KEY_A))
                        {
                            training.current = false;
                            lineUp.current = true;
                        }
                        else if(Raylib.IsKeyPressed(KeyboardKey.KEY_D))
                        {
                            training.current = false;
                            recommended.current = true;
                            screen = GameScreen.Transfer;
                        }
                    }
                    else if(squadTab.current == true)
                    {
                        if(Raylib.IsKeyPressed(KeyboardKey.KEY_A))
                        {
                            squadTab.current = false;
                            centralTab.current = true;
                            screen = GameScreen.Central;
                        }
                        else if(Raylib.IsKeyPressed(KeyboardKey.KEY_S))
                        {
                            squadTab.current = false;
                            lineUp.current = true;
                        }
                        else if(Raylib.IsKeyPressed(KeyboardKey.KEY_D))
                        {
                            squadTab.current = false;
                            transferTab.current = true;
                            screen = GameScreen.Transfer;

                        }
                    }
                }
                else if (screen == GameScreen.Transfer)
                {
                    serachPlayer.isShowing = true;
                    transferHub.isShowing = true;
                    transferHistory.isShowing = true;
                    finances.isShowing = true;
                    recommended.isShowing = true;
                    scouts.isShowing = true;

                    if(serachPlayer.current == true)
                    {
                        if(Raylib.IsKeyPressed(KeyboardKey.KEY_W))
                        {
                            serachPlayer.current = false;
                            transferTab.current = true;
                        }
                        else if(Raylib.IsKeyPressed(KeyboardKey.KEY_A))
                        {
                            serachPlayer.current = false;
                            youthSquad.current = true;
                            screen = GameScreen.Squad;
                        }
                        else if(Raylib.IsKeyPressed(KeyboardKey.KEY_S))
                        {
                            serachPlayer.current = false;
                            recommended.current = true;
                        }
                        else if(Raylib.IsKeyPressed(KeyboardKey.KEY_D))
                        {
                            serachPlayer.current = false;
                            transferHub.current = true;
                        }
                    }
                    else if(transferHub.current == true)
                    {
                        if(Raylib.IsKeyPressed(KeyboardKey.KEY_W))
                        {
                            transferHub.current = false;
                            transferTab.current = true;
                        }
                        else if(Raylib.IsKeyPressed(KeyboardKey.KEY_A))
                        {
                            transferHub.current = false;
                            serachPlayer.current = true;
                        }
                        else if(Raylib.IsKeyPressed(KeyboardKey.KEY_S))
                        {
                            transferHub.current = false;
                            recommended.current = true;
                        }
                        else if(Raylib.IsKeyPressed(KeyboardKey.KEY_D))
                        {
                            transferHub.current = false;
                            transferHistory.current = true;
                        }
                    }
                    else if(transferHistory.current == true)
                    {
                        if(Raylib.IsKeyPressed(KeyboardKey.KEY_W))
                        {
                            transferHistory.current = false;
                            transferTab.current = true;
                        }
                        else if(Raylib.IsKeyPressed(KeyboardKey.KEY_A))
                        {
                            transferHistory.current = false;
                            transferHub.current = true;
                        }
                        else if(Raylib.IsKeyPressed(KeyboardKey.KEY_S))
                        {
                            transferHistory.current = false;
                            recommended.current = true;
                        }
                        else if(Raylib.IsKeyPressed(KeyboardKey.KEY_D))
                        {
                            transferHistory.current = false;
                            finances.current = true;
                        }
                    }
                    else if(finances.current == true)
                    {
                        if(Raylib.IsKeyPressed(KeyboardKey.KEY_W))
                        {
                            finances.current = false;
                            transferTab.current = true;
                        }
                        else if(Raylib.IsKeyPressed(KeyboardKey.KEY_A))
                        {
                            finances.current = false;
                            transferHistory.current = true;
                        }
                        else if(Raylib.IsKeyPressed(KeyboardKey.KEY_S))
                        {
                            finances.current = false;
                            scouts.current = true;
                        }
                        else if(Raylib.IsKeyPressed(KeyboardKey.KEY_D))
                        {
                            finances.current = false;
                            inbox.current = true;
                            screen = GameScreen.Office;
                        }
                    }
                    else if(recommended.current == true)
                    {
                        if(Raylib.IsKeyPressed(KeyboardKey.KEY_W))
                        {
                            recommended.current = false;
                            serachPlayer.current = true;
                        }
                        else if(Raylib.IsKeyPressed(KeyboardKey.KEY_A))
                        {
                            recommended.current = false;
                            training.current = true;
                            screen = GameScreen.Squad;
                        }
                        else if(Raylib.IsKeyPressed(KeyboardKey.KEY_D))
                        {
                            recommended.current = false;
                            scouts.current = true;
                        }
                    }
                    else if(scouts.current == true)
                    {
                        if(Raylib.IsKeyPressed(KeyboardKey.KEY_W))
                        {
                            scouts.current = false;
                            finances.current = true;
                        }
                        else if(Raylib.IsKeyPressed(KeyboardKey.KEY_A))
                        {
                            scouts.current = false;
                            recommended.current = true;
                        }
                        else if(Raylib.IsKeyPressed(KeyboardKey.KEY_D))
                        {
                            scouts.current = false;
                            contracts.current = true;
                            screen = GameScreen.Office;
                        }
                    }
                    else if(transferTab.current == true)
                    {
                        if(Raylib.IsKeyPressed(KeyboardKey.KEY_A))
                        {
                            transferTab.current = false;
                            squadTab.current = true;
                            screen = GameScreen.Squad;
                        }
                        else if(Raylib.IsKeyPressed(KeyboardKey.KEY_S))
                        {
                            transferTab.current = false;
                            serachPlayer.current = true;
                        }
                        else if(Raylib.IsKeyPressed(KeyboardKey.KEY_D))
                        {
                            transferTab.current = false;
                            officeTab.current = true;
                            screen = GameScreen.Office;
                        }
                    }
                }
                else if (screen == GameScreen.Office)
                {
                    inbox.isShowing = true;
                    vision.isShowing = true;
                    contracts.isShowing = true;
                    manageStaff.isShowing = true;
                    browseJobs.isShowing = true;
                    
                    if(inbox.current == true)
                    {
                        if(Raylib.IsKeyPressed(KeyboardKey.KEY_W))
                        {
                            inbox.current = false;
                            officeTab.current = true;
                        }
                        else if(Raylib.IsKeyPressed(KeyboardKey.KEY_A))
                        {
                            inbox.current = false;
                            finances.current = true;
                            screen = GameScreen.Transfer;
                        }
                        else if(Raylib.IsKeyPressed(KeyboardKey.KEY_S))
                        {
                            inbox.current = false;
                            contracts.current = true;
                        }
                        else if(Raylib.IsKeyPressed(KeyboardKey.KEY_D))
                        {
                            inbox.current = false;
                            vision.current = true;
                        }
                        else if (inbox.scrlLeft == true)
                        {
                            if(Raylib.IsKeyPressed(KeyboardKey.KEY_LEFT) || Raylib.IsKeyPressed(KeyboardKey.KEY_RIGHT))
                            {
                                inbox.scrlLeft = false;
                                inbox.scrlRight = true;
                            }
                        }
                        else if (inbox.scrlRight == true)
                        {
                            if(Raylib.IsKeyPressed(KeyboardKey.KEY_LEFT) || Raylib.IsKeyPressed(KeyboardKey.KEY_RIGHT))
                            {
                                inbox.scrlRight = false;
                                inbox.scrlLeft = true;
                            }
                        }
                    }
                    else if (vision.current == true)
                    {
                        if(Raylib.IsKeyPressed(KeyboardKey.KEY_W))
                        {
                            vision.current = false;
                            officeTab.current = true;
                        }
                        else if(Raylib.IsKeyPressed(KeyboardKey.KEY_A))
                        {
                            vision.current = false;
                            inbox.current = true;
                        }
                        else if(Raylib.IsKeyPressed(KeyboardKey.KEY_S))
                        {
                            vision.current = false;
                            manageStaff.current = true;
                        }
                        else if(Raylib.IsKeyPressed(KeyboardKey.KEY_D))
                        {
                            vision.current = false;
                            kits.current = true;
                            screen = GameScreen.MyClub;
                        }
                    }
                    else if (contracts.current == true)
                    {
                        if(Raylib.IsKeyPressed(KeyboardKey.KEY_W))
                        {
                            contracts.current = false;
                            inbox.current = true;
                        }
                        else if(Raylib.IsKeyPressed(KeyboardKey.KEY_A))
                        {
                            contracts.current = false;
                            scouts.current = true;
                            screen = GameScreen.Transfer;
                        }
                        else if(Raylib.IsKeyPressed(KeyboardKey.KEY_D))
                        {
                            contracts.current = false;
                            manageStaff.current = true;
                        }
                    }
                    else if (manageStaff.current == true)
                    {
                        if(Raylib.IsKeyPressed(KeyboardKey.KEY_W))
                        {
                            manageStaff.current = false;
                            inbox.current = true;
                        }
                        else if(Raylib.IsKeyPressed(KeyboardKey.KEY_A))
                        {
                            manageStaff.current = false;
                            contracts.current = true;
                        }
                        else if(Raylib.IsKeyPressed(KeyboardKey.KEY_D))
                        {
                            manageStaff.current = false;
                            browseJobs.current = true;
                        }
                    }
                    else if (browseJobs.current == true)
                    {
                        if(Raylib.IsKeyPressed(KeyboardKey.KEY_W))
                        {
                            browseJobs.current = false;
                            vision.current = true;
                        }
                        else if(Raylib.IsKeyPressed(KeyboardKey.KEY_A))
                        {
                            browseJobs.current = false;
                            manageStaff.current = true;
                        }
                        else if(Raylib.IsKeyPressed(KeyboardKey.KEY_D))
                        {
                            browseJobs.current = false;
                            trophies.current = true;
                            screen = GameScreen.MyClub;
                        }

                    }
                    else if (officeTab.current == true)
                    {
                        if(Raylib.IsKeyPressed(KeyboardKey.KEY_A))
                        {
                            officeTab.current = false;
                            transferTab.current = true;
                            screen = GameScreen.Transfer;
                        }
                        else if(Raylib.IsKeyPressed(KeyboardKey.KEY_S))
                        {
                            officeTab.current = false;
                            inbox.current = true;
                        }
                        else if(Raylib.IsKeyPressed(KeyboardKey.KEY_D))
                        {
                            officeTab.current = false;
                            myClubTab.current = true;
                            screen = GameScreen.MyClub;
                        }
                    }
                }
                else if (screen == GameScreen.MyClub)
                {
                    kits.isShowing = true;
                    arrangeFriendlies.isShowing = true;
                    trophies.isShowing = true;
                    otherLeagues.isShowing = true;
                    top25.isShowing = true;
                    
                    if(kits.current == true)
                    {
                        if(Raylib.IsKeyPressed(KeyboardKey.KEY_W))
                        {
                            kits.current = false;
                            myClubTab.current = true;
                        }
                        else if(Raylib.IsKeyPressed(KeyboardKey.KEY_A))
                        {
                            kits.current = false;
                            vision.current = true;
                            screen = GameScreen.Office;
                        }
                        else if(Raylib.IsKeyPressed(KeyboardKey.KEY_S))
                        {
                            kits.current = false;
                            trophies.current = true;
                        }
                        else if(Raylib.IsKeyPressed(KeyboardKey.KEY_D))
                        {
                            kits.current = false;
                            arrangeFriendlies.current = true;
                        }
                    }
                    else if(arrangeFriendlies.current == true)
                    {
                        if(Raylib.IsKeyPressed(KeyboardKey.KEY_W))
                        {
                            arrangeFriendlies.current = false;
                            myClubTab.current = true;
                        }
                        else if(Raylib.IsKeyPressed(KeyboardKey.KEY_A))
                        {
                            arrangeFriendlies.current = false;
                            kits.current = true;
                        }
                        else if(Raylib.IsKeyPressed(KeyboardKey.KEY_S))
                        {
                            arrangeFriendlies.current = false;
                            top25.current = true;
                        }
                        else if(Raylib.IsKeyPressed(KeyboardKey.KEY_D))
                        {
                            arrangeFriendlies.current = false;
                            if (gameDay == false)
                            {
                                simulateDay.current = true;
                                play.current = false;
                            }
                            else
                            {
                                simulateDay.current = false;
                                play.current = true;
                            }
                            screen = GameScreen.Central;
                        }
                    }
                    else if(trophies.current == true)
                    {
                        if(Raylib.IsKeyPressed(KeyboardKey.KEY_W))
                        {
                            trophies.current = false;
                            kits.current = true;
                        }
                        else if(Raylib.IsKeyPressed(KeyboardKey.KEY_A))
                        {
                            trophies.current = false;
                            browseJobs.current = true;
                            screen = GameScreen.Office;
                        }
                        else if(Raylib.IsKeyPressed(KeyboardKey.KEY_D))
                        {
                            trophies.current = false;
                            otherLeagues.current = true;
                        }
                    }
                    else if(otherLeagues.current == true)
                    {
                        if(Raylib.IsKeyPressed(KeyboardKey.KEY_W))
                        {
                            otherLeagues.current = false;
                            kits.current = true;
                        }
                        else if(Raylib.IsKeyPressed(KeyboardKey.KEY_A))
                        {
                            otherLeagues.current = false;
                            trophies.current = true;
                        }
                        else if(Raylib.IsKeyPressed(KeyboardKey.KEY_D))
                        {
                            otherLeagues.current = false;
                            top25.current = true;
                        }
                    }
                    else if(top25.current == true)
                    {
                        if(Raylib.IsKeyPressed(KeyboardKey.KEY_W))
                        {
                            top25.current = false;
                            arrangeFriendlies.current = true;
                        }
                        else if(Raylib.IsKeyPressed(KeyboardKey.KEY_A))
                        {
                            top25.current = false;
                            otherLeagues.current = true;
                        }
                        else if(Raylib.IsKeyPressed(KeyboardKey.KEY_D))
                        {
                            top25.current = false;
                            cHubs.current = true;
                            screen = GameScreen.Central;
                        }
                    }
                    else if(myClubTab.current == true)
                    {
                        if(Raylib.IsKeyPressed(KeyboardKey.KEY_A))
                        {
                            myClubTab.current = false;
                            officeTab.current = true;
                            screen = GameScreen.Office;
                        }
                        else if(Raylib.IsKeyPressed(KeyboardKey.KEY_S))
                        {
                            myClubTab.current = false;
                            kits.current = true;
                        }
                        else if(Raylib.IsKeyPressed(KeyboardKey.KEY_D))
                        {
                            myClubTab.current = false;
                            centralTab.current = true;
                            screen = GameScreen.Central;
                        }
                    }
                }
                Raylib.ClearBackground(Color.DARKBLUE);
                Raylib.EndDrawing();
            }
        }
    }
}
