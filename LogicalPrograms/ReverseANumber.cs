using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class ReverseANumber
    {
        public void ReverseNumber()
        {
            Console.Write("Enter a number for reversal : ");
            int number = Convert.ToInt32(Console.ReadLine());
            int reverse = 0;

            //Reversing a number logic
            while (number != 0)
            {
                reverse *= 10;
                reverse += number % 10;
                number /= 10;
            }
            Console.WriteLine("Reversed Number is : " + reverse);
        }
    }
}
