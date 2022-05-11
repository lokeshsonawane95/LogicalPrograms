using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class StopWatch
    {
        public void Watch()
        {
            //Importing Stopwatch class
            System.Diagnostics.Stopwatch stopwatch = new System.Diagnostics.Stopwatch();

            //Waiting for user to press any key from keyboard to start stopwatch
            Console.WriteLine("Press any key to start stopwatch");
            Console.ReadKey();

            //Startin stopwatch
            stopwatch.Start();

            //Waiting for user to press a key to stop stopwatch
            Console.WriteLine("Press any key to start stopwatch");
            Console.ReadKey();

            //Stop stopwatch
            stopwatch.Stop();
            TimeSpan ts = stopwatch.Elapsed;

            //Declaring elapseTime variable to store stopwatch time in a specific format
            string elapseTime = String.Format("{0:00}:{1:00}:{2:00}:{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);

            //Printing elapsed time from start to stop
            Console.WriteLine("Elapse Time in (hour:minutes:seconds:milliseconds) format is : " + elapseTime);
        }
    }
}
