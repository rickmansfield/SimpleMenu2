using System;

namespace SimpleMenu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char userChoice;
            Console.WriteLine("Please slect one of the following options");
            Console.WriteLine("1 - Cappucino");
            Console.WriteLine("2 - Latte ");
            Console.WriteLine("3 - Americano ");
            Console.WriteLine("4 - Mocha");
            Console.WriteLine("5 - Macchiato");
            Console.WriteLine("6 - Expresso");
            Console.WriteLine("Q - Quit the program ");

            do
            {
                userChoice = char.ToLower(Console.ReadKey(true).KeyChar);
                Console.WriteLine("You chose " + userChoice);

                switch (userChoice)
                {
                    case '1':
                        Console.WriteLine("Making Cappucinno...");
                        Console.WriteLine("Steam the milk...");
                        Console.WriteLine("Froth the milk...");
                        Console.WriteLine("Make espresso...");
                        Console.WriteLine("Add the milk to the espresso...");
                        break;
                    case '2':
                        Console.WriteLine("Making Latte");
                        Console.WriteLine("Make espresso...");
                        Console.WriteLine("Add the milk to the espresso...");
                        break;
                }
            } while (!userChoice.Equals('q'));
        }
    }
}
