using System;
using System.Collections.Generic;
using System.IO;

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

        /// <summary>
        /// Returns a new Member based on random stats, with a unique name.
        /// </summary>
        public Member newMember()
        {
            //Removes any names already used before choosing a random one.
            List<string> memberNames = new List<string>(nameCombinations);
            string folder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), string.Format("EclipseGame\\{0}#{1}", Properties.Settings.Default.Name, Properties.Settings.Default.identifier));
            foreach (string file in Directory.EnumerateFiles(folder))
            {
                memberNames.Remove(file.Split('\\')[file.Split('\\').Length].Split('.')[0]);
            }
            return new Member(memberNames[rng.Next(0, memberNames.Count)]);
        }

        /// <summary>
        /// An empty Member object.
        /// </summary>
        static Member Empty = new Member("", 0, 0, 0, 0, 0, 0, 0, 0, 0);

        /// <summary>
        /// Converts a .ecm file found in the game data that matches the name given to a Member struct. Returns Characters.Empty if none exists.
        /// </summary>
        public Member fromFile(string characterName) {
            string folder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), string.Format("EclipseGame\\{0}#{1}", Properties.Settings.Default.Name, Properties.Settings.Default.identifier));
            try
            {
                string[] file = File.ReadAllLines(Path.Combine(folder, characterName + ".ecm"));
                return new Member(file[0], int.Parse(file[1]), int.Parse(file[2]), int.Parse(file[3]), int.Parse(file[4]), int.Parse(file[5]), int.Parse(file[6]), int.Parse(file[7]), int.Parse(file[8]), int.Parse(file[9]));
            }
            catch (Exception)
            {
                return Empty;
            }
        }

        /// <summary>
        /// Returns a Member array of all members in the user's guild.
        /// </summary>
        public Member[] getAllMembers()
        {
            List<Member> memberList = new List<Member>();
            string folder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), string.Format("EclipseGame\\{0}#{1}", Properties.Settings.Default.Name, Properties.Settings.Default.identifier));
            try
            {
                foreach (string fileName in Directory.EnumerateFiles(folder)) {
                    string[] file = File.ReadAllLines(fileName);
                    memberList.Add(new Member(file[0], int.Parse(file[1]), int.Parse(file[2]), int.Parse(file[3]), int.Parse(file[4]), int.Parse(file[5]), int.Parse(file[6]), int.Parse(file[7]), int.Parse(file[8]), int.Parse(file[9])));
                }
                return memberList.ToArray();
            }
            catch (Exception)
            {
                return new Member[] { };
            }
        }

        /// <summary>
        /// Takes a Member struct and writes it to the disk as a .ecm file. Returns the file location as a string.
        /// WARNING: Automatically overwrites any preexisting file.
        /// </summary>
        public string toFile(Member member)
        {
            string folder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), string.Format("EclipseGame\\{0}#{1}", Properties.Settings.Default.Name, Properties.Settings.Default.identifier));
            using (StreamWriter fs = new StreamWriter(File.Create(Path.Combine(folder, member.name + ".ecm"))))
            {
                fs.WriteLine(member.name);
                fs.WriteLine(member.armor);
                fs.WriteLine(member.healthMax);
                fs.WriteLine(member.health);
                fs.WriteLine(member.strength);
                fs.WriteLine(member.dexterity);
                fs.WriteLine(member.agility);
                fs.WriteLine(member.constitution);
                fs.WriteLine(member.level);
                fs.WriteLine(member.disposition);
            }
            return Path.Combine(folder, member.name + ".ecm");
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
        public int disposition;
        public Member(string memberName)
        {
            Random rng = new Random();
            level = rng.Next(1, 5);
            name = memberName;
            strength = rng.Next(5, 20);
            dexterity = rng.Next(5, 20);
            agility = rng.Next(5, 20);
            constitution = rng.Next(5, 20);
            healthMax = health = 15;
            armor = level + ((strength - 10) / 2);
            disposition = 0;
        }
        public Member(string a, int b, int c, int d, int e, int f, int g, int h, int i, int k)
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
            disposition = k;
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
            armor = 10 + ((strength - 10) / 2) + ((dexterity - 10) / 2);
            level = playerLevel;
            name = nameCombinations[rng.Next(0, nameCombinations.Length)];
        }
        public Mob(int playerLevel, bool isSurvivor)
        {
            Random rng = new Random();
            nameCombinations = new string[] { "Zombie", "Skeleton", "Undead", "Lone Survivor" };
            strength = rng.Next(0, 20);
            dexterity = rng.Next(0, 20);
            agility = rng.Next(0, 20);
            constitution = rng.Next(0, 20);
            health = (playerLevel) + ((constitution - 10) / 2);
            armor = 10 + ((strength - 10) / 2) + ((dexterity - 10) / 2);
            level = playerLevel;
            name = isSurvivor ? "Angry Survivor" : nameCombinations[rng.Next(0, nameCombinations.Length)];
        }
    }
}
