using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatRobTreasures_Assignment2_24005602
{
    public class Item
    {
        private string _itemId;
        private string _itemType;
        private int _value;

        public string ItemType => _itemType;
        public int Value => _value;

        public Item(string id, string type, int val)
        {
            _itemId = id;
            _itemType = type;
            _value = val;
        }

        public void GetItem()
        {
            Console.WriteLine($"Item Type: {_itemType} | Value: {_value} gold.");
        }

        public void UseItem()
        {
            Console.WriteLine($"Using {_itemType} to bypass obstacle.");
        }
    }
}
