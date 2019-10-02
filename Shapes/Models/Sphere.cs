using System;
using System.Collections.Generic;


namespace Shapes.Models
{
    public class Sphere
    {
        public Circle Circle { get; set; }
        // public double Pi { get; set; }

        public Sphere (Circle circle)
        {
            Circle = circle;
            // Pi = 3.14;
        }
        
        public double GetSphereVolume()
        {
            double volume = Math.Round((4/3.0) * Math.PI * Math.Pow(Circle.Radius,3), 2);
            return volume;
        }
        public double GetSurfaceArea()
        {
            double area = Math.Round (4 * Math.PI * Math.Pow(Circle.Radius,2), 2);
            return area;
        }
    }
}
