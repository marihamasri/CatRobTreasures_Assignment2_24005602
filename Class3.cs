using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatRobTreasures_Assignment2_24005602
{
    public class Guard
    {
        private string _name;
        private int _alertLevel;

        public int AlertLevel
        {
            get { return _alertLevel; }
            set { _alertLevel = Math.Clamp(value, 0, 100); }
        }

        public Guard(string name, int alert)
        {
            _name = name;
            _alertLevel = alert;
        }

        public void Patrol()
        {
            Console.WriteLine($"Guard {_name} is patrolling the hallway...");
        }

        public void DetectPlayer(bool isVisible)
        {
            if (isVisible)
            {
                _alertLevel += 50;
                Console.WriteLine("THIEF DETECTED! Alert Level Rising!");
            }
        }
    }
}
