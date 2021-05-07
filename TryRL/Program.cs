using System;
using System.Collections.Generic;
using System.IO;
using Raylib_cs;

namespace TryRL
{
    class Program
    {
        public static void CheckD3Team(int choice2p, string space16, string space12, List<string> div3)
        {
            for (int isItThisTeam = 0; isItThisTeam < 20; isItThisTeam++)
            {
                if(div3.ToArray()[choice2p] == League.divTeam[2,isItThisTeam].name)
                {
                    System.Console.WriteLine(   "Team"            + space16   + League.divTeam[2,isItThisTeam].name         + "\n"
                    +                           "Division"        + space12   + League.divTeam[2,isItThisTeam].div          + "\n"
                    +                           "Currency"        + space12   + League.divTeam[2,isItThisTeam].currency     + "\n"
                    +                           "Squad" +  "\n");
                    for (int isItThisSquad = 0; isItThisSquad < 60; isItThisSquad++)
                    {
                        if (League.divTeam[2,isItThisTeam].name == Teams.squad[isItThisSquad,1].tName)
                        {
                            for (int squadMembers = 0; squadMembers < League.divTeam[2,isItThisTeam].currentPlayers; squadMembers++)
                            {
                                if ((squadMembers + 1).ToString().Length == 1)
                                {
                                    System.Console.WriteLine(Teams.squad[isItThisSquad,squadMembers].tName + " [" + (squadMembers + 1) + "]  " + Teams.squad[isItThisSquad,squadMembers].name + " " + Teams.squad[isItThisSquad,squadMembers].surname);
                                }
                                else if((squadMembers + 1).ToString().Length == 2)
                                {
                                    System.Console.WriteLine(Teams.squad[isItThisSquad,squadMembers].tName + " [" + (squadMembers + 1) + "] " + Teams.squad[isItThisSquad,squadMembers].name + " " + Teams.squad[isItThisSquad,squadMembers].surname);
                                }
                            }
                        }
                    }
                }
            }
        }
        public static void CheckD2Team(int choice2p, string space16, string space12, List<string> div2)
        {
            for (int isItThisTeam = 0; isItThisTeam < 20; isItThisTeam++)
            {
                if(div2.ToArray()[choice2p] == League.divTeam[1,isItThisTeam].name)
                {
                    System.Console.WriteLine(   "Team"            + space16   + League.divTeam[1,isItThisTeam].name         + "\n"
                    +                           "Division"        + space12   + League.divTeam[1,isItThisTeam].div          + "\n"
                    +                           "Currency"        + space12   + League.divTeam[1,isItThisTeam].currency     + "\n"
                    +                           "Squad" +  "\n");
                    for (int isItThisSquad = 0; isItThisSquad < 60; isItThisSquad++)
                    {
                        if (League.divTeam[1,isItThisTeam].name == Teams.squad[isItThisSquad,1].tName)
                        {
                            for (int squadMembers = 0; squadMembers < League.divTeam[1,isItThisTeam].currentPlayers; squadMembers++)
                            {
                                if ((squadMembers + 1).ToString().Length == 1)
                                {
                                    System.Console.WriteLine(Teams.squad[isItThisSquad,squadMembers].tName + " [" + (squadMembers + 1) + "]  " + Teams.squad[isItThisSquad,squadMembers].name + " " + Teams.squad[isItThisSquad,squadMembers].surname);
                                }
                                else if((squadMembers + 1).ToString().Length == 2)
                                {
                                    System.Console.WriteLine(Teams.squad[isItThisSquad,squadMembers].tName + " [" + (squadMembers + 1) + "] " + Teams.squad[isItThisSquad,squadMembers].name + " " + Teams.squad[isItThisSquad,squadMembers].surname);
                                }
                            }
                        }
                    }
                }
            }
        }
        public static void CheckD1Team(int choice2p, string space16, string space12, List<string> div1)
        {
            for (int isItThisTeam = 0; isItThisTeam < 20; isItThisTeam++)
            {
                if(div1.ToArray()[choice2p] == League.divTeam[0,isItThisTeam].name)
                {
                    System.Console.WriteLine(   "Team"            + space16   + League.divTeam[0,isItThisTeam].name         + "\n"
                    +                           "Division"        + space12   + League.divTeam[0,isItThisTeam].div          + "\n"
                    +                           "Currency"        + space12   + League.divTeam[0,isItThisTeam].currency     + "\n"
                    +                           "Squad" +  "\n");
                    for (int isItThisSquad = 0; isItThisSquad < 60; isItThisSquad++)
                    {
                        if (League.divTeam[0,isItThisTeam].name == Teams.squad[isItThisSquad,1].tName)
                        {
                            for (int squadMembers = 0; squadMembers < League.divTeam[0,isItThisTeam].currentPlayers; squadMembers++)
                            {
                                if ((squadMembers + 1).ToString().Length == 1)
                                {
                                    System.Console.WriteLine(Teams.squad[isItThisSquad,squadMembers].tName + " [" + (squadMembers + 1) + "]  " + Teams.squad[isItThisSquad,squadMembers].name + " " + Teams.squad[isItThisSquad,squadMembers].surname);
                                }
                                else if((squadMembers + 1).ToString().Length == 2)
                                {
                                    System.Console.WriteLine(Teams.squad[isItThisSquad,squadMembers].tName + " [" + (squadMembers + 1) + "] " + Teams.squad[isItThisSquad,squadMembers].name + " " + Teams.squad[isItThisSquad,squadMembers].surname);
                                }
                            }
                        }
                    }
                }
            }
        }
        static void Main(string[] args)
        {            
            Player.PlayersIntoTeams();
            Teams.TeamsIntoDivisions();
            string space17 = "                 ";
            string space16 = "                ";
            string space15 = "               ";
            string space14 = "              ";
            string space13 = "             ";
            string space12 = "            ";
            string space11 = "           ";
            string space10 = "          ";
            string space7 = "       ";
            string space6 = "      ";
            string space5 = "     ";
            string space4 = "    ";
            string space3 = "   ";
            string space = " ";
            Console.Clear();
            System.Console.WriteLine("Check players or teams");
            string choice = Console.ReadLine();
            // Hur man lägger till personer i listan
            Player.playerData.Add(new Player("Boing boing", "Outside Hitter", "Kristoffer", "See", 69, 18, "righ", 182, 80, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99));
            Player.playerData.RemoveAt(Player.playerData.ToArray().Length -1);
            Player.playerData.Add(new Player("Test", "Outside Hitter", "Bertil", "Chemnitz", 69, 18, "righ", 182, 80, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99));
            Player.playerData.RemoveAt(Player.playerData.ToArray().Length -1);
            while (choice == "players" || choice == "1")
            {
                Console.Clear();
                for (int tellMeBoutYou = 0; tellMeBoutYou < Player.playerData.ToArray().Length; tellMeBoutYou++)
                {
                    Console.WriteLine("Name"            + space16   + Player.playerData[tellMeBoutYou].name           + space + Player.playerData[tellMeBoutYou].surname + "\n"
                                    + "Team"            + space16   + Player.playerData[tellMeBoutYou].tName          + "\n"
                                    + "Position"        + space12   + Player.playerData[tellMeBoutYou].position       + "\n"
                                    + "Favorite Number" + space5    + Player.playerData[tellMeBoutYou].number         + space5    + (tellMeBoutYou + 1) + "\n"
                                    + "Age"             + space17   + Player.playerData[tellMeBoutYou].age            + "\n"
                                    + "Height"          + space14   + Player.playerData[tellMeBoutYou].height         + "\n"
                                    + "Weight"          + space14   + Player.playerData[tellMeBoutYou].weight         + "\n"
                                    + "Attack Overall"  + space6    + Player.playerData[tellMeBoutYou].attackingStats + space5    + "Passing Overall" + space5    + Player.playerData[tellMeBoutYou].passingStats   + space5    +  "Pyhsic Overall"  + space6    + Player.playerData[tellMeBoutYou].physicStats    + space5    +  "Defense Overall" + space5    + Player.playerData[tellMeBoutYou].defenseStats   + space5    +  "Mentality Overall"   + space3    + Player.playerData[tellMeBoutYou].mentalityStats  + "\n"
                                    + "Power"           + space15   + Player.playerData[tellMeBoutYou].power          + space5    + "Sett"            + space16   + Player.playerData[tellMeBoutYou].sett           + space5    +  "Stamina"         + space13   + Player.playerData[tellMeBoutYou].stamina        + space5    +  "Marking"         + space13   + Player.playerData[tellMeBoutYou].marking        + space5    +  "Attack Position"     + space5    + Player.playerData[tellMeBoutYou].atkP            + "\n"
                                    + "Spike"           + space15   + Player.playerData[tellMeBoutYou].spike          + space5    + "Vision"          + space14   + Player.playerData[tellMeBoutYou].vision         + space5    +  "Balance"         + space13   + Player.playerData[tellMeBoutYou].balance        + space5    +  "Blocking"        + space12   + Player.playerData[tellMeBoutYou].blocking       + space5    +  "Defense Position"    + space4    + Player.playerData[tellMeBoutYou].defP            + "\n"
                                    + "Serve"           + space15   + Player.playerData[tellMeBoutYou].serve          + space5    + "Under Arm Pass"  + space6    + Player.playerData[tellMeBoutYou].uAPass         + space5    +  "Speed"           + space15   + Player.playerData[tellMeBoutYou].speed          + space5    +  "Reading"         + space13   + Player.playerData[tellMeBoutYou].reading        + space5    +  "Timing"              + space14   + Player.playerData[tellMeBoutYou].timing          + "\n"
                                    + "Direct"          + space14   + Player.playerData[tellMeBoutYou].direct         + space5    + "Over Arm Pass"   + space7    + Player.playerData[tellMeBoutYou].oAPass         + space5    +  "Mobility"        + space12   + Player.playerData[tellMeBoutYou].mobility       + space5    +  "Dig"             + space17   + Player.playerData[tellMeBoutYou].dig            + space5    +  "Composure"           + space11   + Player.playerData[tellMeBoutYou].coolness        + "\n"
                                    + "Backrow"         + space13   + Player.playerData[tellMeBoutYou].backrow        + space5    + "Ball Controll"   + space7    + Player.playerData[tellMeBoutYou].controll       + space5    +  "Elasticity"      + space10   + Player.playerData[tellMeBoutYou].elasticity     + space5    +  "Reaction"        + space12   + Player.playerData[tellMeBoutYou].reaction       + " \n");
                }
                choice = Console.ReadLine();
            }
            while(choice == "team" || choice == "2")
            {
                Console.Clear();
                System.Console.WriteLine("What League?\n\n\tDivision 1\n\tDivision 2\n\tDivision 3");
                string choice2 = Console.ReadLine();
                List<String> div1 = new List<string>();
                List<String> div2 = new List<string>();
                List<String> div3 = new List<string>();
                bool lookingAtD1 = false;
                bool lookingAtD2 = false;
                bool lookingAtD3 = false;
                int choice2p;
                if(choice2 == "1" || choice2 == "div1")
                {
                    for (int div1Teams = 0; div1Teams < 20; div1Teams++)
                    {
                        div1.Add(League.divTeam[0,div1Teams].name);
                    }
                    div1.Sort();
                    lookingAtD1 = true;
                    while (lookingAtD1 == true)
                    {
                        Console.Clear();
                        for (int div1Teams = 0; div1Teams < div1.ToArray().Length; div1Teams++)
                        {
                            System.Console.WriteLine("["+ (div1Teams + 1) +"] " + div1.ToArray()[div1Teams]);
                        }
                        string Choice2p1 = Console.ReadLine();
                        for (int whatTeam = 0; whatTeam < div1.ToArray().Length; whatTeam++)
                        {
                            if(Choice2p1 == (whatTeam +1).ToString() || Choice2p1 == div1.ToArray()[(whatTeam)].ToString())
                            {
                                Console.Clear();
                                choice2p = whatTeam;
                                CheckD1Team(choice2p, space16, space12, div1);
                                Console.ReadLine();
                            }
                        }
                        if(Choice2p1 == "back" || Choice2p1 == "b")
                        {
                            break;
                        }
                    }
                }
                else if(choice2 == "2" || choice2 == "div2")
                {
                    for (int div2Teams = 0; div2Teams < 20; div2Teams++)
                    {
                        div2.Add(League.divTeam[1,div2Teams].name);
                    }
                    div2.Sort();
                    lookingAtD2 = true;
                    while (lookingAtD2 == true)
                    {
                        Console.Clear();
                        for (int div2Teams = 0; div2Teams < div2.ToArray().Length; div2Teams++)
                        {
                            System.Console.WriteLine("["+ (div2Teams + 1) +"] " + div2.ToArray()[div2Teams]);
                        }
                        string Choice2p2 = Console.ReadLine();
                        for (int whatTeam = 0; whatTeam < div2.ToArray().Length; whatTeam++)
                        {
                            if(Choice2p2 == (whatTeam +1).ToString() || Choice2p2 == div2.ToArray()[(whatTeam)].ToString())
                            {
                                Console.Clear();
                                choice2p = whatTeam;
                                CheckD2Team(choice2p, space16, space12, div2);
                                Console.ReadLine();
                            }
                        }
                        if(Choice2p2 == "back" || Choice2p2 == "b")
                        {
                            break;
                        }
                    }
                }
                else if(choice2 == "3" || choice2 == "div3")
                {
                    for (int div3Teams = 0; div3Teams < 20; div3Teams++)
                    {
                        div3.Add(League.divTeam[2,div3Teams].name);
                    }
                    div3.Sort();
                    lookingAtD3 = true;
                    while (lookingAtD3 == true)
                    {
                        Console.Clear();
                        for (int div3Teams = 0; div3Teams < div3.ToArray().Length; div3Teams++)
                        {
                            System.Console.WriteLine("["+ (div3Teams + 1) +"] " + div3.ToArray()[div3Teams]);
                        }
                        string Choice2p3 = Console.ReadLine();
                        for (int whatTeam = 0; whatTeam < div3.ToArray().Length; whatTeam++)
                        {
                            if(Choice2p3 == (whatTeam +1).ToString() || Choice2p3 == div3.ToArray()[whatTeam].ToString())
                            {
                                Console.Clear();
                                choice2p = whatTeam;
                                CheckD3Team(choice2p, space16, space12, div3);
                                Console.ReadLine();
                            }
                        }
                        if(Choice2p3 == "back" || Choice2p3 == "b")
                        {
                            break;
                        }
                    }
                }
                choice = Console.ReadLine();
                Console.Clear();
            }
            HubDesign centralTab = new HubDesign();
            HubDesign squadTab = new HubDesign();
            HubDesign transferTab = new HubDesign();
            HubDesign officeTab = new HubDesign();
            HubDesign myClubTab = new HubDesign();
            SimulateButton simulate = new SimulateButton();
            HubDesign news = new HubDesign();
            HubDesign cHubs = new HubDesign();
            HubDesign league = new HubDesign();
            HubDesign cTraining = new HubDesign();
            HubDesign cInbox = new HubDesign();
            HubDesign lineUp = new HubDesign();
            HubDesign training = new HubDesign();
            HubDesign squadHub = new HubDesign();
            HubDesign youthSquad = new HubDesign();
            HubDesign teamSheet = new HubDesign();
            HubDesign searchPlayer = new HubDesign();
            HubDesign transferHub = new HubDesign();
            HubDesign transferHistory = new HubDesign();
            HubDesign finances = new HubDesign();
            HubDesign scouts = new HubDesign();
            HubDesign recommended = new HubDesign();
            HubDesign inbox = new HubDesign();
            HubDesign vision = new HubDesign();
            HubDesign contracts = new HubDesign();
            HubDesign manageStaff = new HubDesign();
            HubDesign browseJobs = new HubDesign();
            HubDesign kits = new HubDesign();
            HubDesign arrangeFriendlies = new HubDesign();
            HubDesign trophies = new HubDesign();
            HubDesign otherLeagues = new HubDesign();
            HubDesign top25 = new HubDesign();
            Platform.PrintHubMenu(centralTab, squadTab, transferTab, officeTab, myClubTab, simulate, news, cHubs, league, cTraining, cInbox, lineUp, squadHub, youthSquad, teamSheet, training, searchPlayer, transferHub, transferHistory, finances, recommended, scouts, inbox, vision, contracts, manageStaff, browseJobs, kits, arrangeFriendlies, trophies, otherLeagues, top25);
            HubDesign current = simulate;
            Raylib.InitWindow(1200,750, "");
            Raylib.SetTargetFPS(60);
            while (!Raylib.WindowShouldClose())
            {
                DateTime dtStart = new DateTime(2020, 6, 1);
                DateTime dtCurrent = dtStart.AddDays(simulate.nextDay);
                string dtString = dtCurrent.ToString("dd MMMM yyyy");
                // (current, simulate, news, cHubs, league, cTraining, cInbox, lineUp, squadHub, youthSquad, training, teamSheet, serachPlayer, transferHub, transferHistory, finances, scouts, recommended, vision, inbox, contracts, manageStaff, browseJobs, kits, arrangeFriendlies, trophies, otherLeagues, top25);
                // (HubDesign current, HubDesign simulate, HubDesign news, HubDesign cHubs, HubDesign league, HubDesign cTraining, HubDesign cInbox, HubDesign lineUp, HubDesign squadHub, HubDesign youthSquad, HubDesign training, HubDesign teamSheet, HubDesign serachPlayer, HubDesign transferHub, HubDesign transferHistory, HubDesign finances, HubDesign scouts, HubDesign recommended, HubDesign vision, HubDesign inbox, HubDesign contracts, HubDesign manageStaff, HubDesign browseJobs, HubDesign kits, HubDesign arrangeFriendlies, HubDesign trophies, HubDesign otherLeagues, HubDesign top25)
                if (Raylib.IsKeyPressed(KeyboardKey.KEY_W))
                {
                    current = current.toUp;
                }
                else if (Raylib.IsKeyPressed(KeyboardKey.KEY_A))
                {
                    current = current.toLeft;
                }
                else if (Raylib.IsKeyPressed(KeyboardKey.KEY_S))
                {
                    current = current.toDown;
                }
                else if (Raylib.IsKeyPressed(KeyboardKey.KEY_D))
                {
                    current = current.toRight;
                }
                else if (Raylib.IsKeyPressed(KeyboardKey.KEY_Q))
                {
                    current = current.visable[0];
                }
                else if (Raylib.IsKeyPressed(KeyboardKey.KEY_E))
                {
                    current = current.visable[1];
                }
                else if(Raylib.IsKeyPressed(KeyboardKey.KEY_ENTER))
                {
                    current.action();
                }
                foreach (HubDesign LB in current.visable)
                {
                    LB.DrawBox();
                }
                foreach (HubDesign wut in current.whatTab)
                {
                    wut.DrawTab();
                }
                HubDesign.currentBox(current);

                if (current == simulate)
                {
                    Raylib.DrawText(dtString, simulate.x, simulate.y + 50, 30, Color.ORANGE);
                }
                else if(current.visable.Contains(simulate))
                {
                    Raylib.DrawText(dtString, simulate.x + 15, simulate.y + 45, 20, Color.ORANGE);
                }
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.BLUE);
                Raylib.EndDrawing();
            }
        }
    }
}