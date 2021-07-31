using System;

namespace Arrays2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] newArr = { 10, 4, -4, 7, 0, 9, 1, 3, 7, -5 };
            // int i = 0;
            // while (true)
            // { 
            //     if (i > newArr.Length - 1)
            //         break;
            //     if (newArr[i] < 0){
            //         Console.Write(newArr[i] + " ");
            //     i++;
            //     }
            // }

            Console.Write("The negative numbers in the array are: ");
            for (int i = 0; i < newArr.Length; i++)
            {
                if (newArr[i] < 0)
                    Console.Write(newArr[i] + " ");
            }

            Console.Write("\nThe uneven numbers of the array are: ");
            for (int y = 0; y < newArr.Length; y++)
            {
                if (newArr[y] % 2 != 0)
                    Console.Write(newArr[y] + " ");
            }
            int uneven = 0;
            int a = 0;
            while (true)
            {
                if (newArr[a] % 2 != 0)
                    uneven++;
                a++;
                if (a > newArr.Length - 1)
                    break;
            }
            Console.Write("\nThe amount of uneven numbers in the array are: " + uneven + " ");

            for (int s = 0; s < newArr.Length; s++)
            {
                //create nested loop for compare current values with actual value of arr
                for (int j = s + 1; j < newArr.Length; j++)
                {

                    //and here we put our condition
                    if (newArr[s] == newArr[j])
                    {
                        Console.WriteLine("\nThere are multiple elements with the value of " + newArr[s]);
                    }
                }
            }
            Console.Write("Each second element in the array is: ");
            int w = 1;
            do
            {
                if (w > newArr.Length - 1)
                    break;
                Console.Write(newArr[w] + " ");
                w += 2;

            } while (true);
            int sum = 0;
            foreach (int element in newArr)
            sum = sum + element;
            sum = sum / newArr.Length;
            Console.WriteLine("\nThe average value of elemenets in the array is " + sum);

            int smaller = 0;
            for (int i = 0; i < newArr.Length; i++)
            if (newArr[i] < sum)
            {smaller ++;}
            Console.WriteLine("The amount of elements smaller than the average is " + smaller);
        }
    }
}