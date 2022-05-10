using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class PerfectNumber
    {
        public void Number()
        {
            Console.Write("Enter te number for Perfect Number calculation : ");
            int number = Convert.ToInt32(Console.ReadLine());
            int ans = 0;

            //Divisors calculation logic
            Console.Write("Divisors are : ");
            for (int i = 1; i <= (number / 2); i++)
            {
                if (number % i == 0)
                {
                    Console.Write(i + " ");
                    ans += i;
                }
            }
            Console.WriteLine("\nAddition of divisors is : " + ans);
            if (ans == number)
            {
                Console.WriteLine("Number entered and addition of it's divisors is equal\n" +
                    "Therefore, entered number is a Perfect Number");
            }
            else
            {
                Console.WriteLine("Number entered and addition of it's divisors is not equal\n" +
                    "Therefore, entered number is not a Perfect Number");
            }

        }
    }
}
