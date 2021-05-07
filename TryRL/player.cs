using System;
using System.Collections.Generic;
using System.IO;

namespace TryRL
{
    public class Player
    {
        static Random generator = new Random();
        static public List<Player> playerData = new List<Player>();
        public string tName;
        public string name;
        public string surname;
        public int number;
        public string position;
        public string team {get; set;}
        public int age;
        public string arm;
        public int height;
        public int weight;
        public int defenseStats;
        public int marking;
        public int blocking;
        public int reading;
        public int dig;
        public int reaction;
        public int mentalityStats;
        public int timing;
        public int atkP;
        public int defP;
        public int vision;
        public int coolness;
        public int passingStats;
        public int sett;
        public int uAPass;
        public int oAPass;
        public int controll;
        public int physicStats;
        public int stamina;
        public int balance;
        public int speed;
        public int mobility;
        public int elasticity;
        public int attackingStats;
        public int power;
        public int spike;
        public int serve;
        public int direct;
        public int backrow;
        public Player(string tName, string position, string name, string surname, int number, int age, string arm, int height, int weight,
                      int defenseStats, int marking, int blocking, int reading, int dig, int reaction,
                      int mentalityStats, int atkP, int defP, int timing, int coolness,
                      int passingStats, int sett, int vision, int oAPass, int uAPass, int controll, 
                      int physicsStats, int stamina, int balance, int speed, int mobility, int elasticity,
                      int attackingStats, int power, int spike, int serve, int direct, int backrow)
        {
            playerData.Add(this);
            this.tName = tName;
            this.position = position;
            this.name = name;
            this.surname = surname;
            this.number = number;
            this.age = age;
            this.arm = arm;
            this.height = height;
            this.weight = weight;
            this.defenseStats = defenseStats;
            this.marking = marking;
            this.blocking = blocking;
            this.reading = reading;
            this.dig = dig;
            this.reaction = reaction;
            this.mentalityStats = mentalityStats;
            this.atkP = atkP;
            this.defP = defP;
            this.timing = timing;
            this.coolness = coolness;
            this.passingStats = passingStats;
            this.sett = sett;
            this.vision = vision;
            this.uAPass = uAPass;
            this.oAPass = oAPass;
            this.controll = controll;
            this.physicStats = physicsStats;
            this.stamina = stamina;
            this.balance = balance;
            this.speed = speed;
            this.mobility = mobility;
            this.elasticity = elasticity;
            this.attackingStats = attackingStats;
            this.power = power;
            this.spike = spike;
            this.serve = serve;
            this.direct = direct;
            this.backrow = backrow;
        }
        public void CreateStartingPlayers()
        {
            playerData.RemoveAt(0);
            string[] firstNames = File.ReadAllLines(@"nameList");
            string[] lastNames = File.ReadAllLines(@"lastnameList");
            for (int thisManyTimes = 0; thisManyTimes < 900; thisManyTimes++)
            {
                int whatRole = generator.Next(9);
                int whatName = generator.Next(firstNames.Length);
                int whatLastname = generator.Next(lastNames.Length);
                int whatNumber = generator.Next(1,99);
                int whatAge = generator.Next(15,19);
                int whatArm = generator.Next(10);
                int whatWeight = generator.Next(60,100);
                
                name = firstNames[whatName];
                surname = lastNames[whatLastname];
                number = whatNumber;
                age = whatAge;
                weight = whatWeight;
                if (whatArm == 1)
                {
                    arm = "Left";
                }
                else
                {
                    arm = "Right";
                }

                if(whatRole == 0)
                {
                    position = "Setter";
                    height = generator.Next(165, 187);
                    marking = generator.Next(10,99);
                    blocking = generator.Next(10,99);
                    reading = generator.Next(10,99);
                    dig = generator.Next(10,99);
                    reaction = generator.Next(10,99);
                    timing = generator.Next(10,99);
                    atkP = generator.Next(10,99);
                    defP = generator.Next(10,99);
                    vision = generator.Next(10,99);
                    coolness = generator.Next(10,99);
                    sett = generator.Next(10,99);
                    uAPass = generator.Next(10,99);
                    oAPass = generator.Next(10,99);
                    controll = generator.Next(10,99);
                    stamina = generator.Next(10,99);
                    balance = generator.Next(10,99);
                    speed = generator.Next(10,99);
                    mobility = generator.Next(10,99);
                    elasticity = generator.Next(10,99);
                    power = generator.Next(10,99);
                    spike = generator.Next(10,99);
                    serve = generator.Next(10,99);
                    direct = generator.Next(10,99);
                    backrow = generator.Next(10,99);
                }
                else if(whatRole == 1)
                {
                    position = "Libero";
                    height = generator.Next(150, 175);
                    marking = generator.Next(10,30);
                    blocking = generator.Next(60,80);
                    reading = generator.Next(10,30);
                    dig = generator.Next(10,99);
                    reaction = generator.Next(10,99);
                    mentalityStats = generator.Next(10,99);
                    timing = generator.Next(10,99);
                    atkP = generator.Next(10,99);
                    defP = generator.Next(10,99);
                    vision = generator.Next(10,99);
                    coolness = generator.Next(10,99);
                    passingStats = generator.Next(10,99);
                    sett = generator.Next(10,99);
                    uAPass = generator.Next(10,99);
                    oAPass = generator.Next(10,99);
                    controll = generator.Next(10,99);
                    physicStats = generator.Next(10,99);
                    stamina = generator.Next(10,99);
                    balance = generator.Next(10,99);
                    speed = generator.Next(10,99);
                    mobility = generator.Next(10,99);
                    elasticity = generator.Next(10,99);
                    attackingStats = generator.Next(10,99);
                    power = generator.Next(10,99);
                    spike = generator.Next(10,99);
                    serve = generator.Next(10,99);
                    direct = generator.Next(10,99);
                    backrow = generator.Next(10,99);
                }
                else if(whatRole == 2 || whatRole == 3)
                {
                    position = "Middle Blocker";
                    height = generator.Next(184, 210);
                    marking = generator.Next(10,99);
                    blocking = generator.Next(10,99);
                    reading = generator.Next(10,99);
                    dig = generator.Next(10,99);
                    reaction = generator.Next(10,99);
                    mentalityStats = generator.Next(10,99);
                    timing = generator.Next(10,99);
                    atkP = generator.Next(10,99);
                    defP = generator.Next(10,99);
                    vision = generator.Next(10,99);
                    coolness = generator.Next(10,99);
                    passingStats = generator.Next(10,99);
                    sett = generator.Next(10,99);
                    uAPass = generator.Next(10,99);
                    oAPass = generator.Next(10,99);
                    controll = generator.Next(10,99);
                    physicStats = generator.Next(10,99);
                    stamina = generator.Next(10,99);
                    balance = generator.Next(10,99);
                    speed = generator.Next(10,99);
                    mobility = generator.Next(10,99);
                    elasticity = generator.Next(10,99);
                    attackingStats = generator.Next(10,99);
                    power = generator.Next(10,99);
                    spike = generator.Next(10,99);
                    serve = generator.Next(10,99);
                    direct = generator.Next(10,99);
                    backrow = generator.Next(10,99);
                }
                else if(whatRole == 5 || whatRole == 6)
                {
                    position = "Outside Hitter";
                    height = generator.Next(170, 195);
                    marking = generator.Next(10,99);
                    blocking = generator.Next(10,99);
                    reading = generator.Next(10,99);
                    dig = generator.Next(10,99);
                    reaction = generator.Next(10,99);
                    mentalityStats = generator.Next(10,99);
                    timing = generator.Next(10,99);
                    atkP = generator.Next(10,99);
                    defP = generator.Next(10,99);
                    vision = generator.Next(10,99);
                    coolness = generator.Next(10,99);
                    passingStats = generator.Next(10,99);
                    sett = generator.Next(10,99);
                    uAPass = generator.Next(10,99);
                    oAPass = generator.Next(10,99);
                    controll = generator.Next(10,99);
                    physicStats = generator.Next(10,99);
                    stamina = generator.Next(10,99);
                    balance = generator.Next(10,99);
                    speed = generator.Next(10,99);
                    mobility = generator.Next(10,99);
                    elasticity = generator.Next(10,99);
                    attackingStats = generator.Next(10,99);
                    power = generator.Next(10,99);
                    spike = generator.Next(10,99);
                    serve = generator.Next(10,99);
                    direct = generator.Next(10,99);
                    backrow = generator.Next(10,99);
                }
                else if(whatRole == 7)
                {
                    position = "Opposite Hitter";
                    height = generator.Next(170, 195);
                    marking = generator.Next(10,99);
                    blocking = generator.Next(10,99);
                    reading = generator.Next(10,99);
                    dig = generator.Next(10,99);
                    reaction = generator.Next(10,99);
                    mentalityStats = generator.Next(10,99);
                    timing = generator.Next(10,99);
                    atkP = generator.Next(10,99);
                    defP = generator.Next(10,99);
                    vision = generator.Next(10,99);
                    coolness = generator.Next(10,99);
                    passingStats = generator.Next(10,99);
                    sett = generator.Next(10,99);
                    uAPass = generator.Next(10,99);
                    oAPass = generator.Next(10,99);
                    controll = generator.Next(10,99);
                    physicStats = generator.Next(10,99);
                    stamina = generator.Next(10,99);
                    balance = generator.Next(10,99);
                    speed = generator.Next(10,99);
                    mobility = generator.Next(10,99);
                    elasticity = generator.Next(10,99);
                    attackingStats = generator.Next(10,99);
                    power = generator.Next(10,99);
                    spike = generator.Next(10,99);
                    serve = generator.Next(10,99);
                    direct = generator.Next(10,99);
                    backrow = generator.Next(10,99);
                }
                else if(whatRole == 8)
                {
                    position = "Defensive Specialist";
                    height = generator.Next(163, 180);
                    marking = generator.Next(10,99);
                    blocking = generator.Next(10,99);
                    reading = generator.Next(10,99);
                    dig = generator.Next(10,99);
                    reaction = generator.Next(10,99);
                    mentalityStats = generator.Next(10,99);
                    timing = generator.Next(10,99);
                    atkP = generator.Next(10,99);
                    defP = generator.Next(10,99);
                    vision = generator.Next(10,99);
                    coolness = generator.Next(10,99);
                    passingStats = generator.Next(10,99);
                    sett = generator.Next(10,99);
                    uAPass = generator.Next(10,99);
                    oAPass = generator.Next(10,99);
                    controll = generator.Next(10,99);
                    physicStats = generator.Next(10,99);
                    stamina = generator.Next(10,99);
                    balance = generator.Next(10,99);
                    speed = generator.Next(10,99);
                    mobility = generator.Next(10,99);
                    elasticity = generator.Next(10,99);
                    attackingStats = generator.Next(10,99);
                    power = generator.Next(10,99);
                    spike = generator.Next(10,99);
                    serve = generator.Next(10,99);
                    direct = generator.Next(10,99);
                    backrow = generator.Next(10,99);
                }
                defenseStats = (marking + blocking + reading + dig + reaction)/5;
                mentalityStats = (timing + atkP + defP + coolness)/4;
                passingStats = (sett + uAPass + oAPass + controll + vision)/5;
                physicStats = (stamina + balance + speed + mobility + elasticity)/5;
                attackingStats = (power + spike + serve + direct + backrow)/5;
                new Player(tName, position, name, surname, number, age, arm, height, weight, defenseStats, marking, blocking, reading, dig, reaction, mentalityStats, atkP, defP, timing, coolness, passingStats, sett, vision, oAPass, uAPass, controll, physicStats, stamina, balance, speed, mobility, elasticity, attackingStats, power, spike, serve, direct, backrow);
            }
        }
        public static void PlayersIntoTeams()
        {
            Teams secondAndDuo = new Teams("Karasuno", 1, 125000000, 0);
            secondAndDuo.CreatingTeams();
            Player oneAndOnly = new Player("Namaste", "Hmm Hitter", "Kristoffer", "Chemnitz", 69, 18, "righ", 182, 80, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99);
            oneAndOnly.CreateStartingPlayers();
            int whatPlayer;
            for (int amntTeams = 0; amntTeams < Teams.teamData.ToArray().Length; amntTeams++)
            {
                for (int amntPlayers = 0; amntPlayers < 15; amntPlayers++)
                {
                    whatPlayer = generator.Next(playerData.ToArray().Length);
                    Teams.squad[amntTeams,amntPlayers] = playerData.ToArray()[whatPlayer];
                    Teams.teamData[amntTeams].currentPlayers++;
                    playerData.RemoveAt(whatPlayer);
                    Teams.squad[amntTeams,amntPlayers].tName = Teams.teamData[amntTeams].name;
                    Console.WriteLine(Teams.squad[amntTeams,amntPlayers].name + " " + Teams.squad[amntTeams,amntPlayers].surname);
                }
            }
        }

        // public static void InitPlayers()
        // {
        //     Player oneAndOnly = new Player("Hmm Hitter", "Kristoffer", "Chemnitz", 69, 18, "righ", 182, 80, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99);
        //     oneAndOnly.CreateStartingPlayers();
        // }

        // Inte viktigt än
        // public void Draw()
        // {
        //     Raylib.DrawCircle((int) x, (int) y, 40, Color.BLACK);
        //     if(number.Length == 1)
        //     {
        //         Raylib.DrawText(number , (int) x - 10, (int) y - 15, 40, Color.YELLOW);
        //     }
        //     else
        //     {
        //         Raylib.DrawText(number , (int) x - 17, (int) y - 15, 40, Color.YELLOW);
        //     }
        // }

        // public static void DrawAll()
        // {
        //     foreach (Player p in playerData)
        //         {
        //             p.Draw();                    
        //         }
        // }
    }
}