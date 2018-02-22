using System;
using MathematicsLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathematicsLibrary.Tests
{
    [TestClass()]
    public class MathLibTests
    {
        MathLib mathlib;
        double errorFactor; 

        [TestInitialize]//* Don't forget to initialize your test
        public void Initialization()
        {
            mathlib = new MathLib();
            errorFactor = 0.001; //this will hold to each Method below
        }
        //*Remember: Remove [Ignore]
        [TestMethod()]
        public void AddTest()
        {
            Assert.AreEqual(4.5, mathlib.Add(1.5, 3.0), errorFactor);
            //Assert.AreEqual(X, mathlib.Method(a, b)); // X is chosen as answer, a and b are defined in the class lib
            Assert.AreEqual(9.0, mathlib.Add(4.5, 4.5), errorFactor);
            Assert.AreEqual(1.4, mathlib.Add(2.7, -1.3), errorFactor);  //", 0.1" added at the end as a margin of error
        }
        [TestMethod()]
        public void SubtractTest()
        {
            Assert.AreEqual(4.2, mathlib.Subtract(7.4, 3.2), errorFactor);
            Assert.AreEqual(-7.8, mathlib.Subtract(-9.3, -1.5), errorFactor);
            Assert.AreEqual(23.8, mathlib.Subtract(20.1, -3.7), errorFactor);
        }
        //[Ignore]
        [TestMethod()]
        public void MultTest()
        {
            Assert.AreEqual(15, mathlib.Multiply(3, 5), errorFactor);
            Assert.AreEqual(45, mathlib.Multiply(3, 15), errorFactor);
            Assert.AreEqual(5, mathlib.Multiply(1, 5), errorFactor);
        }
        //[Ignore]
        [TestMethod()]
        public void DiviTest()
        {
            Assert.AreEqual(3.5, mathlib.Divide(14, 4), errorFactor);
            Assert.AreEqual(1.5, mathlib.Divide(6, 4), errorFactor);
            Assert.AreEqual(2.5, mathlib.Divide(10, 4), errorFactor);
            Assert.AreEqual(4.5, mathlib.Divide(18, 4), errorFactor);
        }
        //[Ignore]
        [TestMethod()]
        public void SquaTest()
        {
            Assert.AreEqual(16, mathlib.Square(4), errorFactor);
            Assert.AreEqual(4, mathlib.Square(2), errorFactor);
            Assert.AreEqual(25, mathlib.Square(5), errorFactor);
        }
        //[Ignore]
        [TestMethod()]
        public void InveTest()
        {
            Assert.AreEqual(.25, mathlib.Inverse(4), errorFactor);
            Assert.AreEqual(.5, mathlib.Inverse(2), errorFactor);
            Assert.AreEqual(.2, mathlib.Inverse(5), errorFactor);
        }
        //[Ignore]
        [TestMethod()]
        public void NegaTest()
        {
            Assert.AreEqual(4, mathlib.Negate(-4), errorFactor);
            Assert.AreEqual(2, mathlib.Negate(-2), errorFactor);
            Assert.AreEqual(-5, mathlib.Negate(5), errorFactor);
        }
        [TestMethod()]
        public void HalfTest()
        {
            Assert.AreEqual(4, mathlib.Halved(8), errorFactor);
            Assert.AreEqual(2, mathlib.Halved(4), errorFactor);
            Assert.AreEqual(-5, mathlib.Halved(-10), errorFactor);
        }
        [TestMethod()]
        public void QuarTest()
        {
            Assert.AreEqual(4, mathlib.Quarter(16), errorFactor);
            Assert.AreEqual(2, mathlib.Quarter(8), errorFactor);
            Assert.AreEqual(-5, mathlib.Quarter(-20), errorFactor);
        }
    }
}

