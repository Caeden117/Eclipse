using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#pragma warning disable IDE1006 // Naming Styles
namespace Eclipse
{
    class Items
    {
        /// <summary>
        /// An empty item. Returned if Items.find() cannot find any item.
        /// </summary>
        /// <returns>Item</returns>
        public static Item empty = new Item("", "", false, 0, new int[] { }, new int[] { }, 0);

        /// <summary>
        /// If the item is the exact same as the item passed into the function. Generally used to compare against Items.empty
        /// </summary>
        public bool isAlso(Item item1, Item item2)
        {
            if (item1.name == item2.name && item1.description == item2.description && item1.isUseable == item2.isUseable && item1.weight == item2.weight && item1.useMode == item2.useMode && item1.amount == item2.amount && item1.intLevel == item2.intLevel && item1.rarityLevel == item2.rarityLevel)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// An string array containing the color names for rarity colors of Items.
        /// </summary>
        public static string[] rarityColors = new string[] { "ControlText", "DarkGreen", "Blue", "DeepPink", "Gold" };

        /// <summary>
        /// An string array containing the names of rarity levels, corresponding to the colors inside rarityColors.
        /// </summary>
        public static string[] rarityNames = new string[] { "Common", "Uncommon", "Rare", "Epic", "Legendary" };

        /// <summary>
        /// A list of every item in Eclipse.
        /// </summary>
        /// <returns>Item[]</returns>
        public Item[] items = new Item[] {
            new Item("Fists", "When all else fails, nothing beats a good punch.", true, 0, new int[] { 3 }, new int[] { 3, -1 }, 0),
            new Item("Small Potion", "The most basic kind of healing potion..", true, 2.5f, new int[] { 0 }, new int[] { 5 }, 1),
            new Item("Potion", "Your standard healing potion.", true, 5f, new int[] { 0 }, new int[] { 15 }, 5, 1),
            new Item("Large Potion", "A necessity for week-long journeys.", true, 12.5f, new int[] { 0 }, new int[] { 45 }, 7, 2),
            new Item("Super Potion", "Very rare to come across, and with major resell value.", true, 32.25f, new int[] { 0 }, new int[] { -1 }, 10, 3),
            new Item("Rag", "Good for a quick heal.", true, 1.5f, new int[] { 0 }, new int[] { 10 }, 2),
            new Item("Bandage", "Wraps wounds so no infection can get in.", true, 2f, new int[] { 0 }, new int[] { 25 }, 3, 1),
            new Item("Dressing", "Medical-grade bandages that stop wounds fast.", true, 3.5f, new int[] { 0 }, new int[] { 50 }, 3, 2),
            new Item("Rotten Meat", "Meat from an undead. It's probably a good idea to use this as a last resort.", true, 1.25f, new int[] { 1, 2 }, new int[] { 15, -25 }, 0),
            new Item("Granola Bar", "Very plentiful, and a good short-term snack.", true, 0.75f, new int[] { 1 }, new int[] { 15 }, 1),
            new Item("Sandwich", "Your standard sandwich. Easy to make and easy to eat.", true, 1, new int[] { 1 }, new int[] { 20 }, 3),
            new Item("Raw Meat", "Meat that is raw, and not yet infected. On it's own, it's not very good.", true, 3.5f, new int[] { 1 }, new int[] { 7 }, 0, 1),
            new Item("Cooked Meat", "Now this is more like it.", true, 4f, new int[] { 1 }, new int[] { 45 }, 0, 2),
            new Item("Hearty Dinner", "This is worth the time it took to create.", true, 7.5f, new int[] { 1 }, new int[] { -1 }, 0, 3),
            new Item("Pills", "Basic over-the-counter medications.", true, 0.5f, new int[] { 2, 0 }, new int[] { 5, 5 }, 2),
            new Item("Antibiotics", "\"Perscribed by a doctor.\" What doctor?", true, 1.5f, new int[] { 2, 0 }, new int[] { 25, 15 }, 5, 1),
            new Item("Morphine", "Powerful drug that wipes infections as if it was never there.", true, 3, new int[] { 2, 0 }, new int[] { 55, 25 }, 5, 2),
            new Item("Mythical Potion", "Legends tell of a potion that cures everything. Here it is.", true, 5, new int[] { 0, 1, 2 }, new int[] { -1, -1, -1 }, 12, 4),
            new Item("Stick", "It's a stick. You can attack with this, but it'll break easily.", true, 0.5f, new int[] { 3 }, new int[] { 2, 3 }, 0),
            new Item("Copper Coin", "Used for currency.", false, 0.15f, new int[] { }, new int[] { }, 3),
            new Item("Small Copper Pouch", "Contains 10 Copper. The same as 1 Silver.", false, 1.25f, new int[] { }, new int[] { }, 3, 1),
            new Item("Large Copper Pouch", "Contains 100 Copper. The same as 1 Gold.", false, 15, new int[] { }, new int[] { }, 3, 2),
            new Item("Silver Coin", "Used for currency.", false, 0.35f, new int[] { }, new int[] { }, 3, 1),
            new Item("Small Silver Pouch", "Contains 10 Silver. The same as 1 Gold.", false, 3.25f, new int[] { }, new int[] { }, 3, 2),
            new Item("Large Silver Pouch", "Contains 100 Silver. The same as 10 Gold.", false, 35, new int[] { }, new int[] { }, 3, 3),
            new Item("Gold Coin", "Used for currency.", false, 0.5f, new int[] { }, new int[] { }, 3, 1),
            new Item("Small Gold Pouch", "Contains 10 Gold.", false, 5, new int[] { }, new int[] { }, 3, 2),
            new Item("Gold Bar", "100 Gold Coins melted down into one bar. This is true wealth.", false, 25, new int[] { }, new int[] { }, 3, 3),
            new Item("Leather Strap", "A useful piece in crafting.", false, 0.75f, new int[] { }, new int[] { }, 2),
            new Item("Wood Plank", "Standard material for crafting. It gets the job done.", false, 1.25f, new int[] { }, new int[] { }, 1),
            new Item("Rugged Wooden Sword", "If the sword doesn't kill, maybe the splinters will.", true, 0.85f, new int[] { 3 }, new int[] { 4, 5 }, 5),
            new Item("Golden Sword", "You're so rich you made a sword out of your wealth. Welp. Good job.", true, 2.25f, new int[] { 3 }, new int[] { 15, 55 }, 15, 4),
            new Item("Workbench", "This Workbench will greatly help in making better tools.", true, 2.25f, new int[] { }, new int[] { }, 0, 1),
            new Item("Fine Wooden Sword", "A more proper sword, albiet still wooden.", true, 0.85f, new int[] { 3 }, new int[] { 5, 10 }, 5, 1),
            new Item("Leather Pouch", "An empty pouch for storing items.", false, 1.75f, new int[] { }, new int[] { }, 2, 1),
            new Item("Log", "Can be split into planks, or act as a base for objects.", false, 1.85f, new int[] { }, new int[] { }, 2),
            new Item("Simple Axe", "Not much, but it'll get the job done.", true, 0.85f, new int[] { 3 }, new int[] { 4, 8 }, 5, 1),
            new Item("Simple Hammer", "Sure, it's simple, but a hammer's a hammer.", true, 1.15f, new int[] { 3 }, new int[] { 2, 12 }, 4, 1),
            new Item("Scrap Metal", "Remains of what once was. The base of a new revolution.", false, 1.25f, new int[] { }, new int[] { }, 1),
            new Item("Bolt", "Securely holds metal in place.", false, 0.45f, new int[] { }, new int[] { }, 2),
            new Item("Metal Plate", "Stronger then its scrap counterpart.", false, 2.55f, new int[] { }, new int[] { }, 3, 2),
            new Item("Metal Rod", "A rod of metal, can be used as supports or hilts.", false, 0.4f, new int[] { }, new int[] { }, 1, 1),
            new Item("Flimsy Metal Sword", "A nice start to the metal revolution.", true, 1.35f, new int[] { 3 }, new int[] { 6, 15 }, 5, 1),
            new Item("Sturdy Metal Sword", "A truly remarkable weapon. Cuts with ease.", true, 1.85f, new int[] { 3 }, new int[] { 8, 27 }, 7, 2),
            new Item("Metal Slab", "A hard surface. Required component in the Forge.", false, 5.25f, new int[] { }, new int[] { }, 7, 1),
            new Item("Metal Block", "Required component in the Forge.", false, 11.5f, new int[] { }, new int[] { }, 8, 2),
        };

        /// <summary>
        /// A list of all available crafting recipes in Eclipse.
        /// </summary>
        /// <returns>Craft[]</returns>
        public Craft[] recipes = new Craft[]
        {
            new Craft(new string[] {"Wood Plank", "Leather Strap", "Stick"}, "Rugged Wooden Sword", 5),
            new Craft(new string[] {"Wood Plank", "Wood Plank", "Leather Strap", "Leather Strap", "Stick"}, "Fine Wooden Sword", 7, 1),
            new Craft(new string[] {"Rag", "Rag"}, "Bandage", 2),
            new Craft(new string[] { "Bandage", "Bandage"}, "Dressing", 3),
            new Craft(new string[] {"Stick", "Wood Plank", "Leather Strap", "Wood Plank"}, "Simple Axe", 4),
            new Craft(new string[] {"Log", "Simple Axe"}, "Wood Plank x3", 1),
            new Craft(new string[] {"Leather Strap", "Leather Strap", "Leather Strap"}, "Leather Pouch", 5),
            new Craft(new string[] {"Leather Pouch", "Copper Coin", "Copper Coin", "Copper Coin", "Copper Coin", "Copper Coin", "Copper Coin", "Copper Coin", "Copper Coin", "Copper Coin", "Copper Coin", }, "Small Copper Pouch", 3),
            new Craft(new string[] {"Leather Pouch", "Small Copper Pouch", "Small Copper Pouch", "Small Copper Pouch", "Small Copper Pouch", "Small Copper Pouch", "Small Copper Pouch", "Small Copper Pouch", "Small Copper Pouch", "Small Copper Pouch", "Small Copper Pouch", }, "Large Copper Pouch", 6),
            new Craft(new string[] {"Leather Pouch", "Silver Coin", "Silver Coin", "Silver Coin", "Silver Coin", "Silver Coin", "Silver Coin", "Silver Coin", "Silver Coin", "Silver Coin", "Silver Coin", }, "Small Silver Pouch", 4),
            new Craft(new string[] {"Leather Pouch", "Small Silver Pouch", "Small Silver Pouch", "Small Silver Pouch", "Small Silver Pouch", "Small Silver Pouch", "Small Silver Pouch", "Small Silver Pouch", "Small Silver Pouch", "Small Silver Pouch", "Small Silver Pouch", }, "Large Silver Pouch", 7),
            new Craft(new string[] {"Leather Pouch", "Gold Coin", "Gold Coin", "Gold Coin", "Gold Coin", "Gold Coin", "Gold Coin", "Gold Coin", "Gold Coin", "Gold Coin", "Gold Coin", }, "Small Gold Pouch", 5),
            new Craft(new string[] {"Small Gold Pouch", "Small Gold Pouch", "Small Gold Pouch", "Small Gold Pouch", "Small Gold Pouch", "Small Gold Pouch", "Small Gold Pouch", "Small Gold Pouch", "Small Gold Pouch", "Small Gold Pouch", }, "Gold Bar", 13, 2),
            new Craft(new string[] {"Gold Bar", "Gold Bar", "Gold Bar", "Stick"}, "Golden Sword", 25, 2),
            new Craft(new string[] {"Log", "Wood Plank", "Wood Plank", "Simple Axe"}, "Workbench", 0),
            new Craft(new string[] {"Stick", "Stick", "Log"}, "Simple Hammer", 4),
            new Craft(new string[] {"Scrap Metal"}, "Bolt x4", 3),
            new Craft(new string[] {"Scrap Metal", "Simple Hammer"}, "Metal Rod x4", 4),
            new Craft(new string[] {"Scrap Metal", "Bolt", "Bolt", "Bolt", "Bolt", "Scrap Metal", "Simple Hammer"}, "Metal Plate", 6, 1),
            new Craft(new string[] {"Scrap Metal", "Bolt", "Bolt", "Metal Rod"}, "Flimsy Metal Sword", 7, 1),
            new Craft(new string[] {"Metal Plate", "Metal Plate", "Bolt", "Bolt", "Bolt", "Bolt", "Metal Rod"}, "Sturdy Metal Sword", 9, 1),
            new Craft(new string[] {"Metal Plate", "Metal Plate", "Metal Plate", "Metal Plate", "Bolt", "Bolt", "Bolt", "Bolt", "Simple Hammer"}, "Metal Slab", 8, 1),
            new Craft(new string[] {"Metal Slab", "Metal Slab", "Bolt", "Bolt", "Bolt", "Bolt", "Simple Hammer"}, "Metal Block", 9, 1),
            new Craft(new string[] {"Metal Block", "Metal Block", "Metal Slab", "Bolt", "Bolt", "Bolt", "Bolt", "Simple Hammer", "Metal Rod", "Metal Rod"}, "Forge", 9, 1),
        };

        /// <summary>
        /// Returns the Craft item that corresponds to the item it produces when crafted.
        /// </summary>
        /// <param name="craftedName">The product of the crafting recipe.</param>
        /// <returns>Craft</returns>
        public Craft lookupCraft(string craftedName)
        {
            return recipes.Where(g => g.result == craftedName).ToArray()[0];
        }

        /// <summary>
        /// Returns an Item based off of the item's name.
        /// </summary>
        /// <param name="name">Name of the item. Returns Items.empty if no item with that name exists.</param>
        /// <returns>Item</returns>
        public Item find(string name)
        {
            try
            {
                return items.Where(g => g.name == name).ToArray()[0];
            }
            catch (Exception) { return empty; }
        }
    }

