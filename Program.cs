using System;
using static System.Console;

namespace OperatorOverload
{
    class Program
    {
        static void Main(string[] args)
        {
            Magazine magazine = new Magazine("Умійко", "А-ба-ба-га-ла-ма-га", 10000, "Дитячий", true, 400);
            Magazine magazine2 = new Magazine("Водограй", "А-ба-ба-га-ла-ма-га", 10000, "Дитячий", true, 500);

            magazine += 10;
            WriteLine(magazine.numb_Employees);
            magazine -= 20;
            WriteLine(magazine.numb_Employees);
            WriteLine($"{ magazine == magazine2}");
            WriteLine($"{magazine != magazine2}");
            WriteLine($"{magazine < magazine2}");
            WriteLine($"{magazine > magazine2}");
            WriteLine($" {magazine.ToString()}"); WriteLine();
            WriteLine($" {magazine2.ToString()}");
            WriteLine();

            Shop shop = new Shop("Book", "м.Київ,вул.Щастя,буд.45", "Крутий опис",  70);
            Shop shop2 = new Shop("World of Books", "м.Житомир,вул.Див,буд.7", "Ще крутіший опис", 90);

            shop += 10;
            WriteLine(shop.area);
            shop -= 20;
            WriteLine(shop.area);
            WriteLine($"{ shop == shop2}");
            WriteLine($"{shop != shop2}");
            WriteLine($"{shop < shop2}");
            WriteLine($"{shop > shop2}");
            WriteLine($"{ shop.ToString()}"); WriteLine();
             WriteLine($"{shop2.ToString()}");



            ListBooks bokk = new ListBooks(2);
            bokk[0] = new Books { Name = "Гаррі Потерр і філософський камінь" };
            bokk.Add("Гаррі Потерр Орден фенікса", 1);
            WriteLine($"{bokk.FindElement("Гаррі Потерр і філософський камінь\n")}");
            bokk.Print();
            WriteLine("\n");
            bokk.Delete("Гаррі Потерр Орден фенікса");
            bokk.Print();
        }
    }
}
