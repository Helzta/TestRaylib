using System;
using System.Collections.Generic;

namespace TryRL
{
    public class Teams
    {
        static List<Teams> teamData = new List<Teams>();
        public string name;
        public int division;
        public int currentCap {get; set;}
        int playerCap = 25;
        public Teams(string name, int division)
        {
            teamData.Add(this);
            this.name = name;
            this.division = division;
        }
    }
}
