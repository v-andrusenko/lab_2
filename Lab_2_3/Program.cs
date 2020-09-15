using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите название книги: ");
            string title = Console.ReadLine();
            Book book = new Book(title);
            Console.Write("Введите содержание книги: ");
            book.Content = Console.ReadLine();
            Console.Write("Введите автора книги: ");
            book.Author = Console.ReadLine();

            book.Show();
        }
    }
}
