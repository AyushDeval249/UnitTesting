using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XUnitTests
{
    public class Customers
    {
        public virtual int GetOrdersByName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Hello");
            }
            return 100;
        }
        public string Name => "Ayush";
        public int Age => 25;
    }

    public class LoyalCustomer : Customers
    {
        public int Discount { get; set; }
        public LoyalCustomer()
        {
            Discount = 10;
        }
        public override int GetOrdersByName(string name)
        {
            return 101;
        }
    }

    public static class CustomerFactory
    {
        public static Customers CreateCustomerInstance(int orderCount)
        {
            if (orderCount <= 100)
                return new Customers();
            else
                return new LoyalCustomer();
        }
    }
}
