using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsandInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog doug = new Dog("Doug", 12, "serving his master", "Eliza");
            Cat cat = new Cat("Cathy", 7, "playing with a ball of yarn");
            Shark shark = new Shark("Billy", 3, "alive and well");
            string result=cat.Introduce();
            Console.WriteLine(result);
            string result2=doug.Introduce();
            Console.WriteLine(result2);
            string result3 = shark.Introduce();
            Console.WriteLine(result3);
        }

    }
}
