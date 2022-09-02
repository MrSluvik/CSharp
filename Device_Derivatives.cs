using System;
using System.Collections.Generic;
using System.Text;

namespace Imitation
{
    class Device
    {
        protected string name;
        protected double price;
        protected DateTime day;
        protected string brend;

        Device()
        {
         this.name = "";
         this.price=0;
         this.day =new DateTime(0,0,0);
         this.brend = "";
        }
        Device(string name , double price, DateTime day , string brend):this()
        {
            this.name= name;
            this.price =price;
            this.day= day;
            this.brend=brend;
        }
        protected virtual void Sound() 
        { Console.WriteLine("Yo !"); }
        protected virtual void Show()
        { Console.WriteLine("A car "); }
        protected virtual void Desc()
        { Console.WriteLine("A car .... "); }

    }
}
