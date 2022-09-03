using System;

namespace Imitation
{    
    partial class Program
    {
        static void Main(string[] args)
        {
           
            Product a = new Product(Money.Currency.Dolar, 100, 0.16, Product.Prod.Laptop, 100);
            a.Sum();
            a.Discount(10.0);
            if (a.Money_() != -1)
            {
                Console.WriteLine($"Ви придбали {a.PrintProduct()} Залишок грошей:{a.Money_()} {a.Print()}");
            }
            else
            {
                Console.WriteLine($"У вас не вистачає коштів навіть зі знижкою");
            }

            Program.Main2();
            Program.Main3();
            Program.Main4();
        }
    }
}
