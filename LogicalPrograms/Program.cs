using System;

namespace LogicalPrograms
{
    class Program
    {
        public static void Main(string[] args)
        {
            int choice;
            do
            {
                Console.WriteLine("\n1. Fibonacci Series");
                Console.WriteLine("2. Perfect Number");

                Console.WriteLine("0. Exit");
                Console.WriteLine("Enter your choice");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        FibonacciSeries series = new FibonacciSeries();
                        series.Fibonacci();
                        break;
                    case 2:
                        PerfectNumber perfectNumber = new PerfectNumber();
                        perfectNumber.Number();
                        break;
                }
            }while(choice != 0);
        }
    }
}