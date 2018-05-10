using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsandInheritance
{
    class Dog:Animal
    {
        public string Master;

        public Dog(string name, int age, string status,string master):base(name,age,4,"dog",status)
        {
            Master=master;
            
        }

        public override string Introduce()
        {
            return "My name is " + this.Name + " and my age is " + this.Age;
        }
        public string GreetMaster()
        {
            return "Hello" + this.Master;
        }
    }
}
