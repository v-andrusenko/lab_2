using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Первая сторона прямоугольника: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Вторая сторона прямоугольника: ");
            double b = double.Parse(Console.ReadLine());
            Rectangle rect = new Rectangle(a, b);
            Console.WriteLine("\nПлощадь прямоугольника равна " + rect.square(a, b));
            Console.WriteLine("Периметр прямоугольника равен " + rect.perimeter(a, b));
        }
    }
}