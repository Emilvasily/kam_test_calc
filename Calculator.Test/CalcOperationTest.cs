using Calculator.Core;
using Calculator.Core.Infrastructure;
using Xunit;

namespace Calculator.Test
{
    public class CalcOperationTest
    {
        CalcOperation calculator;
        public CalcOperationTest()
        {
            calculator = new CalcOperation();
        }

        [Theory]
        [InlineData(3, 4, 7)]
        [InlineData(-3, 4, 1)]
        public void Addition(double a,double b,double result)
        {
            calculator.Before = a;
            calculator.Operation = SimpleOperation.Addition;
            calculator.Before = b;

            Assert.Equal(calculator.After, result);
            calculator.Clear();
        }

        [Theory]
        [InlineData(2, 1, 1)]
        [InlineData(22, 20, 2)]
        public void Substraction(double a, double b, double result)
        {
            calculator.Before = a;
            calculator.Operation = SimpleOperation.Substraction;
            calculator.Before = b;

            Assert.Equal(calculator.After, result);
            calculator.Clear();
        }
    }
}
