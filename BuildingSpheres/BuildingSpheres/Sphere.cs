using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingSpheres
{
    class Sphere
    {
        private int _radius;
        private int _mass;
        public Sphere(int radius, int mass)
        {
            _radius = radius;
            _mass = mass;
        }
        public int GetRadius()
        {
            return _radius;
        }
        public int GetMass()
        {
            return _mass;
        }
        public decimal GetVolume()
        {
            decimal volume = 0;
            decimal num1 = Convert.ToDecimal(4 * 3.14);
            decimal num2 = _radius * _radius * _radius;
            volume = num1 * (num2 / 3);
            return volume;
        }
        public decimal SurfaceArea()
        {
            decimal num1 = Convert.ToDecimal(4 * 3.14);
            decimal num2 = _radius * _radius;
            decimal surfacearea = num1 * num2;
            return surfacearea;
        }
        public decimal GetDensity()
        {
            decimal mass1 = GetMass();
            decimal volume = GetVolume();
            decimal density = mass1 / volume;
            return density;
        }
    }
    
}
