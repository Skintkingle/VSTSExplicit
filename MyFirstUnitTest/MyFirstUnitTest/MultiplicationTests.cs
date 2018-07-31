using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyFirstCode;
using NUnit.Framework;

namespace MyFirstUnitTest
{
    public class MultiplicationTests
    {
        private MyFirstClass _sut;
        [SetUp]
        public void SetUp()
        {
            _sut = new MyFirstClass {Multiplier = 6};
        }

        [Test]
        public void Multiplying_Gives_Output()
        {
            Assert.AreEqual(12, _sut.MultiplyANumber(2));
        }

        [Explicit, Test]
        public void What_Even_Is_Rounding()
        {
            Assert.AreEqual(int.MaxValue, _sut.MultiplyANumber(int.MaxValue / 6));
        }
    }
}
