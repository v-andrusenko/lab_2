using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_6
{
    class Converter
    {
        double usd;
        double eur;
        double rub;
        public Converter(double usd, double eur, double rub)
        {
            this.usd = usd;
            this.eur = eur;
            this.rub = rub;
        }
        public void UAHtoUSD(double uah)
        {
            Console.WriteLine($"{uah} гривен = {uah / usd} долларов");
        }
        public void USDtoUAH(double num)
        {
            Console.WriteLine($"{num} долларов = {num * usd} гривен");
        }
        public void UAHtoEUR(double uah)
        {
            Console.WriteLine($"{uah} гривен = {uah / eur} евро");
        }
        public void EURtoUAH(double num)
        {
            Console.WriteLine($"{num} евро = {num * eur} гривен ");
        }
        public void UAHtoRUB(double uah)
        {
            Console.WriteLine($"{uah} гривен = {uah / rub} евро");
        }
        public void RUBtoUAH(double num)
        {
            Console.WriteLine($"{num} рублей = {num * rub} гривен ");
        }
    }
}
