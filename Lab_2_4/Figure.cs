using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_4
{
    class Figure
    {
        private Point A;
        private Point B;
        private Point C;
        private Point D;
        private Point E;

        public Figure(Point A, Point B, Point C) 
        {
            this.A = A;
            this.B = B;
            this.C = C;
        }

        public Figure(Point A, Point B, Point C, Point D) 
        {
            this.A = A;
            this.B = B;
            this.C = C;
            this.D = D;    
        }

        public Figure(Point A, Point B, Point C, Point D, Point E) 
        {
            this.A = A;
            this.B = B;
            this.C = C;
            this.D = D;
            this.E = E;
        }
        public double LengthSide(Point A, Point B)
        {
            return Math.Sqrt((B.x - A.x) * (B.x - A.x) + (B.y - A.y) * (B.y - A.y));
        }
        public void PerimeterCalculator()
        {
            double result = 0;
            if (E != null) { result = LengthSide(A, B) + LengthSide(B, C) + LengthSide(C, D) + LengthSide(D, E) + LengthSide(E, A); }
            else if (D != null) { result = LengthSide(A, B) + LengthSide(B, C) + LengthSide(C, D) + LengthSide(D, E); }
            else { result = LengthSide(A, B) + LengthSide(B, C) + LengthSide(C, A) ; }
            Console.WriteLine($"Периметр многоугольника: {result}");
        }
    }
}
