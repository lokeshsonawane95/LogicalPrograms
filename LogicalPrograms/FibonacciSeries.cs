using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class FibonacciSeries
    {
        public void Fibonacci()
        {
            Console.Write("Enter number of terms (terms > 2) up to which you want Fibonacci Series : ");
            int terms = Convert.ToInt32(Console.ReadLine());
            int first = 0, second = 1;
            int next = first + second;
            if (terms > 2)
            {
                Console.Write("Fibonacci series is up to " + terms + " terms is : {0}, {1}, ", first, second);
                for (int i = 3; i <= terms; i++)
                {
                    if (i == terms)
                    {
                        Console.Write(next);
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.Write(next + ", ");
                        first = second;
                        second = next;
                        next = first + second;
                    }
                }
            }
            else
            {
                Console.WriteLine("Entered number is either negative or too small fo Fibonacci Series");
            }
        }
    }
}
