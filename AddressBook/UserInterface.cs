using System;
using System.Collections.Generic;

namespace AddressBook
{
    class UserInterface
    {
        public static void Instructions()
        {
            Console.WriteLine("Address book options:\n" +
                "a - to add a new entry.\n" +
                "s - to search for an entry.\n" +
                "q - to end the program.\n" +
                "c - to clear the console\n" +
                "o - display options\n");
        }
        public static void NewEntry()
        {
            Console.WriteLine("New Entry:");
            Console.WriteLine("");
            Console.WriteLine("type the first name");

            string firstName = Console.ReadLine();
            Console.WriteLine("type the last name");
            string lastName = Console.ReadLine();
            Console.WriteLine("type the phone number");
            int phoneNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("type the address");
            string address = Console.ReadLine();
            Console.WriteLine("type the email");
            string email = Console.ReadLine();
            Person person = new Person(
                firstName,
                lastName,
                phoneNumber,
                address,
                email
            );
            Book.AddPerson(person);
            Console.WriteLine(person.GetInfo());
            
        }
        public static void Search()
        {
            while (true)
            {
                Console.WriteLine("Type the number of the field you want to search\n" +
                    "1 for First Name \n 2 for Last Name \n");
                switch (int.Parse(Console.ReadLine()))
                {
                    case 1:
                        List<Person> book = Book.ShowPeople();
                        Console.WriteLine("Enter First name");
                        string search = Console.ReadLine().ToLower();
                        foreach (Person person in book)
                        {
                            if (person == null)
                            {
                                Console.WriteLine("No entries in book");
                                break;
                            }
                            else if (search == Person.Firstname)
                            {

                            }
                        }
                        break;
                    case 2:
                        break;
                    default:
                        Console.WriteLine("Invalid input!");
                        continue;
                }

            }
        }
    }
}
