using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Point A = new Point(0, 3, "A");
            Point B = new Point(2, 0, "B");
            Point C = new Point(0, 0, "C");
            Figure figure = new Figure(A, B, C);
            figure.PerimeterCalculator();
            Console.WriteLine($"Название фигуры: {A.name}{B.name}{C.name}");
        }
    }
}
