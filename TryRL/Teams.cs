using System;
using System.Collections.Generic;
using System.IO;

namespace TryRL
{
    public class Teams
    {
        Random generator = new Random();
        static public List<Teams> teamData = new List<Teams>();
        public string name;
        public int currency;
        public int division;
        Player[] squad = new Player[25];
        public Teams(string name, int currency, int division)
        {
            teamData.Add(this);
            this.name = name;
            this.division = division;
        }

        public void creatingTeams()
        {
            
            string[] teamNamesList = File.ReadAllLines(@"teamnameList");
            List<string> teamNames = new List<string>(teamNamesList);
            List<string> Division1 = new List<string>();
            List<string> Division2 = new List<string>();
            List<string> Division3 = new List<string>();
            for (int howManyToCreate = 0; howManyToCreate < 60; howManyToCreate++)
            {
                int whatTeam = generator.Next(teamNamesList.Length);
                name = teamNamesList[whatTeam];
                teamNames = new List<string>(teamNamesList);
                currency = generator.Next(10000000,50000000);
                int whatDiv = generator.Next(1,3);
                if (whatDiv == 1)
                {
                    if(Division1.Count == 20)
                    {
                        if (Division2.Count == 20)
                        {
                            Division3.Add(name);
                            division = 3;
                        }
                        else
                        {
                            Division2.Add(name);
                            division = 2;
                        }
                    }
                    else
                    {
                        Division1.Add(name);
                        division = 1;
                    }                    
                }
                else if(whatDiv == 2)
                {
                    if (Division2.Count == 20)
                    {
                        if (Division3.Count == 20)
                        {
                            Division1.Add(name);
                            division = 1;
                        }
                        else
                        {
                            Division3.Add(name);
                            division = 3;
                        }
                    }
                    else
                    {
                        Division2.Add(name);
                        division = 2;
                    }
                }
                else
                {
                    if(Division3.Count == 20)
                    {
                        if (Division2.Count == 20)
                        {
                            Division1.Add(name);
                            division = 1;
                        }
                        else
                        {
                            Division2.Add(name);
                            division = 2;
                        }
                    }
                    else 
                    {
                        Division3.Add(name);
                        division = 3;
                    }
                }
                new Teams(name, currency, division/*, squad*/);
                teamNames.RemoveAt(whatTeam); 
                teamNamesList = teamNames.ToArray();
            }
        }
        
        public static void initTeams()
        {
            Teams oneAndOnly = new Teams("Karasuno", 125000000, 1);
            oneAndOnly.creatingTeams();
            teamData.RemoveAt(0);
        }
    }
}