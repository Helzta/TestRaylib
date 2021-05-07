using System;
using System.Collections.Generic;
using System.IO;

namespace TryRL
{
    public class Teams
    {
        static Random generator = new Random();
        static public List<Teams> teamData = new List<Teams>();
        static public Player[,] squad = new Player[60,25];
        public string name;
        public int div;
        public int currency;
        public int currentPlayers;
        public Teams(string name, int div, int currency, int currentPlayers)
        {
            teamData.Add(this);
            this.name = name;
            this.div = div;
            this.currency = currency;
            this.currentPlayers = currentPlayers;
        }
        public void CreatingTeams()
        {
            teamData.RemoveAt(0);
            string[] teamNamesList = File.ReadAllLines(@"teamnameList");
            List<string> teamNames = new List<string>(teamNamesList);
            for (int howManyToCreate = 0; howManyToCreate < 60; howManyToCreate++)
            {
                int whatTeam = generator.Next(teamNamesList.Length);
                name = teamNamesList[whatTeam];
                currentPlayers = 0;
                teamNames = new List<string>(teamNamesList);
                currency = generator.Next(10000000,50000000);
                int whatDiv = generator.Next(1,3);
                new Teams(name, div, currency, currentPlayers);
                teamNames.RemoveAt(whatTeam); 
                teamNamesList = teamNames.ToArray();
            }
        }
        public static void TeamsIntoDivisions()
        {
            League thirdAndTird = new League(5);
            thirdAndTird.CreateLeagues();
            int whatTeam;
            for (int amntLeagues = 0; amntLeagues < League.leagueData.ToArray().Length; amntLeagues++)
            {
                for (int amntTeams = 0; amntTeams < 20; amntTeams++)
                {
                    whatTeam = generator.Next(teamData.ToArray().Length);
                    League.divTeam[amntLeagues, amntTeams] = teamData.ToArray()[whatTeam];
                    teamData.RemoveAt(whatTeam);
                    League.divTeam[amntLeagues, amntTeams].div = amntLeagues + 1;
                }                
            }
        }
    }
}