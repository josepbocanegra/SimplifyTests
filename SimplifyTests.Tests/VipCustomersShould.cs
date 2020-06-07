using System;
using System.Collections.Generic;
using System.Text;
using ApprovalTests;
using ApprovalTests.Reporters;
using ApprovalTests.Xml;
using Newtonsoft.Json;
using Xunit;

namespace SimplifyTests.Tests
{
    [UseReporter(typeof(DiffReporter))]
    public class VipCustomersShould
    {
        [Fact]
        public void ReturnCustomersFullNameInAlphabeticalOrder()
        {
            var vipCustomers = new VipCustomers();
            vipCustomers.Add(new Customer("Mandy", "Harris"));
            vipCustomers.Add(new Customer("John", "Smith"));
            vipCustomers.Add(new Customer("Albert", "Thomson"));

            var orderedVipCustomers = vipCustomers.InAlphabeticalOrder();

            Approvals.VerifyAll(orderedVipCustomers, "");
        }

        [Fact]
        public void ReturnCustomersInAlphabeticalOrderByLastName()
        {
            var vipCustomers = new VipCustomers();
            vipCustomers.Add(new Customer("Albert", "Thomson"));
            vipCustomers.Add(new Customer("Mandy", "Harris"));
            vipCustomers.Add(new Customer("John", "Smith"));
            
            var orderedVipCustomers = vipCustomers.InAlphabeticalOrderByLastName();

            Approvals.VerifyJson(JsonConvert.SerializeObject(orderedVipCustomers));
        }

        [Fact]
        public void GenerateOrderedXmlReport()
        {
            var vipCustomers = new VipCustomers();
            vipCustomers.Add(new Customer("Albert", "Thomson"));
            vipCustomers.Add(new Customer("Mandy", "Harris"));
            vipCustomers.Add(new Customer("John", "Smith"));

            var report = vipCustomers.Report();

            XmlApprovals.VerifyOrderedXml(report);
        }

    }
}
