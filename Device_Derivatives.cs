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

       public  Device()
        {
         this.name = "";
         this.price=0;
         this.year =new DateTime(0);
         this.brend = "";
        }       
        public Device(string name , double price, DateTime year, string brend):this()
        {
            this.name= name;
            this.price =price;
            this.year = year;
            this.brend=brend;
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

    class Kettle:Device
    {
        
        protected double volume;//обєм чайника
        Kettle():base()
        {
            this.volume = 0;            
        }
        Kettle(double volume,double price, DateTime year, string brend) :base(price,year,brend)
        {
            this.volume = volume;
        }
        public  override void Sound()
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
}
