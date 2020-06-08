using System;
using System.Dynamic;

namespace SimplifyTests
{
    public class Customer
    {
        //For the sake of simplicity for XML test example, lets implement a parameterless constructor and public setters.
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
