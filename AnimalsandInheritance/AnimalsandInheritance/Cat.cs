using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsandInheritance
{
    public class Cat:Animal
    {
        
        public Cat(string name, int age, string status):base(name,age,4,"cat",status)
        {
            
        }
        public override string Introduce()
        {
            return "Hello,My name is " + this.Name + " and my age is " + this.Age+"  Meow meow!";
        }
    }
}
