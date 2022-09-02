using System;
using System.Collections.Generic;
using System.Text;

namespace Imitation
{

    partial class Program
    {
        static void Main2()
        {

            
            Kettle first = new Kettle(2.5,205.55,new DateTime(2022),"kuch");
            Microwave second = new Microwave("Розмороження , Захист від дітей...",6,200, new DateTime(2022),"Sumsung");
            Car three = new Car(2.2,220,10000, new DateTime(2021),"BMW");
            Steamboat four = new Steamboat(91, 14.5, 200,30000, new DateTime(1981),"Kiyoko");

            first.Sound();
            first.Show();
            first.Desc();
            first.Print();

            second.Sound();
            second.Show();
            second.Desc();
            second.Print();

            three.Sound();
            three.Show();
            three.Desc();
            three.Print();

            four.Sound();
            four.Show();
            four.Desc();
            four.Print();
        }
    }




    public class Device
    {
        protected string name;
        protected double price;
        protected DateTime year;
        protected string brend;

        public Device()
        {
            this.name = "";
            this.price = 0;
            this.year = new DateTime(0);
            this.brend = "";
        }
        public Device(string name, double price, DateTime year, string brend) : this()
        {
            this.name = name;
            this.price = price;
            this.year = year;
            this.brend = brend;
        }
        public Device(double price, DateTime year, string brend) : this()
        {

            this.price = price;
            this.year = year;
            this.brend = brend;
        }
        public virtual void Sound()
        { Console.WriteLine("Yo !"); }
        public virtual void Show()
        { Console.WriteLine("A car "); }
        public virtual void Desc()
        { Console.WriteLine("A car .... "); }

    }

    public class Kettle : Device
    {

        protected double volume;//обєм чайника
        public Kettle() : base()
        {
            this.volume = 0;
        }
        public Kettle(double volume, double price, DateTime year, string brend) : base(price, year, brend)
        {
            this.volume = volume;
            this.price = price;
            this.year = year;
            this.brend = brend;
        }
        public override void Sound()
        { Console.WriteLine("\nWhistle\n"); }
        public override void Show()
        { Console.WriteLine($"A Kettle {brend}/n"); }
        public override void Desc()
        { Console.WriteLine("A kettle is a vessel with a handle and spout, a lid (although there are exceptions), which is used for brewing tea or boiling water.\n "); }
        public void Print()
        {
            Console.WriteLine($"Price this kettle = {price}\nVolume this kettle ={volume}\nBrent this kettle:{brend}\nYear of manufacture of this kettle={year}\n\n\n\n");
        }
    }

    public class Microwave : Device
    {

        private int power_Levels;//кількість рівнів потужності
        private string function;//функції печі  типу розморожування ,захист від дітей 

        public Microwave() : base()
        {
            this.power_Levels = 0;
            this.function = "";
        }
        public Microwave(string function, int power_Levels, double price, DateTime year, string brend) : base(price, year, brend)
        {
            this.function = function;
            this.power_Levels = power_Levels;
        }
        public override void Sound()
        { Console.WriteLine("\nGuuuuuuuuuuu-uuuuuu\n"); }
        public override void Show()
        { Console.WriteLine($"A Microwave {brend}\n"); }
        public override void Desc()
        { Console.WriteLine("A microwave oven is a household electrical appliance for quick cooking or quick heating of food, as well as for defrosting it.\n"); }
        public void Print()
        {
            Console.WriteLine($"Price this microwave = {price}\nFunction this microwave ={function}\nPower levels ={power_Levels}\nBrent this microwave:{brend}\nYear of manufacture of this microwave={year}\n\n\n\n");
        }

    }

    public class Car : Device
    {

        protected int max_Speed;
        protected double engine_Capacity;//обєм двигуна

        public Car() : base()
        {
            this.max_Speed = 0;
            this.engine_Capacity=0;
        }
        public Car(double engine_Capacity, int max_Speed, double price, DateTime year, string brend) : base(price, year, brend)
        {
            this.max_Speed = max_Speed;
            this.engine_Capacity = engine_Capacity;
        }
        public override void Sound()
        { Console.WriteLine("\nGu-Gu-gu\n"); }
        public override void Show()
        { Console.WriteLine($"A car  {brend}\n"); }
        public override void Desc()
        { Console.WriteLine("A car is a self-propelled wheeled vehicle that is driven by an engine installed in it and is intended for the transportation of people, cargo.\n"); }
        public void Print()
        {
            Console.WriteLine($"Price this car = {price}\nMax speed this car ={max_Speed}\nEngine capacity this car  ={engine_Capacity}\nBrent this car:{brend}\nYear of manufacture of this car={year}\n\n\n\n");
        }
    }


    public class Steamboat: Device
    {
        
        protected double body_Length;//довжина 
        protected double body_width;//ширина пароплава
        protected int numb_Passengers;//кількість пасажирів 

        public Steamboat() : base()
        {
            this.body_Length = 0;
            this.body_width = 0;
            this.numb_Passengers = 0;
        }
        public Steamboat(double body_Length, double body_width,int numb_Passengers, double price, DateTime year, string brend) : base(price, year, brend)
        {
            this.body_Length = body_Length;
            this.body_width = body_width;
            this.numb_Passengers = numb_Passengers;
        }
        public override void Sound()
        { Console.WriteLine("\n\nSh-sh-sh-sh-shsshshs\n"); }
        public override void Show()
        { Console.WriteLine($"A steaboat {brend}\n"); }
        public override void Desc()
        { Console.WriteLine("A steamboat is a boat that is propelled primarily by steam power, usually by driving propellers or paddle wheels.\n"); }
        public void Print()
        {
            Console.WriteLine($"Price this steamboat = {price}\nBody length this steamboat ={body_Length}\nBody width this steamboat ={body_width}\nNumb Passengers on this steamboat ={numb_Passengers}\nBrent this steamboat:{brend}\nYear of manufacture of this steamboat={year}\n\n\n\n");
        }

    }
}
