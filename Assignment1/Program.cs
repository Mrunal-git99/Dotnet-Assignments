// See https://aka.ms/new-console-template for more information
using System;
public class MonthExample
{
    static void Main(string[] args)
    {
        int month;
        char ch;
        do
        {
            Console.WriteLine("Enter month");
            month = Convert.ToInt32(Console.ReadLine());
            switch (month)
            {
                case 1:
                    Console.WriteLine("31 days in momth");
                    break;

                case 2:
                    Console.WriteLine("29 days in month");
                    break;

                case 3:
                    Console.WriteLine("31 days in momth");
                    break;

                case 4:
                    Console.WriteLine("30 days in momth");
                    break;

                case 5:
                    Console.WriteLine("31 days in momth");
                    break;

                case 6:
                    Console.WriteLine("30 days in momth");
                    break;

                case 7:
                    Console.WriteLine("31 days in momth");
                    break;

                case 8:
                    Console.WriteLine("31 days in momth");
                    break;

                case 9:
                    Console.WriteLine("30 days in momth");
                    break;

                case 10:
                    Console.WriteLine("31 days in momth");
                    break;

                case 11:
                    Console.WriteLine("30 days in momth");
                    break;

                case 12:
                    Console.WriteLine("31 days in momth");
                    break;

                default:
                    Console.WriteLine("Invalid Month");
                    break;
            }
            Console.WriteLine("Enter Y or y to continue");
            ch = Convert.ToChar(Console.ReadLine());
        }
        while (ch == 'Y' || ch == 'y');
    }
}


