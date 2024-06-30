using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CalculatorTest
{
    public class NamesTest
    {
        [Fact]
        public void GetFullName_Take2Strings_ReturnString()
        {
            Calculator.Names name = new Calculator.Names();
            var res = name.GetFullName("Ayush", "Deval");
            Assert.Equal("Ayush Deval", res, ignoreCase:true);
            Assert.StartsWith("Ayush", res);
            Assert.Matches("[A-Z]{1}[a-z]+ [A-Z]{1}[a-z]+", res);
        }
    }
}
