using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eclipse
{
    class Characters
    {

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
            nameCombinations = new string[] { "Zombie", "Skeleton", "Undead" };
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
