using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_4
{
    class Point
    {
        private int num1;
        private int num2;
        private string str;
        public int x { get; set; }
        public int y { get; set; }
        public string name { get; set; }
        public Point(int x, int y, string name)
        {
            this.x = x;
            this.x = y;
            this.name = name;
        }
    }
}
