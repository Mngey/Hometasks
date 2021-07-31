using System;
using System.Linq;

namespace Arrays2
{
    class Task3
    {
        static void Main(string[] args)
        {
            int[] grades = new int[10];

            int a = 0;

            Console.WriteLine("Enter 10 grades:");

            while (a < 10)
            {
                if (int.TryParse(Console.ReadLine(), out grades[a]) && grades[a] > -1 && grades[a] < 11)
                    a++;
                else
                    Console.WriteLine("You didn't enter a grade! Please enter again!");
            }
            int aced = 0;
            int fail = 0;
            for (int i = 0; i < grades.Length; i++)
            {
                if (grades[i] < 4)
                    fail += 1;
                if (grades[i] == 10)
                    aced += 1;
            }
            Console.WriteLine("The number of students failed: " + fail + "\nThe nember of students got an \"A\": " + aced);
            for (int i = 0; i <= grades.Length; i++)
            {
                var grade = grades.Count(n => n == i);
                Console.WriteLine(grade + " students with the grade " + i);
            }
        }

    }
}
