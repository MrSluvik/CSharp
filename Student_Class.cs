using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
namespace Structure_Classes_Properties
{
    partial class Program
    {
        static void Main5()
        {
            Student student = new Student("Олег", 22, "П-202");

            student.EnterMarks();
            WriteLine();
            student.StudentInfoPrint();

        }
    }
