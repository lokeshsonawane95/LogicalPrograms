using System;

namespace LogicalPrograms
{
    class Program
    {
        public static void Main(string[] args)
        {
            int choice;

            //This loop will execute until user chooses 0
            do
            {
                Console.WriteLine("\n1. Fibonacci Series");
                Console.WriteLine("2. Perfect Number");
                Console.WriteLine("3. Prime Number");
                Console.WriteLine("4. Reverse a number");
                Console.WriteLine("5. Coupon numbers");
                Console.WriteLine("6. Simulate Stopwatch");
                Console.WriteLine("7. Vending Machine");
                Console.WriteLine("0. Exit");
                Console.Write("Enter your choice : ");
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
                    case 3:
                        PrimeNumber primeNumber = new PrimeNumber();
                        primeNumber.Prime();
                        break;
                    case 4:
                        ReverseANumber reverseANumber = new ReverseANumber();
                        reverseANumber.ReverseNumber();
                        break;
                    case 5:
                        CouponNumbers couponNumbers = new CouponNumbers();
                        couponNumbers.Coupon();
                        break;
                    case 6:
                        StopWatch stopWatch = new StopWatch();
                        stopWatch.Watch();
                        break;
                    case 7:
                        VendingMachine vendingMachine = new VendingMachine();
                        vendingMachine.Driver();
                        break;
                }
            }while(choice != 0);
        }
    }
}