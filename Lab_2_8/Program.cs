using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice = new Invoice(1022, "NASA", "Завод «Антонов»", 1000000);
            Console.Write("Ставки ПДВ та їх код: \n" +
                "1. 20% – основна ставка щодо бiльшостi операцiй; \n" +
                "2. 7% – використовується щодо лiкарських засобiв та медобладнання, медичних виробiв;\n" +
                "3. 0% – ставка ПДВ щодо експорту;\n" +
                "4. “без ПДВ” – iснують операцiї звiльненi вiд оподаткування взагалi (перелiк таких товарiв зокрема в ст. 196 ПКУ, куди зокрема вiдноситься книжна продукцiя).\nВведiть код: ");
            int index = int.Parse(Console.ReadLine());
            Console.Write("Введiть кiлькiсть продукту: ");
            int quantity = int.Parse(Console.ReadLine());
            Console.WriteLine();
            invoice.Show(index, quantity);
        }
    }
}
