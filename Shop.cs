using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace OperatorOverload
{
    class Shop
    {
        public string name { get; set; }
        public string address { get; set; }
        public string description { get; set; }            
        public double area { get; set; }
        public Shop()
        {
            name = "";
            address = "";
            description = "";                   
            area = 0;
        }        
        public Shop(string name, string address, string description, double area)
        {
            this.name = name;
            this.address = address;
            this.description = description;                   
            this.area = area;
        }
     
        public static Shop operator +(Shop first, int n)
        {
            first.area += n;
            return first;
        }
        public static Shop operator -(Shop first, int n)
        {
            first.area -= n;
            return first;
        }
        public static bool operator ==(Shop first, Shop second)
        {
            return first.area == second.area;
        }
        public static bool operator !=(Shop first, Shop second)
        {
            return first.area != second.area;
        }
        public static bool operator >(Shop first, Shop second)
        {
            return first.area > second.area;
        }
        public static bool operator <(Shop first, Shop second)
        {
            return first.area < second.area;
        }
        public override bool Equals(object obj)
        {
            return this.ToString() == obj.ToString();
        }
        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }
        public override string ToString()
        {
            return $"Shop information:\n Name: {name}\n Address: {address}\n " +
                $"Description: {description}\n Area:{area}\n";
        }
    }
}
