using System;

class Assignment2_1
{
    static void Main(string[] args)
    {
int day;
Console.WriteLine("Which day of the week is it?");
if (!Int32.TryParse(Console.ReadLine(), out day))
        {
            Console.WriteLine("Please add correct verification in the code!");
            return;
        }
        switch (day)
        {
            case 1:
            Console.WriteLine("It is a working day");
            break;
            case 2:
            Console.WriteLine("It is a working day");
            break;
            case 3:
            Console.WriteLine("It is a working day");
            break;
            case 4:
            Console.WriteLine("It is a working day");
            break;
            case 5:
            Console.WriteLine("It is a working day");
            break;
            case 6:
            Console.WriteLine("It is holiday");
            break;
             case 7:
            Console.WriteLine("It is holiday");
            break;
            default:
            Console.WriteLine("Please add correct verification in the code!");
            break;
        }
    }
}