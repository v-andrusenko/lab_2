using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_5
{
    class User
    {
        private string login;
        private string name;
        private string surname;
        private int age;
        public string date { get;  private set; }

        
        public User(string login, string name, string surname, int age, string date)
        {
            this.login = login;
            this.name = name;
            this.surname = surname;
            this.age = age;
            this.date = date;
        }
        public void Show()
        {
            Console.WriteLine($"Логин: {login}\nИмя: {name}\nФамилия: {surname}\nВозвраст: {age}\nДата регистрации: {date}");
        }
    }
}
