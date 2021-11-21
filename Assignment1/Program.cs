// See https://aka.ms/new-console-template for more information
using System;
public class FibonacciSeries
{
    static void Main(string[] args)
    {
        int n = 0, n1 = 1, n2, number;
        Console.WriteLine("Enter the number: ");
        number= Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(n + "\n" + n1 + "");
        for(int i = 0; i < number; i++)
        {
            n2 = n + n1;
            Console.WriteLine(n2 + "");
            n = n1;
            n1 = n2;
        }
    }
}
