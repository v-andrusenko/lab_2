using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_2
{
    class Rectangle
    {
        double side1, side2;
        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }
        public double square(double side1, double side2)
        {
            return (side1 * side2);
        }

        public double perimeter(double side1, double side2)
        {
            return (side1 * 2 + side2 * 2);
        }

        public double Area { get; }
        public double Perimeter { get; }
    }
}
