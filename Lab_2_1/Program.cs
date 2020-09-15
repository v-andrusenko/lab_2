using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_1
{
    class Adress
    {
        public string index { get; set; }
        public string country { get; set; }
        public string city { get; set; }
        public string street { get; set; }
        public string house { get; set; }
        public int apartment { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Adress Example = new Adress();
            Example.index = "02034";
            Example.country = "Швеция";
            Example.city = "Стокгольм";
            Example.street = "Schon";
            Example.house = "2";
            Example.apartment = 16;
            Console.WriteLine($"Индекс: {Example.index}\n" +
            $"Страна: {Example.country}\n" +
            $"Город: {Example.city}\n" +
            $"Адрес: {Example.street}, {Example.house}, квартира {Example.apartment}");
        }
    }
}