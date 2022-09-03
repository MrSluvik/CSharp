using System;
using System.Collections.Generic;
using System.Text;

namespace Imitation
{
    partial class Program
    {
        static void Main4()
        {
            President first = new President(1,"Україна",4,"Зеленський Володимир Олександрович",30000);
            Security second = new Security(2,"Україна",3,"Васильовичч Василь Васильович",15000);
            Manager three = new Manager("Epam", new DateTime(1,6,5),"Шинджи Руслан Русланович",25000);
            Engineer four = new Engineer("УкрБудівництво", new DateTime(2, 6, 5), "Писар Віталій Дмитрович", 30000);

            first.Print();        
                      
            second.Print();
                   
            three.Print();
                     
            four.Print();
        }
    }
    public abstract class Worker
    {
        protected string name;
        protected double salary;
        public Worker()
        {
             this.name="";
            this.salary=0;
        }
        public Worker(string name,double salary)
        {
            this.name = name;
            this.salary = salary;
        }
        public abstract void Print();        
    }
    public class President : Worker
    {
        private int termin;
        private int yearPresident;
        private string country;

        public President( )
        {
           this.termin = 0;
           this.country = "";
           this. yearPresident = 0;
           
        }
        public President(int termin , string country, int yearPresident,string name,  double salary):base( name,salary)
        {
            this.termin = termin;
            this.country = country;
            this.yearPresident = yearPresident;
            this.name = name;
            this.salary = salary;
        }
        public override void Print()
        {
         Console.WriteLine ($"ФІО президента{name}\nЗарплата : {salary}\nТермін презеденства={termin}\nРікпрезедентства={yearPresident}\nПризедент країни{country}");
        }
    }    
        
    public class Security : Worker
    {
    private int zmina;   
    private string countryPlace;

    public Security()
    {
        this.zmina = 0;
        this.countryPlace = "";      

    }
    public Security(int zmina, string country, int yearSecurity, string name, double salary) : base(name, salary)
    {
        this.zmina = zmina;
        this.countryPlace = country;        
        this.name = name;
        this.salary = salary;
    }
    public override void Print()
    {
        Console.WriteLine($"ФІО охоронця:{name}\nЗарплата : {salary}\nУякій зміні працює = {zmina}\nЩо і в якій країні охороняє:{countryPlace}");
    }

    }
    public class Manager : Worker
    {

        private DateTime yearManager;
        private string place;

        public Manager()
        {
            this.yearManager= new DateTime(0,0);
            this.place = "";

        }
        public Manager(string place, DateTime yearManager, string name, double salary) : base(name, salary)
        {
            
            this.place = place;
            this.yearManager = yearManager;
            this.name = name;
            this.salary = salary;
        }
        public override void Print()
        {
            Console.WriteLine($"\nФІО менеджера: {name}\nЯк довго працює:{yearManager}\n Зарплата : {salary}\nУ якій компанії працює :{place}");
        }

    }
    public class Engineer : Worker
    {
        private DateTime yearEngineer;
        private string place;
        public Engineer()
        {
            this.yearEngineer = new DateTime(0, 0);
            this.place = "";
        }
        public Engineer(string place, DateTime yearEngineer, string name, double salary) : base(name, salary)
        {
            this.place = place;
            this.yearEngineer = yearEngineer;
            this.name = name;
            this.salary = salary;
        }
        public override void Print()
        {
            Console.WriteLine($"\nФІО інженера : {name}\nЯк довго працює:{yearEngineer}\n Зарплата : {salary}\nУ якій компанії працює :{place}");
        }


    }    
}
