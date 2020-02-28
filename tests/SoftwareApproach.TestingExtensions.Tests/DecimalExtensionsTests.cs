using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace SoftwareApproach.TestingExtensions.Tests
{
    [TestClass]
    public class DecimalExtensionsTests
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        public void Decimal_ShouldBeGreaterThanPassTest()
        {
            ((decimal)0x01).ShouldBeGreaterThan(0x00);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void Decimal_ShouldBeGreaterThanFailTest()
        {
            ((decimal)0x44).ShouldBeGreaterThan(0x45);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void Decimal_ShouldBeGreaterThanFailWhereEqualTest()
        {
            ((decimal)0x44).ShouldBeGreaterThan(0x44);
        }

        [TestMethod]
        public void Decimal_ShouldBeGreaterThanOrEqualToPassTest()
        {
            ((decimal)0x01).ShouldBeGreaterThanOrEqualTo(0x00);
            ((decimal)0x01).ShouldBeGreaterThanOrEqualTo(0x01);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void Decimal_ShouldBeGreaterThanOrEqualToFailTest()
        {
            ((decimal)0x44).ShouldBeGreaterThanOrEqualTo(0x45);
        }

        [TestMethod]
        public void Decimal_ShouldBeLessThanPassTest()
        {
            ((decimal)0x01).ShouldBeLessThan(0x02);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void Decimal_ShouldBeLessThanFailTest()
        {
            ((decimal)0x44).ShouldBeLessThan(0x43);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void Decimal_ShouldBeLessThanFailWhereEqualTest()
        {
            ((decimal)0x44).ShouldBeLessThan(0x44);
        }

        [TestMethod]
        public void Decimal_ShouldBeLessThanOrEqualToPassTest()
        {
            ((decimal)0x01).ShouldBeLessThanOrEqualTo(0x02);
            ((decimal)0x01).ShouldBeLessThanOrEqualTo(0x01);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void Decimal_ShouldBeLessThanOrEqualToFailTest()
        {
            ((decimal)0x44).ShouldBeLessThanOrEqualTo(0x43);
        }

        [TestMethod]
        public void Decimal_ShouldBeBetweenPassTest()
        {
            ((decimal)0x01).ShouldBeBetween(0x00, 0x05);
            ((decimal)0x01).ShouldBeBetween(0x01, 0x05);
            ((decimal)0x01).ShouldBeBetween(0x01, 0x05);
            ((decimal)0x05).ShouldBeBetween(0x01, 0x05);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Decimal_ShouldBeBetweenFailWhereLowerGreaterThanUpperTest()
        {
            ((decimal)0x05).ShouldBeBetween(0x02, 0x01);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Decimal_ShouldBeBetweenFailWhereLowerEqualToUpperTest()
        {
            ((decimal)0x05).ShouldBeBetween(0x02, 0x02);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void Decimal_ShouldBeBetweenFailWhereLessThanLowerTest()
        {
            ((decimal)0x01).ShouldBeBetween(0x02, 0x05);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void Decimal_ShouldBeBetweenFailWhereGreaterThanUpperTest()
        {
            ((decimal)0x06).ShouldBeBetween(0x02, 0x05);
        }

        [TestMethod]
        public void Decimal_ShouldNotBeBetweenPassTest()
        {
            ((decimal)0x06).ShouldNotBeBetween(0x00, 0x05);
            ((decimal)0x00).ShouldNotBeBetween(0x01, 0x05);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Decimal_ShouldNotBeBetweenFailWhereLowerGreaterThanUpperTest()
        {
            ((decimal)0x05).ShouldNotBeBetween(0x02, 0x01);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Decimal_ShouldNotBeBetweenFailWhereLowerEqualToUpperTest()
        {
            ((decimal)0x05).ShouldNotBeBetween(0x02, 0x02);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void Decimal_ShouldNotBeBetweenFailTest()
        {
            ((decimal)0x04).ShouldNotBeBetween(0x02, 0x05);
        }

        [TestMethod]
        public void Decimal_ShouldBePositivePassTest()
        {
            ((decimal)3).ShouldBePositive();
            ((decimal)0).ShouldBePositive();
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void Decimal_ShouldBePositiveFailTest()
        {
            ((decimal)-2).ShouldBePositive();
        }

        [TestMethod]
        public void Decimal_ShouldBeNegativePassTest()
        {
            ((decimal)-3).ShouldBeNegative();
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void Decimal_ShouldBeNegativeFailTest()
        {
            ((decimal)2).ShouldBeNegative();
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void Decimal_ShouldBeNegativeFailWhereZeroTest()
        {
            ((decimal)0).ShouldBeNegative();
        }

        [TestMethod]
        public void Decimal_ShouldBeIntegralPassTest()
        {
            ((decimal)3.0).ShouldBeIntegral();
            ((decimal)-3.0).ShouldBeIntegral();
            ((decimal)0.0).ShouldBeIntegral();
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void Decimal_ShouldBeIntegralFailTest()
        {
            ((decimal)3.345).ShouldBeIntegral();
        }

        [TestMethod]
        public void Decimal_ShouldBeFractionalPassTest()
        {
            ((decimal)3.5).ShouldBeFractional();
            ((decimal)-3.3).ShouldBeFractional();
            ((decimal)0.1).ShouldBeFractional();
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void Decimal_ShouldBeFractionalFailTest()
        {
            ((decimal)3.0).ShouldBeFractional();
        }

        [TestMethod]
        public void Decimal_ShouldRoundToPassTest()
        {
            ((decimal)3.5).ShouldRoundTo(4);
            ((decimal)-3.3).ShouldRoundTo(-3);
            ((decimal)0.1).ShouldRoundTo(0);
            ((decimal)4).ShouldRoundTo(4);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void Decimal_ShouldRoundToFailTest()
        {
            ((decimal)3.1).ShouldRoundTo(4);
        }
    }
}
