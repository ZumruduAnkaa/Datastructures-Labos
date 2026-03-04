using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datastructures_ClassLibrary.Sorting;
using Datastructures_ClassLibrary.Helpers;
using System.Diagnostics;

namespace Datastructures_ClassLibrary.Sorting
{
    public class SortingExercises
    {
        public static void Menu()
        {
            string choice = "";
            do
            {
                Console.WriteLine("Maak een keuze voor oef. Sorteren:");
                Console.WriteLine("'P' voor Performantie meting");
                Console.WriteLine("'Q' om terug te gaan");
                choice = Console.ReadLine();
                switch (choice.ToUpper())
                {
                    case "P":
                        MeetPerformantie();
                        break;
                    case "Q":
                        break;
                    default:
                        Console.WriteLine("Sorry deze oefening ken ik niet...");
                        break;
                }
            }
            while (choice.ToUpper() != "Q");
        }

        private static void MeetPerformantie()
        {
            Console.WriteLine("Hoeveel elementen wenst u te sorteren?");
            int aantal = int.Parse(Console.ReadLine());

            int[] input = RandomArrayGenerator.Generate(aantal, 1, aantal, false);

            Console.WriteLine($"{aantal} willekeurige getallen worden gesorteerd.....");

            Stopwatch sw = new Stopwatch();

            int[] kopie = (int[])input.Clone();
            sw.Restart();
            Quicksort.Sort(kopie);
            sw.Stop();
            Console.WriteLine($"Quick sort had {sw.ElapsedMilliseconds} ms nodig");

            int[] kopie2 = (int[])input.Clone();
            sw.Restart();
            Bubblesort.Sort(kopie2);
            sw.Stop();
            Console.WriteLine($"Bubble sort had {sw.ElapsedMilliseconds} ms nodig");

            int[] kopie3 = (int[])input.Clone();
            sw.Restart();
            Selectionsort.Sort(kopie3);
            sw.Stop();
            Console.WriteLine($"Selection sort had {sw.ElapsedMilliseconds} ms nodig");

            int[] kopie4 = (int[])input.Clone();
            sw.Restart();
            Mergesort.Sort(kopie4);
            sw.Stop();
            Console.WriteLine($"Merge sort had {sw.ElapsedMilliseconds} ms nodig");
        }
    }
}
