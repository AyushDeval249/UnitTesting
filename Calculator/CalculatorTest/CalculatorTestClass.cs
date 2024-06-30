using Calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CalculatorTest
{
    public class CalculatorTestClass
    {
        [Fact] // test
        public void TestAdd()
        {
            Assert.True(true);
        }

        [Fact]
        public void Add_GivenTwoIntValues_ReturnInt()
        {
            Calculators calc = new Calculators();
            int res = calc.Add(1, 2);
            Assert.Equal(3, res);
        }

        [Fact]
        public void Add_GivenTwoDoubleValues_ReturnDouble()
        {
            Calculators calc = new Calculators();
            double res = calc.AddDouble(3.34, 4.44);
            Assert.Equal(7.78, res, 2);
        }

        [Fact]
        public void FiboDoesNotContainZero()
        {
            var calc = new Calculators();
            Assert.All(calc.FiboNumbers, n => Assert.NotEqual(0, n));
        }

        [Fact]
        public void FiboInclude13()
        {
            var calc = new Calculators();
            Assert.Contains(13, calc.FiboNumbers);
        }

        [Fact]
        public void FiboDoesNotInclude4()
        {
            var calc = new Calculators();
            Assert.DoesNotContain(4, calc.FiboNumbers);
        }

        [Fact]
        public void CheckCollection()
        {
            var expectedCollection = new List<int>() { 1, 1, 2, 3, 5, 8, 13 };
            var calc = new Calculators();
            Assert.Equal(expectedCollection, calc.FiboNumbers);
        }
    }
}
