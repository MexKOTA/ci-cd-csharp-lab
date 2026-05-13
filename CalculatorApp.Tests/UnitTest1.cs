using Xunit;
using CalculatorApp;

namespace CalculatorApp.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Add_ReturnCorrectSum()
        {
            Calculator calc = new Calculator();
            int result = calc.add(1, 2);
            Assert.Equal(3, result);
        }
    }
}