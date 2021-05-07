using System;
using System.Collections.Generic;

namespace TryRL
{
    public class League
    {
        public static List<League> leagueData = new List<League>();
        public static Teams[,] divTeam = new Teams[3,20];
        public int matchday {get; set;}
        public int points {get; set;}
        public int tablePosition {get; set;}
        public float setPerc {get; set;}
        public int setFor {get; set;}
        public int setAgainst {get; set;}
        public int pointsFor {get; set;}
        public int pointsAgainst {get; set;}
        public League(int points)
        {
            leagueData.Add(this);
            this.points = points;
        }

        public void CreateLeagues()
        {
            leagueData.RemoveAt(0);
            for (int thisManyTimes = 0; thisManyTimes < 3; thisManyTimes++)
            {
                new League(points);
            }
        }
    }
}