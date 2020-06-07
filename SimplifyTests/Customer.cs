using System;
using System.Dynamic;

namespace SimplifyTests
{
    public class Customer
    {
        public Customer(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName { get; }
        public string LastName { get; }

        public string FullName()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
