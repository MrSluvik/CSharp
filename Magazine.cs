using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace OperatorOverload
{
    public class Magazine
    {
          private string publishing_House { get; set; }
          private int numb_Sold_Copies { get; set; }
          private string name_Magazine { get; set; }
          private string magazine_Direction { get; set; }
          private bool local_Global { get; set; }
          public int numb_Employees { get; set; }

            public Magazine()
            {
                this.name_Magazine = "";
                this.publishing_House = "";
                this.numb_Sold_Copies = 0;
                this.magazine_Direction = "";
                this.local_Global = true;
                this.numb_Employees = 0;
            }

            public Magazine(string name_Magazine, string publishing_House, int numb_Sold_Copies, string magazine_Direction, bool local_Global, int numb_Employees) : this()
            {
                this.name_Magazine = name_Magazine;
                this.publishing_House = publishing_House;
                this.numb_Sold_Copies = numb_Sold_Copies;
                this.magazine_Direction = magazine_Direction;
                this.local_Global = local_Global;
                this.numb_Employees = numb_Employees;
            }

            public static Magazine operator +(Magazine m1, int numb)
            {
                m1.numb_Employees += numb;
                return m1;
            }
            public static Magazine operator -(Magazine m1, int numb)
            {
                m1.numb_Employees -= numb;
                return m1;

            }

            public override bool Equals(object obj)
            {
                return this.ToString() == obj.ToString();
            }
            public override int GetHashCode()
            {
                return this.ToString().GetHashCode();
            }

            public static bool operator ==(Magazine m1, Magazine m2)
            {
                return m1.numb_Employees.Equals(m2.numb_Employees);
            }
            public static bool operator !=(Magazine m1, Magazine m2)
            {
                return !(m1.numb_Employees == m2.numb_Employees);
            }

            public static bool operator <(Magazine m1, Magazine m2)
            {
                return m1.numb_Employees < m2.numb_Employees;
            }
            public static bool operator >(Magazine m1, Magazine m2)
            {
                return m1.numb_Employees > m2.numb_Employees;
            }

           public override string ToString()
           {
            return $"Shop information:\n name Magazine: {name_Magazine}\n publishingHouse: {publishing_House}\n " +
                $"numb Sold Copies: {numb_Sold_Copies}\n magazine Direction: {magazine_Direction}\n local_Global: {local_Global}\n numb Employees: {numb_Employees}\n";
           }



        }
}

