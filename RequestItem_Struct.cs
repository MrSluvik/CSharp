using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Structure_Classes_Properties
{

    struct RequestItem
    {

        public int count;
        public Article ar;

        public RequestItem(Article ar, int count)
        {

            this.count = count;
            this.ar = ar;
        }


        public void Print()
        {
            ar.Print();
            WriteLine($"количество единиц товара: {count}\n\n");
        }
    }
}
