using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

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
            return vipCustomers.OrderBy(c => c.FullName()).Select(c => c.FullName()).ToList();
        }

        public List<Customer> InAlphabeticalOrderByLastName()
        {
            return vipCustomers.OrderBy(c => c.LastName).ToList();
        }

        public string Report()
        {
            using (var stringWriter = new StringWriter())
            {
                using (var writer = XmlWriter.Create(stringWriter))
                {
                    var serializer = new XmlSerializer(vipCustomers.GetType());
                    serializer.Serialize(writer, vipCustomers);
                    return stringWriter.ToString();
                }
            }
        }
    }
}
