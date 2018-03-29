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
                "Antibiotics",
                "Small Potion",
                "Granola Bar",
                "Wood Plank"
            },
            {
                "Scrap Metal",
                "Silver Coin",
                "Rugged Wooden Sword",
                "Potion",
                "Raw Meat"
            },
            {
                "Silver Coin",
                "Potion",
                "Scrap Metal",
                "Scrap Metal",
                "Wood Plank"
            }
        };
    }
}
