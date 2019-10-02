using System;
using System.Collections.Generic;

namespace Shapes.Models
{
    public class Circle {
        public double Radius { get; set; }
        public double Pi { get; }

        public Circle(double radius)
        {
            Radius = radius;
            Pi = 3.14;
        }

        public double GetArea()
        {
            return Pi * (Radius * Radius);
        }

        public double GetCircumference()
        {
            return 2 * Pi * Radius;
        }
    }
}


// godspeed molly

// change da world
// my final message
// goodb ye
// https://www.youtube.com/watch?v=N28OUyR96o0