    /// <summary>
    /// A crafting recipe. Includes the items needed, the item produces, the intelligence level minimum to craft, and crafting level
    /// </summary>
    public struct Craft
    {
        /// <summary>
        /// An array of all items required to craft.
        /// </summary>
        /// /// <returns>string[]</returns>
        public string[] prerequisites;
        /// <summary>
        /// The name of the item that will be recieved once crafted.
        /// </summary>
        /// /// <returns>string</returns>
        public string result;
        /// <summary>
        /// The minimum intelligence level that is required to craft this item.
        /// </summary>
        public int intLevel;
        /// <summary>
        /// 0 = nothing required | 1 = requires Workbench | 2 = requires Forge
        /// </summary>
        public int craftLevel; //0 (default) = nothing required, 1 = needs Workbench, 2 = needs Forge
        public Craft(string[] requiredItems, string craftingResult, int intelligenceLevel)
        {
            prerequisites = requiredItems;
            result = craftingResult;
            intLevel = intelligenceLevel;
            craftLevel = 0;
        }
        public Craft(string[] requiredItems, string craftingResult, int intelligenceLevel, int craftingLevel)
        {
            prerequisites = requiredItems;
            result = craftingResult;
            intLevel = intelligenceLevel;
            craftLevel = craftingLevel;
        }

