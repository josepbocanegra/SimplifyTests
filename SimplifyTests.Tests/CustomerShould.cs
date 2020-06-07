
using System;
using System.Collections.Generic;
using System.Text;
using ApprovalTests;
using ApprovalTests.Reporters;
using Xunit;

namespace SimplifyTests.Tests
{
    [UseReporter(typeof(DiffReporter))]
    public class CustomerShould
    {
        [Fact]
        public void ShowFullName()
        {
            var customer = new Customer("John", "Smith");
            
            var fullName = customer.FullName();
            
            Approvals.Verify(fullName);
        }
    }
}
