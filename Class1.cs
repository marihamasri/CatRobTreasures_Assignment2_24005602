using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatRobTreasures_Assignment2_24005602
{
    public class Player
    {
        private string _playerId;
        private string _name;
        private int _level;

        // Public Properties
        public string Name
        {
            get { return _name; }
            set { if (!string.IsNullOrEmpty(value)) _name = value; }
        }

        // Constructor
        public Player(string id, string name, int level)
        {
            _playerId = id;
            _name = name;
            _level = level;
        }

        // Methods
        public void Move(string direction)
        {
            Console.WriteLine($"{_name} moves {direction} stealthily.");
        }

        public void PickItem(string item)
        {
            Console.WriteLine($"{_name} picked up: {item}!");
        }
    }
}
