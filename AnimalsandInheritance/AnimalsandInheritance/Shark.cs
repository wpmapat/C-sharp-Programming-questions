using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsandInheritance
{
    public class Shark : Animal
    {        
        public Shark(string name,int age,string status)
        :base(name,age,0,"shark",status)
        {
            
        }
        public override string Introduce()
        {
            return "My name is" + this.Name + " and my age is " + this.Age;
        }
    }
}
