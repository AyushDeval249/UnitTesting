using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using XUnitTests;


namespace XUnitTests.Test
{
    [Collection("Customer")]
    public class CustomersTest
    {
        private readonly CustomerFixture _customerFixture;
        public CustomersTest(CustomerFixture customerFixture)
        {
            _customerFixture = customerFixture;
        }
        [Fact]
        public void GetOrdersByNameNotNull()
        {
            var cust = _customerFixture.cust;
            var exceptionDetails = Assert.Throws<ArgumentException>(() => cust.GetOrdersByName(""));
            Assert.Equal("Hello", exceptionDetails.Message);
        }

        [Fact]
        public void LoyalCustomerForOrdersG100()
        {
            var cust = CustomerFactory.CreateCustomerInstance(102);
            //Assert.IsType(typeof(LoyalCustomer), cust);
            var loyalCustomer = Assert.IsType<LoyalCustomer>(cust);
            Assert.Equal(10, loyalCustomer.Discount);
        }
    }
}
