using CalculatorApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalcTests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod()]
        public void AddTest()
        {
            //Arrange
            double getal1 = 4.55;
            double getal2 = 3.45;
            double expected = 8.00;
            Calculator calc = new Calculator();
            //Act
            double actual = calc.Add(getal1, getal2);
            //Assert
            Assert.AreEqual(expected, actual, "Added not correctly");
        }
        [TestMethod()]
        public void SubtractTest()
        {
            //Arrange
            double getal1 = 4.55;
            double getal2 = 3.45;
            double expected = 1.10;
            Calculator calc = new Calculator();
            //Act
            double actual = calc.Subtract(getal1, getal2);
            //Assert
            Assert.AreEqual(expected, actual,0.001, "Substracted not correctly");
        }

        [TestMethod()]
        public void MultiplyTest()
        {
            //Arrange
            double getal1 = 4.55;
            double getal2 = 3.45;
            double expected = 15.6975;
            Calculator calc = new Calculator();
            //Act
            double actual = calc.Multiply(getal1, getal2);
            //Assert
            Assert.AreEqual(expected, actual, "Multiplied not correctly");
        }

        [TestMethod()]
        public void DivideTest()
        {
            //Arrange
            double getal1 = 8;
            double getal2 = 2;
            int getal3 = 0;
            double expected = 4;
            Calculator calc = new Calculator();
            //Act
            double actual = calc.Divide(getal1, getal2);
            //Assert
            Assert.AreEqual(expected, actual, "Divided not correctly");
            //Act 
            try
            {
                calc.Divide(getal1, getal3);
            }
            catch (System.ArgumentException e)
            {
                //Assert
                StringAssert.Contains(e.Message, "Cannot divide by zero!");
                return;
            }
            Assert.Fail("The expected exception was not thrown");
        }
    }
}
