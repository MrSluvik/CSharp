using System;
using System.Collections.Generic;
using System.Text;

namespace OperatorOverload
{
    class Books
    {
        public string Name { get; set; }
        public Books(string Name)
        { 
            this.Name = Name;
        }
        public override string ToString() { return $"Book`s information: {Name}\n"; }
    }
}
