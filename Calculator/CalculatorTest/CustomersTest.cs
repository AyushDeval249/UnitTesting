using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CalculatorTest
{
    public class CustomersTest
    {
        [Fact]
        public void CheckNameNotNull()
        {
            var cust = new Calculator.Customers();
            Assert.NotNull(cust.Name);
            Assert.False(string.IsNullOrEmpty(cust.Name));
        }

        [Fact]
        public void CheckAgeForDiscount()
        {
            var cust = new Calculator.Customers();
            Assert.InRange(cust.Age, 25, 30);
        }
    }
}
