using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassyExtensions
{
    public class Cat:Animal
    {

        public Cat(string name) : base(name)
        {
            
        }
        public override string Speak()
        {
            return Name +" "+ "meows.";
        }
    }
}
