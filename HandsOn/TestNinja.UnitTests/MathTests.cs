﻿using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class MathTests
    {
        [SetUp]
        public void SetUp() {
            _math = new Math();
        }

        private Math _math;

        [Test]
        [Ignore("For trying out this attribute.")]
        public void Add_WhenCalled_ReturnTheSumOfArguments() {
            var result = _math.Add(1, 2);

            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        [TestCase(2, 1, 2)]
        [TestCase(1, 2, 2)]
        [TestCase(1, 1, 1)]
        public void Max_WhenCalled_ReturnTheGreaterArgument(int a, int b, int expectedResult) {
            var result = _math.Max(a, b);

            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}