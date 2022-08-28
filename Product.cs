using System;
using System.Collections.Generic;
using System.Text;

namespace Imitation
{
    class Product:Money
    {
        public double Price;
        private Prod prod;//поле для енам
        public enum Prod { Phone,Laptop,T_shirt,Snikers }
        
        public Product(Money.Currency cur, int moneyInt, double moneyDouble, Product.Prod prod ,double Price):base(cur,moneyInt, moneyDouble)
        {
            this.prod = prod;
            this.Price = Price;

        }

        public double Discount(double a)
        {
            this.Price -= a;
            return this.Price;
        }

        public double Money_()
        {
            double newMoney = 0;
            double money = this.moneyDouble+this.moneyInt;
            if (money - this.Price >= 0)
            {
                newMoney = money - this.Price;
                return newMoney;
            }
            else
            {               
                return -1;
            }
        }
        public object PrintProduct()
        {
            return prod;
        }
    }
}
