using System;
using System.Collections.Generic;
using System.Text;

namespace Imitation
{
    partial class Program
    {
        static void Main3()
        { 
            Violino first = new Violino(4,2000,"Angelo","Стринний");
            Tromboneo second = new Tromboneo("Тенор", 2000, "Yamaha Allegro",  "Духовний");
            Ukulele three = new Ukulele("Концертна", 2200, "Diamond Head DU-250C", "Стринний");
            Violoncello four = new Violoncello("Контрабас",15000,"Stentor","Стринний-смичковий");

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

    public class Music_Instrument
    {
        protected string name;
        protected string brend;
        protected double price;
        protected string type_instrument;
        public Music_Instrument()
        {
            this.name = "";
            this.price = 0;
            this.brend = "";
            this.type_instrument = "";
        }
        public Music_Instrument(string name, double price, string brend, string type_instrument) : this()
        {
            this.name = name;
            this.price = price;
            this.brend = brend;
            this.type_instrument = type_instrument;
        }
        public Music_Instrument(double price, string brend, string type_instrument) : this()
        {
            this.price = price;
            this.brend = brend;
            this.type_instrument = type_instrument;
        }

        public virtual void Sound()
        { Console.WriteLine("!"); }
        public virtual void Show()
        { Console.WriteLine(""); }
        public virtual void Desc()
        { Console.WriteLine(""); }
        public virtual void History()
        { Console.WriteLine(""); } 
    }
        public class Violino : Music_Instrument
        {

            protected int nStrun;//кількість струн 
            public Violino() : base()
            {
                this.nStrun = 0;
            }
            public Violino(int nStrun, double price, string brend, string type_instrument) : base(price, brend, type_instrument)
            {
                this.nStrun = nStrun;
                this.price = price;
                this.brend = brend;
                this.type_instrument = type_instrument;
            }
            public override void Sound()
            { Console.WriteLine("скрип скрип!"); }
            public override void Show()
            { Console.WriteLine("Скрипка "); }
            public override void Desc()
            { Console.WriteLine("струнний музичний смичковий інструмент. Має чотири струни, які настроюють на квінту (g, d1,a1,e2)."); }
            public override void History()
            { Console.WriteLine("Прототипами скрипки були арабський ребаб і німецька рота, злиття яких і утворило віолу. Форми скрипки сформувались до XVI століття; в цьому столітті і на початку наступного, XVII, творили майстри скрипок сімейства Аматі. Їх інструменти відрізняються прекрасною формою і чудовим матеріалом. Взагалі Італія славилася виробництвом скрипок, серед яких скрипки Страдіварі і Гварнері нині цінуються надзвичайно високо."); }

            public void Print()
            {
                Console.WriteLine($"Ціна скрипки  = {price}\nБренд скрипки:{brend}\nКількість струн скрипки:{nStrun}\nТип музичного інструменту:{type_instrument}\n\n\n");
            }
        }


        public class Tromboneo : Music_Instrument
        {

            protected string varieties;//різновиди тромбонів
            public Tromboneo() : base()
            {
                this.varieties = "";
            }
            public Tromboneo(string varieties, double price, string brend, string type_instrument) : base(price, brend, type_instrument)
            {
                this.varieties = varieties;
                this.price = price;
                this.brend = brend;
                this.type_instrument = type_instrument;
            }
            public override void Sound()
            { Console.WriteLine("тутутуиуиу!"); }
            public override void Show()
            { Console.WriteLine("Тромбон "); }
            public override void Desc()
            { Console.WriteLine("Тромбон - музичний інструмент, що відноситься до сімейства духових, був створений в 15 столітті."); }
            public override void History()
            { Console.WriteLine("Поява тромбона відноситься до XV століття. Прийнято вважати, що безпосередніми попередниками цього інструменту були кулісні труби, при грі на яких музикант мав можливість пересувати трубку інструменту, таким чином отримуючи хроматичний звукоряд. Такі труби використовувалися для подвоєння голосів церковного хору з огляду на схожість тембру труби з людським голосом. Потрібно було досягти подібності інтонації, навіщо і зробили кулісу, що дає хроматизм і вібратор"); }
            public void Print()
            {
                Console.WriteLine($"Ціна тромбона = {price}\nБренд тромбона:{brend}\nРізновид тромбона:{varieties}\nТип музичного інструменту:{type_instrument}\n\n\n\n");
            }
        }

        public class Ukulele : Music_Instrument
        {

            protected string varieties;//сопрано концурт тенор
            public Ukulele() : base()
            {
                this.varieties = "";
            }
            public Ukulele(string varieties, double price, string brend, string type_instrument) : base(price, brend, type_instrument)
            {
                this.varieties = varieties;
                this.price = price;
                this.brend = brend;
                this.type_instrument = type_instrument;
            }
            public override void Sound()
            { Console.WriteLine("діньдіньдінь!"); }
            public override void Show()
            { Console.WriteLine("Укулєлє "); }
            public override void Desc()
            { Console.WriteLine("Укуле́ле — чотириструнний щипковий музичний інструмент, зазвичай з нейлонними струнами."); }
            public override void History()
            { Console.WriteLine("Перші прообрази укулеле з'явилися у Європі, у середині 15 століття. У ті роки було добре розвинене виробництво струнних інструментів, але більш складні гітари і мандоліни, були досить коштовними, особливо для бродячих музик. Попит народжує пропозицію, і на ринку почали з'являтися зменшені гітари з усього чотирма струнами — кавакіньо, які стали прообразом укулеле.У 19 столітті багато людей перебиралося у «Новий світ». Разом з переселенцями, у Новому світі з'явилися і їх музичні інструменти. Сама назва «укулеле» з'явилося на Гаваях, і у перекладі з гавайського це «стрибаюча блоха». Виробляти інструмент почали на місці, з гавайської акації — коа, яку на острові вважали символом Гаваїв.Своє поширення і популярність укулеле отримали після гастролей гавайських музик на Тихоокеанській виставці 1915 року у Сан - Франциско."); }
            public void Print()
            {
                Console.WriteLine($"Ціна укулеле = {price}\nБренд укулеле:{brend}\nРізновид укулеле:{varieties}\nТип музичного інструменту: {type_instrument}\n\n\n\n");
            }
        }

        public class Violoncello : Music_Instrument
        {

            protected string varieties;//сопрано концурт тенор
            public Violoncello() : base()
            {
                this.varieties = "";
            }
            public Violoncello(string varieties, double price, string brend, string type_instrument) : base(price, brend, type_instrument)
            {
                this.varieties = varieties;
                this.price = price;
                this.brend = brend;
                this.type_instrument = type_instrument;
            }
            public override void Sound()
            { Console.WriteLine("тихіший скрип скрип!"); }
            public override void Show()
            { Console.WriteLine("Віолончель "); }
            public override void Desc()
            { Console.WriteLine("Віолонче́ль — струнний смичковий музичний інструмент, родини скрипкових, басо-тенорового регістру."); }
            public override void History()
            { Console.WriteLine("Поява віолончелі відноситься до початку XVI століття. Спочатку вона застосовувалася як басовий інструмент для супроводу співу або виконання на інструменті вищого регістру. Існували численні різновиди віолончелі, що відрізнялися один від одного розмірами, кількістю струн, строєм (найчастіше зустрічалася настройка на тон нижче сучасної).У XVII—XVIII століттях зусиллями видатних музичних майстрів італійських шкіл(Ніколо Аматі, Джузеппе Гварнері, Антоніо Страдіварі, Карло Бергонці, Матео Гофрілєра, Доменіко Монтаньяна та ін.) була створена класична модель віолончелі з твердо усталеним розміром корпусу."); }
            public void Print()
            {
                Console.WriteLine($"Ціна віолончелі = {price}\nБренд віолончелі:{brend}\nРізновид віолончелі:{varieties}\nТип музичного інструменту:{type_instrument}\n\n\n\n");
            }
        }
}

