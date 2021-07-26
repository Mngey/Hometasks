using System;

class Assignment1_3
{
    static void Main(string[] args)
    {
        char grade;
        Console.WriteLine("What grade have you got");
        if (!char.TryParse(Console.ReadLine(), out grade))
        {
            Console.WriteLine("Please add the default case in the code!");
            return;
        }
        switch (grade)
        {
            case 'A':
            Console.WriteLine("Perfect! You are so clever!");
            break;
            case 'B':
            Console.WriteLine("Perfect! You are so clever!");
            break;
            case 'C':
            Console.WriteLine("Good! But You can do better!");
            break;
            case 'D':
              Console.WriteLine("It is not good! You should study!");
            break;
            case 'E':
            Console.WriteLine("It is not good! You should study!");
            break;
            case 'F':
            Console.WriteLine("Fail! You need to repeat the exam!");
            break;
            default:
              Console.WriteLine("Please add the default case in the code!");
            break;
        }

    }
}