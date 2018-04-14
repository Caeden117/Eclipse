using System;

namespace Eclipse
{
    class Characters
    {
        public Random rng = new Random();
        public Member[] guildMembers = new Member[] { };
        public static string[] nameCombinations = {
            "Jesse",
            "Daniel",
            "Jack",
            "Abraham",
            "Alex",
            "Alexander",
            "Frisk",
            "Tod",
            "Tom",
            "Tommy",
            "Bob",
            "Robert",
            "Bobby",
            "Mary",
            "Jane",
            "Jessica",
            "Jennifer",
            "Ruby",
            "Hailey",
            "Angelina",
            "Angela"
        };

        string test = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "test.bob"); //Saving this for later.
        //https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/file-system/how-to-create-a-file-or-folder information about creating folders and stuff.

        public Member newMember()
        {
            return new Member(nameCombinations[rng.Next(0, nameCombinations.Length)]);
        }
    }

    public struct Member
    {
        public string name;
        public int armor;
        public int healthMax;
        public int health;
        public int strength;
        public int dexterity;
        public int agility;
        public int constitution;
        public int level;
        public Member(string memberName)
        {
            Random rng = new Random();
            level = rng.Next(1, 5);
            name = memberName;
            strength = rng.Next(1 * Convert.ToInt32(Math.Round((decimal)level / 2)), 5 * level);
            dexterity = rng.Next(1 * Convert.ToInt32(Math.Round((decimal)level / 2)), 5 * level);
            agility = rng.Next(1 * Convert.ToInt32(Math.Round((decimal)level / 2)), 5 * level);
            constitution = rng.Next(1 * Convert.ToInt32(Math.Round((decimal)level / 2)), 5 * level);
            health = (level) + ((constitution - 10) / 2);
            healthMax = health;
            armor = level + ((strength - 10) / 2);
        }
        public Member(string a, int b, int c, int d, int e, int f, int g, int h, int i)
        {
            level = i;
            name = a;
            strength = e;
            dexterity = f;
            agility = g;
            constitution = h;
            health = d;
            healthMax = c;
            armor = b;
        }
    }

    public struct Mob
    {
        public string name;
        public string[] nameCombinations;
        public int armor;
        public int health;
        public int strength;
        public int dexterity;
        public int agility;
        public int constitution;
        public int level;
        public Mob(int playerLevel)
        {
            Random rng = new Random();
            nameCombinations = new string[] { "Zombie", "Skeleton", "Undead", "Lone Survivor" };
            strength = rng.Next(0, 20);
            dexterity = rng.Next(0, 20);
            agility = rng.Next(0, 20);
            constitution = rng.Next(0, 20);
            health = (playerLevel) + ((constitution - 10) / 2);
            armor = playerLevel + ((strength - 10) / 2);
            level = playerLevel;
            name = nameCombinations[rng.Next(0, nameCombinations.Length)];
        }
    }
}
