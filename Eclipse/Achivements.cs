using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eclipse
{
    class Achievements
    {
        public static Achievement empty = new Achievement();
        private static string masterEncoder = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";

        public static Achievement decodeAchievement(char x)
        {
            return listOfAchievements[masterEncoder.IndexOf(x)];
        }

        public static bool giveAchievement(string name, bool isItem, Achievement.AchievementType type)
        {
            return giveAchievement(name, isItem, type, out Achievement achievement);
        }

        public static bool giveAchievement(string name, bool isItem, Achievement.AchievementType type, out Achievement achievement)
        {
            List<char> encoder = new List<char>();
            foreach (char x in masterEncoder)
            {
                encoder.Add(x);
            }
            achievement = Achievements.empty;
            if (isItem)
            {
                if (listOfAchievements.Where(g => g.linkedItem == name && g.type == type).LongCount() > 0)
                {
                    achievement = listOfAchievements.Where(g => g.linkedItem == name && g.type == type).ToArray()[0];
                    if (!Properties.Settings.Default.achievementList.Contains(encoder[listOfAchievements.ToList().IndexOf(achievement)]))
                    {
                        Properties.Settings.Default.achievementList += encoder[listOfAchievements.ToList().IndexOf(achievement)];
                        return true;
                    }
                }
            }
            else
            {
                if (listOfAchievements.Where(g => g.name == name && g.type == type).LongCount() > 0)
                {
                    achievement = listOfAchievements.Where(g => g.name == name && g.type == type).ToArray()[0];
                    if (!Properties.Settings.Default.achievementList.Contains(encoder[listOfAchievements.ToList().IndexOf(achievement)]))
                    {
                        Properties.Settings.Default.achievementList += encoder[listOfAchievements.ToList().IndexOf(achievement)];
                        return true;
                    }
                }
            }
            return false;
            /*
            try
            {
            }
            catch (Exception)
            {
                achievement = Achievements.empty;
                return false;
            }
            */
        }

        public static Achievement[] listOfAchievements = new Achievement[]
        {
            new Achievement("Eclipse", "Welcome to Eclipse.", Achievement.AchievementType.Other),
            new Achievement("The Best Weapon", "That'll teach 'em.", Achievement.AchievementType.Use, "Stick"),
            new Achievement("Simple Work Space", "Light a fire.", Achievement.AchievementType.Craft, "Fire"),
            new Achievement("Rough Around The Edges", "A basic sword will do for now.", Achievement.AchievementType.Craft, "Rugged Wooden Sword"),
            new Achievement("Solid Work Space", "Make yourself a Workbench.", Achievement.AchievementType.Craft, "Workbench"),
            new Achievement("Revolutionary", "A step up from wood.", Achievement.AchievementType.ReceiveItem, "Scrap Metal"),
            new Achievement("Flimsy Start", "It'll take time to get used to Metal.", Achievement.AchievementType.Craft, "Flimsy Metal Sword"),
            new Achievement("Sturdy Finish", "Reinforce your flimsy metal sword.", Achievement.AchievementType.Craft, "Sturdy Metal Sword"),
            new Achievement("Professional Work Space", "Create a real man's workshop.", Achievement.AchievementType.Craft, "Forge"),
            new Achievement("I Need Healing", "Recover health using Items with less than 5 health.", Achievement.AchievementType.Other),
            new Achievement("Strong Drug", "Use Morphine to wipe your infection.", Achievement.AchievementType.Use, "Morphine"),
            new Achievement("Overdose", "Heal more than your health maximum.", Achievement.AchievementType.Other),
            new Achievement("Close One", "Recover from being Infected.", Achievement.AchievementType.Other),
            new Achievement("Near Death Experience", "Recover from being Infected with 90 or greater Infection.", Achievement.AchievementType.Other),
            new Achievement("Holy Water", "Use a Mythical Potion to restart yourself.", Achievement.AchievementType.Use, "Mythical Potion"),
            new Achievement("Desperate Circumstances", "Eat Rotten Meat.", Achievement.AchievementType.Use, "Rotten Meat"),
            new Achievement("Vegetarian", "Create and eat a Salad.", Achievement.AchievementType.Use, "Salad"),
            new Achievement("Carnivore", "Create and eat a Hamburger.", Achievement.AchievementType.Use, "Hamburger"),
            new Achievement("Rising from Poverty", "Craft a small Copper Pouch", Achievement.AchievementType.Craft, "Small Copper Pouch"),
            new Achievement("Middle Class", "Craft a small Silver Pouch", Achievement.AchievementType.Craft, "Small Silver Pouch"),
            new Achievement("Gold Rush", "Find yourself some Gold.", Achievement.AchievementType.ReceiveItem, "Gold Coin"),
            new Achievement("Fat Stacks", "Stash your Gold into a small Gold Pouch", Achievement.AchievementType.Craft, "Small Gold Coin"),
            new Achievement("Bill Gates", "Somehow compress your gold pouches into a gold bar.", Achievement.AchievementType.Craft, "Gold Bar"),
            new Achievement("Showoff", "Create a sword out of your wealth.", Achievement.AchievementType.Craft, "Golden Sword"),
            new Achievement("Postmortem", "Have a Totem save your life.", Achievement.AchievementType.Other),
            new Achievement("Red Handed", "I hope you know what you've done.", Achievement.AchievementType.Other),
            new Achievement("More Than You Can Chew", "Carry more than what you can handle.", Achievement.AchievementType.Other),
            new Achievement("A Special Friend", "Recruit a survivor into your guild.", Achievement.AchievementType.Other),
            new Achievement("Company", "Recruit 5 people into your guild.", Achievement.AchievementType.Other),
            new Achievement("Competitive", "Recruit 10 people into your guild.", Achievement.AchievementType.Other),
            new Achievement("Getting Started", "Reach level 5.", Achievement.AchievementType.Other),
            new Achievement("Intermediate User", "Reach level 10.", Achievement.AchievementType.Other),
            new Achievement("Devoted Player", "Reach level 20.", Achievement.AchievementType.Other),
            new Achievement("Time Waster", "Reach level 40.", Achievement.AchievementType.Other),
            new Achievement("Bad Negotiator", "You must of said something they didn't like...", Achievement.AchievementType.Other),
            new Achievement("Novice", "Kill 10 enemies.", Achievement.AchievementType.Other),
            new Achievement("Apprentice", "Kill 50 enemies.", Achievement.AchievementType.Other),
            new Achievement("Initiate", "Kill 125 enemies.", Achievement.AchievementType.Other),
            new Achievement("Master", "Kill 500 enemies.", Achievement.AchievementType.Other),
            new Achievement("Legend", "Kill 1000 enemies.", Achievement.AchievementType.Other),
        };
    }

    struct Achievement
    {
        /// <summary>
        /// The display name of the achievement.
        /// </summary>
        public string name;
        /// <summary>
        /// A description of the achievement.
        /// </summary>
        public string description;
        public enum AchievementType { Craft, Use, ReceiveItem, Other };
        public AchievementType type;
        /// <summary>
        /// The item name linked to this achievement (What you must craft, use, or receive to unlock this achievement).
        /// </summary>
        public string linkedItem;
        public Achievement(string achievementName, string achievementDescription, AchievementType achievementType, string item)
        {
            name = achievementName;
            description = achievementDescription;
            type = achievementType;
            linkedItem = item;
        }
        public Achievement(string achievementName, string achievementDescription, AchievementType achievementType)
        {
            name = achievementName;
            description = achievementDescription;
            type = achievementType;
            linkedItem = "";
        }
    }
}
