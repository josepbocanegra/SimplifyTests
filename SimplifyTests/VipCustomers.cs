using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimplifyTests
{
    public class VipCustomers
    {
        private readonly List<Customer> vipCustomers;

        public VipCustomers()
        {
            vipCustomers = new List<Customer>();
        }

        public void Add(Customer customer)
        {
            vipCustomers.Add(customer);
        }

        public List<string> InAlphabeticalOrder()
        {
            return vipCustomers.OrderBy(c=>c.FullName()).Select(c => c.FullName()).ToList();
        }

        public List<Customer> InAlphabeticalOrderByLastName()
        {
            return vipCustomers.OrderBy(c=>c.LastName).ToList();
        }
    }
}
