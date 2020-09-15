using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_7
{
    class Employee
    {
        private string name;
        private string surname;
        private string position;
        private double tax;
        private double salary;

        public Employee(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
        }

        public void Payment(int position, int experience)
        {
            switch (position)
            {
                case 1:
                    this.position = "Специалист"; 
                    if (experience >= 0 && experience <= 2) { this.salary = 10000; }
                    else if (experience > 2 && experience <= 5) { this.salary = 13000; }
                    else if (experience > 5 && experience <= 10) { this.salary = 16000; }
                    else if (experience > 10) { this.salary = 19000; }
                    this.tax = ((salary / 100) * 19.5);
                    break;
                case 2:
                    this.position = "Начальник отдела";
                    if (experience >= 0 && experience <= 2) { this.salary = 12500; }
                    else if (experience > 2 && experience <= 5) { this.salary = 14500; }
                    else if (experience > 5 && experience <= 10) { this.salary = 16500; }
                    else if (experience > 10) { this.salary = 20000; }
                    this.tax = ((salary / 100) * 19.5);
                    break;
                case 3:
                    this.position = "Директор подразделения";
                    if (experience >= 0 && experience <= 2) { this.salary = 15000; }
                    else if (experience > 2 && experience <= 5) { this.salary = 18000; }
                    else if (experience > 5 && experience <= 10) { this.salary = 21000; }
                    else if (experience > 10) { this.salary = 23000; }
                    this.tax = ((salary / 100) * 19.5);
                    break;
                case 4:
                    this.position = "Генеральный директор";
                    if (experience >= 0 && experience <= 2) { this.salary = 18000; }
                    else if (experience > 2 && experience <= 5) { this.salary = 20000; }
                    else if (experience > 5 && experience <= 10) { this.salary = 23000; }
                    else if (experience > 10) { this.salary = 26000; }
                    this.tax = ((salary / 100) * 19.5);
                    break;
                default:
                    this.salary = 000;
                    this.tax = 000;
                    this.position = "неизвестная должность";
                    break;
            }
        }
        public void Show()
        {
            Console.WriteLine($"Имя: {name} {surname}");
            Console.WriteLine($"Должность: {position}");
            Console.WriteLine($"Заработная плата: {salary} гривен");
            Console.WriteLine($"Налоговый сбор (19,5%): {tax}");


        }
    }
}
