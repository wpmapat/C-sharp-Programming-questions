using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPiracy
{
    public class Ship
    {
        
        public int Draft;
        public int Crew;
        public Ship(int draft, int crew)
        {
            Draft = draft;
            Crew = crew;
        }
        public bool IsWorthIt()
        {
            double weightOfGold = 0;
            weightOfGold = Draft - (1.5*Crew);
            return (weightOfGold > 20);
        }
    }
}

