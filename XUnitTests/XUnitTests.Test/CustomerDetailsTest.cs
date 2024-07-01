using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace XUnitTests.Test
{
    [Collection("Customer")]
    public class CustomerDetailsTest
    {
        private readonly CustomerFixture _customerFixture;
        public CustomerDetailsTest(CustomerFixture customerFixture)
        {
            _customerFixture = customerFixture;
        }
        [Fact]
        public void CheckNameNotNull()
        {
            var cust = _customerFixture.cust;
            Assert.NotNull(cust.Name);
            Assert.False(string.IsNullOrEmpty(cust.Name));
        }

        [Fact]
        public void CheckAgeForDiscount()
        {
            var cust = _customerFixture.cust;
            Assert.InRange(cust.Age, 25, 30);
        }
    }
}
