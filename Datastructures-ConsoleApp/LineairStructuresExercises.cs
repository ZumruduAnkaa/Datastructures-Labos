using Datastructures_ClassLibrary.LineairStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructures_ConsoleApp
{
    public class LineairStructuresExercises
    {
        public static void Menu()
        {
            string choice = "";
            do
            {
                Console.WriteLine("Maak een keuze voor oef. Lineaire datastructuren:");
                Console.WriteLine("'U' voor Queue");
                Console.WriteLine("'S' voor Stack");
                Console.WriteLine("'Q' om terug te gaan");
                choice = Console.ReadLine();
                switch (choice.ToUpper())
                {
                    case "U":
                        DoubleQueue();
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

        private static void SumCalculator()
        {
            Queue q = new Queue(100);
            string input = "";

            Console.WriteLine("Geef getallen in ('Q' om te stoppen):");
            do
            {
                input = Console.ReadLine();
                if (input != "Q")
                    q.Enqueue(int.Parse(input));
            }
            while (input != "Q");

            int som = 0;
            while (!q.IsEmpty)
                som += q.Dequeue();

            Console.WriteLine($"De som is: {som}");
        }

        public static void DoubleQueue()
        {
            QueueString kortQueue = new QueueString(10);
            QueueString langQueue = new QueueString(10);

            Console.WriteLine("Geef 10 woorden in:");

            for (int i = 0; i < 10; i++)
            {
                string woord = Console.ReadLine();

                if (woord.Length <= 5)
                {
                    kortQueue.Enqueue(woord);
                }
                else
                {
                    langQueue.Enqueue(woord);
                }
            }

            Console.WriteLine("Woorden met 5 of minder letters:");
            while (!kortQueue.IsEmpty)
            {
                Console.WriteLine(kortQueue.Dequeue());
            }

            Console.WriteLine("Langere woorden:");
            while (!langQueue.IsEmpty)
            {
                Console.WriteLine(langQueue.Dequeue());
            }
        }
    }
}
