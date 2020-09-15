using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Converter converter = new Converter(27.99, 33.22, 0.37);
            Console.WriteLine("Выберите нужную операцию: \n1.Перевод гривен\n2.Перевод валюты");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Введите сумму для перевода: ");
            double sum = double.Parse(Console.ReadLine());
            Console.WriteLine();
            int num2;
            if (num1 == 1)
            {
                Console.WriteLine("Выберите валюту: \n1. Доллары\n2. Евро\n3. Рубли");
                num2 = int.Parse(Console.ReadLine());
                Console.WriteLine();
                switch (num2)
                {
                    case 1:converter.UAHtoUSD(sum);
                        break;
                    case 2: converter.UAHtoEUR(sum);
                        break;
                    case 3: converter.UAHtoRUB(sum);
                        break;
                    default: Console.WriteLine("Неизвестная операция");
                        break;
                }
            }
            else if (num1 == 2)
            {
                Console.WriteLine("Выберите валюту: \n1. Доллары\n2. Евро\n3. Рубли");
                num2 = int.Parse(Console.ReadLine());
                Console.WriteLine();
                switch (num2)
                {
                    case 1:
                        converter.USDtoUAH(sum);
                        break;
                    case 2:
                        converter.EURtoUAH(sum);
                        break;
                    case 3:
                        converter.RUBtoUAH(sum);
                        break;
                    default:
                        Console.WriteLine("Неизвестная операция");
                        break;
                }
            }
            else Console.WriteLine("Неизвестная операция");
            
           

            
        }
    }
}
