using System;
using System.Collections.Generic;
using System.Text;

namespace Imitation
{
    class Device
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

    class Kettle : Device
    {

        protected double volume;//обєм чайника
        Kettle() : base()
        {
            this.volume = 0;
        }
        Kettle(double volume, double price, DateTime year, string brend) : base(price, year, brend)
        {
            this.volume = volume;
        }
        public override void Sound()
        { Console.WriteLine("Whistle"); }
        public override void Show()
        { Console.WriteLine($"A Kettle {brend}"); }
        public override void Desc()
        { Console.WriteLine("A kettle is a vessel with a handle and spout, a lid (although there are exceptions), which is used for brewing tea or boiling water. "); }
        public void Print()
        {
            Console.WriteLine($"Price this kettle = {price}\nVolume this kettle ={volume}\nBrent this kettle:{brend}\nYear of manufacture of this kettle={year}");
        }
    }

    class Microwave : Device
    {

        private int power_Levels;//кількість рівнів потужності
        private string function;//функції печі  типу розморожування ,захист від дітей 

        Microwave() : base()
        {
            this.power_Levels = 0;
            this.function = "";
        }
        Microwave(string function, int power_Levels, double price, DateTime year, string brend) : base(price, year, brend)
        {
            this.function = function;
            this.power_Levels = power_Levels;
        }
        public override void Sound()
        { Console.WriteLine("Beep"); }
        public override void Show()
        { Console.WriteLine($"A Microwave {brend}"); }
        public override void Desc()
        { Console.WriteLine("A microwave oven is a household electrical appliance for quick cooking or quick heating of food, as well as for defrosting it."); }
        public void Print()
        {
            Console.WriteLine($"Price this microwave = {price}\nFunction this microwave ={function}\nPower levels ={power_Levels}\nBrent this microwave:{brend}\nYear of manufacture of this microwave={year}");
        }

    }

    class Car : Device
    {

        protected int max_Speed;
        protected double engine_Capacity;

        Car() : base()
        {
            this.max_Speed = 0;
            this.engine_Capacity=0;
        }
        Car(double engine_Capacity, int max_Speed, double price, DateTime year, string brend) : base(price, year, brend)
        {
            this.max_Speed = max_Speed;
            this.engine_Capacity = engine_Capacity;
        }
        public override void Sound()
        { Console.WriteLine("Gu-Gu-gu"); }
        public override void Show()
        { Console.WriteLine($"A car  {brend}"); }
        public override void Desc()
        { Console.WriteLine("A car is a self-propelled wheeled vehicle that is driven by an engine installed in it and is intended for the transportation of people, cargo."); }
        public void Print()
        {
            Console.WriteLine($"Price this car = {price}\nMax speed this car ={max_Speed}\nEngine capacity this car  ={engine_Capacity}\nBrent this car:{brend}\nYear of manufacture of this car={year}");
        }

    }
}
