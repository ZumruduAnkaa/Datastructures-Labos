using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructures_ClassLibrary.Recursion
{
    public class Counter
    {
        public static void DoCountdown(int seconds)
        {
            if (seconds == 0)           // BASE CASE
            {
                Console.WriteLine("Takeoff!");
            }
            else                        // RECURSIEVE CASE
            {
                Console.Write(seconds + "...");
                Thread.Sleep(1000);
                DoCountdown(seconds - 1);  // zichzelf aanroepen!
            }
        }
    }
}
