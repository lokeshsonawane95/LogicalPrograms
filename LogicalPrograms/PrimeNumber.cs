using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class PrimeNumber
    {
        public void Prime()
        {
            Console.Write("Enter the number to check if it is a Prime or not : ");
            int number = Convert.ToInt32(Console.ReadLine());
            int n = 0, flag = 0;

            //2 is the only even prime we have
            if (number == 2)
            {
                Console.WriteLine("The numbe is a Prime Number");
            }

            //Prime number calculation logic for number greater than 2
            if (number > 2)
            {
                for (int i = 2; i < number / 2; i++)
                {
                    if (number % i == 0)
                    {
                        flag = 1;
                        break;
                    }
                }
                if (flag == 1)
                {
                    Console.WriteLine("Entered number is not a Prime Number");
                }
                else
                {
                    Console.WriteLine("Entered number is a Prime Number");
                }
            }
            else
            {
                Console.WriteLine("Entered number is less than 2");
            }
        }
    }
}
