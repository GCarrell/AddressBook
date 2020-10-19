using System;
using System.Collections.Generic;
using System.Linq;

namespace AddressBook
{
    class Book
    {
        private static readonly List<Person> People = new List<Person>();

        public static void AddPerson(Person information)
        {
            People.Append(information);
        }
        public static List<Person> ShowPeople()
        {
            return People;
        }
    }
}
