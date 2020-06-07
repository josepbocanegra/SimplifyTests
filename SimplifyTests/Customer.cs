using System;
using System.Dynamic;

namespace SimplifyTests
{
    public class Customer
    {
        public Customer()
        {
        }

        public Customer(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            CreationTime = DateTime.UtcNow;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime CreationTime { get; set; }

        public string FullName()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
