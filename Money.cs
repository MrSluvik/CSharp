using System;
using System.Collections.Generic;
using System.Text;

namespace Imitation
{
    class Money
    {
        public int moneyInt;//поле для цілої частини грошей
        public double moneyDouble;//поле для копійок
        public Currency cur;//поле для енам
        public enum Currency { Dolar,Euro,UAH }

        public Money(Money.Currency cur,int moneyInt,double moneyDouble)
        {
            this.cur = cur;
            this.moneyInt = moneyInt;
            this.moneyDouble = moneyDouble;        

        }
        public void Sum()
        {
            double sum = 0;
            sum = this.moneyDouble + this.moneyInt;
            Console.WriteLine($"{sum}");
        }
        public object Print()
        {
            return cur;
        }


    }
    
}
