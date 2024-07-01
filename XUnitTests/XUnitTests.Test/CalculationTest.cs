using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace XUnitTests.Test
{
    public class CalculatorFixture:IDisposable
    {
        public Calculation calc = new Calculation();
        public void Dispose()
        {
            //memoryStream.Close();
        }
    }
    public class CalculationTest: IClassFixture<CalculatorFixture>
    {
        private readonly ITestOutputHelper _testOutputHelper;
        private MemoryStream memoryStream;
        private readonly CalculatorFixture _calculatorFixture;
        public CalculationTest(ITestOutputHelper testOutputHelper, CalculatorFixture calculatorFixture)
        {
            _testOutputHelper = testOutputHelper;
            _testOutputHelper.WriteLine("Constructor");
            _calculatorFixture = calculatorFixture;
            memoryStream = new MemoryStream();
        }

        [Fact]
        [Trait("Category", "Fibo")]
        public void FiboDoesNotContainZero()
        {
            _testOutputHelper.WriteLine("FiboDoesNotContainZero");
            var calc = new Calculation();
            Assert.All(calc.FiboNumbers, n => Assert.NotEqual(0, n));
        }

        [Fact]
        [Trait("Category", "Fibo")]
        public void FiboInclude13()
        {
            _testOutputHelper.WriteLine("FiboInclude13");
            var calc = new Calculation();
            Assert.Contains(13, calc.FiboNumbers);
        }

        [Fact]
        [Trait("Category", "Fibo")]
        public void FiboDoesNotInclude4()
        {
            _testOutputHelper.WriteLine("FiboDoesNotInclude4");
            var calc = new Calculation();
            Assert.DoesNotContain(4, calc.FiboNumbers);
        }
        [Fact]
        [Trait("Category", "Fibo")]
        public void CheckFiboNumbers()
        {
            _testOutputHelper.WriteLine("CheckFiboNumbers. Test Starting at {0}", DateTime.Now);
            var allFiboNumbers = new List<int>() { 1, 1, 2, 3, 5, 8, 13 };
            _testOutputHelper.WriteLine("Creating an instance of Calcultion class...");
            var calc = _calculatorFixture.calc;
            _testOutputHelper.WriteLine("Asserting...");
            Assert.Equal(allFiboNumbers, calc.FiboNumbers);
            _testOutputHelper.WriteLine("End");
        }

        
    }
}
