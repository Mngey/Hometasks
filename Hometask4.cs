using System;

class Assignment1_3
{
    static void Main(string[] args)
    {
        double a = 2, b = 3;
        Console.WriteLine("Please select what you would like to do:\n‘+’ sum both elements;\n’-’: do subtraction;\n’/’: do dividing;\n‘*’: do multiplication;\n‘%’: get remainder when the first element is divided by the second element;\n‘p’: print out both elements;\n‘b’: verify which element is bigger;\n‘s’: verify which element is smaller;");
char option;
if (!char.TryParse(Console.ReadLine(), out option))
        {
            Console.WriteLine("Please use one of the existing options");
            return;
        }
        switch (option)
        {
            case '+':
            Console.WriteLine("a + b = " + (a + b));
            break;
            case '-':
            Console.WriteLine("a - b = " + (a - b));
            break;
            case '/':
            Console.WriteLine("a / b = " + (a / b));
            break;
            case '*':
            Console.WriteLine("a * b = " + (a * b));
            break;
            case '%':
            Console.WriteLine("a % b = " + (a % b));
            break;
            case 'p':
            Console.WriteLine("a is " + a + " and b is " + b);
            break;
          case 'b':
          if (a > b)
            Console.WriteLine("a is bigger than b");
            else if (b > a)
            Console.WriteLine("b is bigger than a");
            break;
             case 's':
             if (a < b)
            Console.WriteLine("a is smaller than b");
            else if (b < a)
            Console.WriteLine("b is smaller than a");
            break;
    }
}
}