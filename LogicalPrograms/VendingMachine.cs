using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class VendingMachine
    {
        static int amount = 0;
        static int totalNotes = 0, noteIndex = 0;

        //Recursion logic as provided in the question
        public int Calculate(int amount, int[] notes)
        {
            int remaining;
            if (amount == 0)
            {
                return -1;
            }
            else
            {
                //Calculation program for each note in notes array
                if (amount >= notes[noteIndex])
                {
                    int calculateNotes = amount / notes[noteIndex];
                    remaining = amount % notes[noteIndex];
                    amount = remaining;
                    totalNotes += calculateNotes;
                    Console.WriteLine("Total Rs. " + notes[noteIndex] + " notes : " + calculateNotes);
                }
                noteIndex++;

                //Recursion call
                return Calculate(amount, notes);
            }
        }

        //Main driver code of the program
        public void Driver()
        {
            Console.Write("Enter the change in Rs. you want : ");
            amount = Convert.ToInt32(Console.ReadLine());

            //Declaring notes array for different notes
            int[] notes = { 1000, 500, 100, 50, 10, 5, 2, 1 };
            VendingMachine vendingMachine = new VendingMachine();

            //Calling Calculate method to perform operation
            vendingMachine.Calculate(amount, notes);
            Console.WriteLine("Total number of notes needed : " + totalNotes);
        }
    }
}
