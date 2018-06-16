using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingSpheres
{
    class Program
    {
        static void Main(string[] args)
        {
            Sphere sp = new Sphere(2, 50);
            int radius=sp.GetRadius();
            Console.WriteLine(radius);
            int mass=sp.GetMass();
            Console.WriteLine(mass);
            decimal density=sp.GetDensity();
            Math.Round(density, 5);
            Console.WriteLine(density);
            decimal volume=sp.GetVolume();
            Math.Round(volume, 5);
            Console.WriteLine(volume);
            decimal result=sp.SurfaceArea();
            Math.Round(result, 5);
            Console.WriteLine(result);
        }
        
    }
}
