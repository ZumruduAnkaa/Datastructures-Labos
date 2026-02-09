namespace Datastructures_ConsoleApp;

using Datastructures_ClassLibrary;
using Datastructures_ClassLibrary.UnitTesting;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Datastructures labs !");

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Maak een keuze voor een hoofdstuk / labo:");
            Console.WriteLine("'U' voor Unit testing");
            Console.WriteLine("'S' voor Sorteeralgoritmen");
            Console.WriteLine("'R' voor Recursie");
            Console.WriteLine("'Z' voor Zoekalgoritmen");
            Console.WriteLine("'Q' voor Stack & Queue");
            Console.WriteLine("'L' voor OO datastructuren");
            Console.WriteLine("'G' voor Generics");
            Console.WriteLine("'C' voor Comparers");
            Console.WriteLine("'.' voor .NET structuren");

            string choice = Console.ReadLine();
            switch (choice.ToUpper())
            {
                //TODO:Add a new choice for each lab and call its 'Menu' method
                case "U":
                    //UnitTestingExercises.Menu();
                    Console.WriteLine("overflow demo"); ;

                    short speed = 32760;
                    for (int i = 0; i < 10; i++)
                    {
                        speed++;
                        Console.WriteLine(speed);
                    }

                    Console.WriteLine("Hallo, ik ga voor jouw berekenen of een datum echt bestaat!");

                    while (true)
                    {
                        Console.WriteLine("Geef een datum in");
                        //Get date from user
                        string inputDay = Console.ReadLine();
                        string inputMonth = Console.ReadLine();
                        string inputYear = Console.ReadLine();

                        int day = int.Parse(inputDay);
                        int month = int.Parse(inputMonth);
                        int year = int.Parse(inputYear);

                        Console.WriteLine("Ok bedankt, ik bereken nu razendsnel of deze geldig is");
                        bool exists = DateChecker.CheckIfDateExists(day, month, year);

                        Console.Write($"Tadaaa !! {day}/{month}/{year} is .... ");
                        if (exists)
                        {
                            Console.WriteLine(" geldig ! :-)");
                        }
                        else
                        {
                            Console.WriteLine(" niet geldig ! :-(");
                        }

                        Console.WriteLine();
                    }
                    break;
                case "S":
                    //SortingExercises.Menu();
                    break;
                case "R":
                    //RecursionExercises.Menu();
                    break;
                default:
                    Console.WriteLine("Sorry deze keuze wordt pas in een later labo toegevoegd");
                    Thread.Sleep(1000);
                    break;
            }
        }
    }
}
