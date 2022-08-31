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
    class Student
    {
        private string fullName;
        private string group;
        private int age;
        private string[][] arrMarks = new string[3][];
        private string score = "";
        public float AVG;

        public Student(string fullName, int age, string group)
        {
            this.fullName = fullName;
            this.age = age;
            this.group = group;
            arrMarks[0] = new string[50];
            arrMarks[1] = new string[76];
            arrMarks[2] = new string[100];
        }

        public void EnterMarks()
        {
            WriteLine();
            WriteLine($"Введіть оцінки студенту по наступним предметам: програмування , адміністрування , дизайн {fullName}");
            WriteLine();

            Write("Введіть через пробіл оцінки по предмету програмування (Приклад:1 2 3): ");
            score = ReadLine();
            arrMarks[0] = score.Split(' ');

            Write("Введіть через пробіл оцінки по предмету  адміністрування (Приклад:1 2 3): ");
            score = ReadLine();
            arrMarks[1] = score.Split(' ');

            Write("Введіть через пробіл оцінки по предмету  дизайн (Приклад:1 2 3): ");
            score = ReadLine();
            arrMarks[2] = score.Split(' ');
        }

        public void PrintRating(int a)
        {
            WriteLine();
            if (a == 1)
            {
                Write($"\tоОцінки по предмету програмування:  ");
                foreach (var score in arrMarks[0])
                {
                    Write($"{score} | ");
                }
                WriteLine();
            }
            else if (a == 2)
            {
                Write($"\tОцінки по предмету  адміністрування:  ");
                foreach (var score in arrMarks[1])
                {
                    Write($"{score} | ");
                }
                WriteLine();
            }
            else if (a == 3)
            {
                Write($"\tОцінки по предмету  дизайн:  ");
                foreach (var score in arrMarks[2])
                {
                    Write($"{score} | ");
                }
                WriteLine();
            }
            else { WriteLine(); }
        }

        public float Avg(int a)
        {
            int Sum = 0;
            int q = 0;
            if (a == 1)
            {
                foreach (var score in arrMarks[0])
                {
                    q++;
                }
                for (int j = 0; j < q; j++)
                {
                    Sum += Convert.ToInt32(arrMarks[0][j]);

                }
                AVG = Sum / q;
                return AVG;
            }
            else if (a == 2)
            {
                foreach (var score in arrMarks[1])
                {
                    q++;
                }
                for (int j = 0; j < q; j++)
                {
                    Sum += Convert.ToInt32(arrMarks[1][j]);
                }
                AVG = Sum / q;
                return AVG;
            }
            else if (a == 3)
            {
                foreach (var score in arrMarks[2])
                {
                    q++;
                }
                for (int j = 0; j < q; j++)
                {
                    Sum += Convert.ToInt32(arrMarks[2][j]);
                }
                AVG = Sum / q;
                return AVG;
            }
            else { return 0; }
        }

        public void StudentInfoPrint()
        {
            WriteLine($"ФІБ студента: {fullName}");
            WriteLine($"Вік студента: {age}");
            WriteLine($"Група: {group}");
            PrintRating(1);
            PrintRating(2);
            PrintRating(3);
            WriteLine();
            WriteLine($"Середній бал по предмету програмування = {Avg(1)}");
            WriteLine($"Середній бал по предмету адміністрування = {Avg(2)}");
            WriteLine($"Середній бал по предмету дизайн = {Avg(3)}");
        }
    }
}
