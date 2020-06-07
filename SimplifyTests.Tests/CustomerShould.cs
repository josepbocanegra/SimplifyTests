
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace SimplifyTests.Tests
{
    public class CustomerShould
    {
        [Fact]
        public void ShowFullName()
        {
            const string expectedFullName = "John Smith";
            var customer = new Customer("John", "Smith");
            
            var fullName = customer.FullName();
            
            Assert.Equal(expectedFullName, fullName);
        }
    }
}
