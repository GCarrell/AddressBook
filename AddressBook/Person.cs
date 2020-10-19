using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    class Person
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int PhoneNumber { get; private set; }
        public string Address { get; private set; }
        public string Email { get; private set; }

        public Person(string firstName, string lastName, int phoneNumber, string address, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            Address = address;
            Email = email;
        }

        public string GetInfo()
        {
            return $"First Name: {FirstName}\nLast Name: {LastName}\nPhone Number: {PhoneNumber}\nHome Address: {Address}\nEmail Address: {Email}\n";
            
        }
    }
}
