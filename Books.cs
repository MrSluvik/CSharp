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
        public void Add(string Name, int index)
        {
            books.SetValue(new Books (Name), index);
        }
        public int FindElement(string Name)
        {
            int i = 0;
            foreach (Books item in books)
            {
                if (item.Name ==Name) 
                {
                    return i;
                }
                i++;
            }
            return -1;
        }
        public void Delete(string Name)
        {
            int index = FindElement(Name);
            Array.Clear(books, index, 1);
        }
        public void Print()
        {
            for (int i = 0; i < books.Length; i++)
            {
                if (books[i] == null)
                {
                  continue;
                }
                else
                {
                    Console.WriteLine($"{books[i].Name}");
                }
            }       
        }
    }
}
