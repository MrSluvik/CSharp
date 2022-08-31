using System;
using System.Collections.Generic;
using System.Text;
using SevenWonders;

namespace Structure_Classes_Properties
{
    partial class Program
    {
        static void Main7()
        {

            Wonder1.Print();
            Wonder2.Print();
            Wonder3.Print();
            Wonder4.Print();
            Wonder5.Print();
            Wonder6.Print();
            Wonder7.Print();

        }
    }
}
namespace SevenWonders
{
    class Wonder1
    {
        public static void Print()
        {
            Console.WriteLine("1-Піраміда Хеопса");
        }
    }
    class Wonder2
    {
        public static void Print()
        {
            Console.WriteLine("2-'Висячі сади' Семіраміди");
        }
    }
    class Wonder3
    {
        public static void Print()
        {
            Console.WriteLine("3-Cтатуя Зевса Олімпійського");
        }
    }
    class Wonder4
    {
        public static void Print()
        {
            Console.WriteLine("4-Храм Артеміди в Ефесі");
        }
    }
    class Wonder5
    {
        public static void Print()
        {
            Console.WriteLine("5-Мавзолей у Галікарнасі");
        }
    }
    class Wonder6
    {
        public static void Print()
        {
            Console.WriteLine("6-Колос Родоський ");
        }
    }
    class Wonder7
    {
        public static void Print()
        {
            Console.WriteLine("7-Александрійський маяк");
        }
    }
}
