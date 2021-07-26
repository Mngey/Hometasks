using System;

class Assignment1_3
{
    static void Main(string[] args)
    {
        int day, month, year;
        Console.WriteLine("What day is it?");
        if (!Int32.TryParse(Console.ReadLine(), out day))
        {
            Console.WriteLine("The date is incorrect");
            return;
        }
        Console.WriteLine("What month is it?");
        if (!Int32.TryParse(Console.ReadLine(), out month))
        {
            Console.WriteLine("The date is incorrect");
            return;
        }
        Console.WriteLine("What year is it?");
        if (!Int32.TryParse(Console.ReadLine(), out year))
        {
            Console.WriteLine("The date is incorrect");
            return;
        }
        if (month == 1 && day > 31)
            Console.WriteLine("Incorrect date");
        if (month == 2 && day > 28)
            Console.WriteLine("Incorrect date");
        if (month == 3 && day > 31)
            Console.WriteLine("Incorrect date");
        if (month == 4 && day > 30)
            Console.WriteLine("Incorrect date");
        if (month == 5 && day > 31)
            Console.WriteLine("Incorrect date");
        if (month == 6 && day > 30)
            Console.WriteLine("Incorrect date");
        if (month == 7 && day > 31)
            Console.WriteLine("Incorrect date");
        if (month == 8 && day > 31)
            Console.WriteLine("Incorrect date");
        if (month == 9 && day > 30)
            Console.WriteLine("Incorrect date");
        if (month == 10 && day > 31)
            Console.WriteLine("Incorrect date");
        if (month == 11 && day > 30)
            Console.WriteLine("Incorrect date");
        if (month == 12 && day > 31)
            Console.WriteLine("Incorrect date");
            if (day <1 || day > 32)
            Console.WriteLine("Incorrect date");
            if (month < 1 || month > 12 )
            Console.WriteLine("Incorrect date");
            if (year < 1)
            Console.WriteLine("Incorrect date");
           int selection;
            Console.WriteLine("Please select the date formatting. 1 - YYYY/MM/DD, 2- YYYY.MM.DD");
            if (!Int32.TryParse(Console.ReadLine(), out selection) && selection < 0 || selection > 2)
        {
            Console.WriteLine("There is no such format");
            return;
        }
if (selection == 1)
Console.WriteLine("Your date is: " year + "/" + month + "/" + day);
else if (selection == 2)
Console.WriteLine("Your date is: " year + "." + month + "." + day);
    }
}
