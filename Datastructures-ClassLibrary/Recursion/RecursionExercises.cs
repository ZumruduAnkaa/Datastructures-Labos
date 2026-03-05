using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructures_ClassLibrary.Recursion
{
    public class RecursionExercises
    {
        #region menu
        public static void Menu()
        {
            string choice = "";
            do
            {
                Console.WriteLine("Maak een keuze voor oef. Recursie:");
                Console.WriteLine("'C' voor countdown");
                Console.WriteLine("'U' voor countup");
                Console.WriteLine("'Q' om te naar een ander labo te gaan");
                choice = Console.ReadLine();
                switch (choice.ToUpper())
                {
                    case "C":
                        TestCountdown();
                        break;
                    case "U":
                        TestCountup();
                        break;
                    case "Q":
                        break;
                    default:
                        Console.WriteLine("Sorry deze oefening ken ik niet...");
                        break;
                }
            }
            while (choice != "Q");
        }

        public static void TestCountdown()
        {
            Console.WriteLine("Vanaf welk getal wenst u af te tellen ?");
            string input = Console.ReadLine();
            Console.WriteLine("Hier gaan we: ");

            Counter.DoCountdown(int.Parse(input));
        }

        public static void TestCountup()
        {
            Console.WriteLine("Tot welk getal wenst u op te tellen ?");
            string input = Console.ReadLine();
            Console.WriteLine("Hier gaan we: ");

            Counter.UpCounter(int.Parse(input));
            Console.WriteLine();
        }
        #endregion
    }
}
