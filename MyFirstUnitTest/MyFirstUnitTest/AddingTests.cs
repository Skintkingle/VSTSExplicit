using System;
using MyFirstCode;
using NUnit.Framework;

namespace MyFirstUnitTest
{
    public class AddingTests
    {
        private MyFirstClass _sut;

        [SetUp]
        public void SetupTests()
        {
            _sut = new MyFirstClass();
        }

        [Test]
        [TestCase(1, 1, 2)]
        [TestCase(1, 3, 4)]
        [TestCase(6, 2, 8)]
        [TestCase(14, 32, 46)]
        public void Add_Two_Numbers_Gives_Output(int first, int second, int result)
        {
            Assert.AreEqual(result, _sut.AddSomeNumbers(first, second));
        }

        [Explicit, Test]
        public void Adding_Lots_Of_Numbers_Gives_Output()
        {
            Assert.AreEqual(25000000, _sut.DoAlotOfAdding(5000));
        }
    }
}
