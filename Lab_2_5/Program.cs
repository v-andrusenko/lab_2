using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_5
{
    class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User("rickdalton", "Леонардо", "ДиКаприо", 45, "14.09.2020");
            user1.Show();
        }
    }
}
