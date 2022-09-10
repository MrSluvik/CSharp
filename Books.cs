using System;
using System.Collections.Generic;
using System.Text;
using static System.Math;
using static System.Array;

namespace OperatorOverload
{
    class Books
    {
        public string Name { get; set; }
        public Books()
        {
            Name = "";
        }
        public Books(string Name)
        {
            this.Name = Name;
        }
        public override string ToString() 
        {
            return $"Books Name: {Name}\n"; 
        }
    }
    class ListBooks
    {
        private Books[] books;
        public ListBooks(int size)
        {
            books = new Books[size];
        }
        public int Length 
        { 
            get { return books.Length; }         
        }
        public Books this[int index]
        {
            get
            {
                if (index >= 0 && index < books.Length)
                {
                    return books[index];
                }
                throw new IndexOutOfRangeException();
            }
            set
            {
                books[index] = value;
            }
        }
    }
}
