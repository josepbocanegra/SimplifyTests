using System;
using ApprovalTests;
using ApprovalTests.Reporters;
using Xunit;

namespace SimplifyTests.Tests
{
    [UseReporter(typeof(DiffReporter))]
    public class SimplifyTestsShould
    {
        [Fact]
        public void SayHello()
        {
            Approvals.Verify("Hello world!");
        }
    }
}
