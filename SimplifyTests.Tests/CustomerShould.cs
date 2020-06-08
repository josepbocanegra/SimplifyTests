
using System;
using System.Collections.Generic;
using System.Text;
using ApprovalTests;
using ApprovalTests.Namers;
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

        //Another version of the same test but using Theory
        [Theory]
        [InlineData("Albert", "Thomson")]
        [InlineData("Mandy", "Harris")]
        [InlineData("John", "Smith")]
        public void ShowFullName2(string firstName, string lastName)
        {
            NamerFactory.AdditionalInformation = $"-{firstName}{lastName}";
            var customer = new Customer(firstName, lastName);

            var fullName = customer.FullName();

            Approvals.Verify(fullName);
        }
    }
}
