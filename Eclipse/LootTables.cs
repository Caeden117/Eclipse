using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eclipse
{
    public class LootTables
    {
        public string[] mobLootTable = new string[] //Stuff from slaying.
        {
            "Rag",
            "Small Potion",
            "Granola Bar",
            "Pills",
            "Leather Strap",
            "Copper Coin"
        };

        public string[,] lootingTables = new string[,] //Stuff from looting
        {
            {
                "Leather Strap",
                "Wood Plank",
                "Stick",
                "Rag",
                "Log"
            },
            {
                "Copper Coin",
                "Log",
                "Small Potion",
                "Granola Bar",
                "Wood Plank"
            },
            {
                "Scrap Metal",
                "Log",
                "Rugged Wooden Sword",
                "Hearty Dinner",
                "Antibiotics"
            },
            {
                "Silver Coin",
                "Potion",
                "Scrap Metal",
                "Raw Meat",
                "Wood Plank"
            },
            {
                "Silver Coin",
                "Metal Plate",
                "Scrap Metal",
                "Potion",
                "Scrap Metal"
            },
            {
                "Small Silver Pouch",
                "Metal Plate",
                "Metal Plate",
                "Potion",
                "Large Potion"
            },
            {
                "Gold Coin",
                "Metal Plate",
                "Flimsy Metal Sword",
                "Morphine",
                "Cooked Meat"
            },
            {
                "Large Potion",
                "Metal Plate",
                "Scrap Metal",
                "Metal Slab",
                "Mythical Potion"
            }
        };
    }
}
