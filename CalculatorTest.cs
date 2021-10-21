using System;
using NUnitDemoLib;
using NUnit.Framework;



namespace NUnitTestLib
{
    [TestFixture]
    public class CalculatorTest
    {
        Calculator calculator;
       
        [SetUp]

       /* public void Setup()
        {
            calculator = new Calculator();
        }
        [TearDown]
        public void Teardown()

       {
            //write code which runs after evry test method
        }
       */
        [Test]

        public void Test_Addition_Valid_integers()
        {
            Calculator calculator = new Calculator();
            int result = calculator.Adition(5, 8);
            //Assert.AreEqual(expected,actual)
            Assert.AreEqual(13, result);
        }
        //batch testing

        [TestCase(1,2,3)]
        [TestCase(0,0,0)]
        [TestCase(-1,-1,-2)]

        public void Test_Addition_multiple(int first,int second,int expected)
        {
            Calculator calculator = new Calculator();
            int result = calculator.Adition(first, second);
            Assert.AreEqual(expected, result);

        }
        //Exception Testing
        [Test]
        public void Test_Subtraction_ArgumentException()
        {
            Calculator calculator = new Calculator();
            //sub class instance is allowed
            //Assert.Catch<SystemException>(()=>calculator.Subtraction(3,5));

            //exact exception match
            //Assert.Throws<SystemException>(()=>calculator.Subtraction(3,5));
            Assert.Throws<ArgumentException>(() => calculator.Subtraction(3, 5));
        }

    }

    
}
