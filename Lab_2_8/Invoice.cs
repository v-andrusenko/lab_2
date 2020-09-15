using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2_8
{
    class Invoice
    {
        public int account { get; private set; }
        public string customer { get; private set; }
        public string provider { get; private set; }
        private double price;
        private double taxprice;

        private string article;
        private int quantity;
        public Invoice(int account, string customer, string provider, int price)
        {
            this.account = account;
            this.customer = customer;
            this.provider = provider;
            this.price = price;
            this.article = "Двигун";

        }
        public double TaxPrice(int index, int quantity)
        {
            this.quantity = quantity;
            if (index == 1)
            {
                this.taxprice = price * quantity * 1.2;
            }
            if (index == 2)
            {
                this.taxprice = price * quantity * 1.07;
            }
            if (index == 3 || index == 4)
            {
                this.taxprice = price * quantity;
            }
            return this.taxprice;
        }

        public void Show(int index, int quantity)
        {
            if (index == 1)
            {
                Console.WriteLine($"Облiковий запис: {account}\nПокупець: {customer}\nПостачальник: {provider}\nЦiна: {price}\nВирiб: {article}\n" +
               $"Кiлькiсть: {quantity}\nЦiна з ПДВ (товар входить до категорiї): {TaxPrice(index, quantity)}");

            }
            else if (index == 2 || index == 3)
            {
                Console.WriteLine($"Облiковий запис: {account}\nПокупець: {customer}\nПостачальник: {provider}\nЦiна: {price}\nВирiб: {article}\n" +
                    $"Кiлькiсть: {quantity}\nЦiна з ПДВ (товар входить до категорiї): {TaxPrice(index, quantity)}\n");
            }
            else if  (index == 4)
            {
                Console.WriteLine($"Облiковий запис: {account}\nПокупець: {customer}\nПостачальник: {provider}\nЦiна: {price}\nВирiб: {article}\n" +
            $"Кiлькiсть: {quantity}\nЦiна без ПДВ (товар не входить до категорiї): {TaxPrice(index, quantity)}");
            }

          
            
        }
    }
}