        /// <summary>
        /// Returns true if the string[] given (Usually the player's inventory) contains the items needed to craft, their intelligence is high enough, and their craft level is high enough.
        /// </summary>
        public bool canCraft()
        {
            if (Properties.Settings.Default.Intelligence >= intLevel)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    /// <summary>
    /// An item in Eclipse.
    /// </summary>
    public struct Item
    {
        /// <summary>
        /// The name of the item.
        /// </summary>
        public string name;
        /// <summary>
        /// The description of the item.
        /// </summary>
        public string description;
        /// <summary>
        /// Whether or not you can use or equip this item.
        /// </summary>
        public bool isUseable;
        /// <summary>
        /// The weight of the item.
        /// </summary>
        public float weight;
        /// <summary>
        /// The durability it has before it is removed
        /// </summary>
        public int durability;
        public int[] useMode; //0 = heal, 1 = hunger, 2 = infect, 3 = Weapon
        public int[] amount; //uses the same index as useMode. -1 == max hp/max hunger/0 infection || Weapons will use the next index for durability, first for damage.
        /// <summary>
        /// The minimum Intelligence score (Not modifier) for it to be able to be equiped and used.
        /// </summary>
        public int intLevel;
        /// <summary>
        /// How rare it is (Only effects the color in inventory) | Default: 0
        /// </summary>
        public int rarityLevel;

        public Item(string name2, string description2, bool isUseable2, float weight2, int[] useMode2, int[] amount2, int intlevel)
        {
            name = name2;
            description = description2;
            isUseable = isUseable2;
            weight = weight2;
            useMode = useMode2;
            amount = amount2;
            intLevel = intlevel;
            if (useMode2.Length > 0 && useMode2.First() == 3)
            {
                durability = amount.Last();
            }
            else
            {
                durability = -1;
            }
            rarityLevel = 0;
        }

        public Item(string name2, string description2, bool isUseable2, float weight2, int[] useMode2, int[] amount2, int intlevel, int rarity)
        {
            name = name2;
            description = description2;
            isUseable = isUseable2;
            weight = weight2;
            useMode = useMode2;
            amount = amount2;
            intLevel = intlevel;
            if (useMode2.Length > 0 && useMode2.First() == 3)
            {
                durability = amount.Last();
            }
            else
            {
                durability = -1;
            }
            rarityLevel = rarity;
            if (rarityLevel >= Items.rarityColors.Length)
            {
                rarityLevel = Items.rarityColors.Length; //Let it be known of the dangers of System.StackOverflowException
            }
        }

        public void onUse()
        {
            for (var i = 0; i < useMode.Length; i++)
            {
                if (useMode[i] == 0)
                {
                    if (amount[i] == -1)
                    {
                        Properties.Settings.Default.HP = Properties.Settings.Default.HPMax;
                    }
                    else
                    {
                        Properties.Settings.Default.HP += amount[i];
                    }
                }
                else if (useMode[i] == 1)
                {
                    if (amount[i] == -1)
                    {
                        Properties.Settings.Default.Hunger = 100;
                    }
                    else
                    {
                        Properties.Settings.Default.Hunger += amount[i];
                        if (Properties.Settings.Default.Hunger > 100)
                        {
                            Properties.Settings.Default.Hunger = 100;
                        }
                    }
                }
                else if (useMode[i] == 2)
                {
                    if (amount[i] == -1)
                    {
                        Properties.Settings.Default.Infection = 0;
                    }
                    else
                    {
                        if (Properties.Settings.Default.Infection - amount[i] < 0)
                        {
                            Properties.Settings.Default.Infection = 0;
                        }
                        else
                        {
                            Properties.Settings.Default.Infection -= amount[i];
                        }
                    }
                }
            }
        }
    }
}
