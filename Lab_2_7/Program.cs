using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab_1_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Имя работника: ");
            string name = Console.ReadLine();
            Console.Write("Фамилия работника: ");
            string surname = Console.ReadLine();
            Employee employee1 = new Employee(name, surname);
            Console.WriteLine("\nВыберите должность из списка: \n1. Специалист\n2. Начальник отдела\n3. Директор подразделения\n4. Генеральный директор");
            int pos = int.Parse(Console.ReadLine());
            Console.WriteLine("Опыт работы (в годах): ");
            int exp = int.Parse(Console.ReadLine());

            Employee employee = new Employee(name, surname);
            employee.Payment(pos, exp);
            employee.Show();
        }
    }
}
