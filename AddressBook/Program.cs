using System;

namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            UserInterface.Instructions();
            while (true)
            {
                string userInput = Console.ReadLine();
                switch (userInput.ToLower())
                {
                    case  "a":
                        UserInterface.NewEntry();
                        continue; 
                    case "s":
                        UserInterface.Search();
                        continue;
                    case "q":
                        Console.WriteLine("goodbye!");
                        Console.Clear();
                        break;
                    case "c":
                        Console.Clear();
                        continue;
                    case "o":
                        UserInterface.Instructions();
                        continue;
                    default:
                        UserInterface.Instructions();
                        continue;
                }
            }
        }
    }
}
