using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPiracy
{
    class Program
    {
        static void Main(string[] args)
        {
            bool val = false;
            Ship ship = new Ship(45, 10);
            val=ship.IsWorthIt();
            if(val==false)
            {
                Console.WriteLine("Ship is not worthy loot.");
            }
            else
            {
                Console.WriteLine("Ship is worthy to loot");
            }
        }

    }
}
