using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace SoftwareApproach.TestingExtensions.Tests
{
    [TestClass]
    public class DoubleExtensionsTests
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        public void Double_ShouldBeGreaterThanPassTest()
        {
            ((double)0x01).ShouldBeGreaterThan(0x00);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void Double_ShouldBeGreaterThanFailTest()
        {
            ((double)0x44).ShouldBeGreaterThan(0x45);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void Double_ShouldBeGreaterThanFailWhereEqualTest()
        {
            ((double)0x44).ShouldBeGreaterThan(0x44);
        }

        [TestMethod]
        public void Double_ShouldBeGreaterThanOrEqualToPassTest()
        {
            ((double)0x01).ShouldBeGreaterThanOrEqualTo(0x00);
            ((double)0x01).ShouldBeGreaterThanOrEqualTo(0x01);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void Double_ShouldBeGreaterThanOrEqualToFailTest()
        {
            ((double)0x44).ShouldBeGreaterThanOrEqualTo(0x45);
        }

        [TestMethod]
        public void Double_ShouldBeLessThanPassTest()
        {
            ((double)0x01).ShouldBeLessThan(0x02);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void Double_ShouldBeLessThanFailTest()
        {
            ((double)0x44).ShouldBeLessThan(0x43);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void Double_ShouldBeLessThanFailWhereEqualTest()
        {
            ((double)0x44).ShouldBeLessThan(0x44);
        }

        [TestMethod]
        public void Double_ShouldBeLessThanOrEqualToPassTest()
        {
            ((double)0x01).ShouldBeLessThanOrEqualTo(0x02);
            ((double)0x01).ShouldBeLessThanOrEqualTo(0x01);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void Double_ShouldBeLessThanOrEqualToFailTest()
        {
            ((double)0x44).ShouldBeLessThanOrEqualTo(0x43);
        }

        [TestMethod]
        public void Double_ShouldBeBetweenPassTest()
        {
            ((double)0x01).ShouldBeBetween(0x00, 0x05);
            ((double)0x01).ShouldBeBetween(0x01, 0x05);
            ((double)0x01).ShouldBeBetween(0x01, 0x05);
            ((double)0x05).ShouldBeBetween(0x01, 0x05);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Double_ShouldBeBetweenFailWhereLowerGreaterThanUpperTest()
        {
            ((double)0x05).ShouldBeBetween(0x02, 0x01);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Double_ShouldBeBetweenFailWhereLowerEqualToUpperTest()
        {
            ((double)0x05).ShouldBeBetween(0x02, 0x02);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void Double_ShouldBeBetweenFailWhereLessThanLowerTest()
        {
            ((double)0x01).ShouldBeBetween(0x02, 0x05);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void Double_ShouldBeBetweenFailWhereGreaterThanUpperTest()
        {
            ((double)0x06).ShouldBeBetween(0x02, 0x05);
        }

        [TestMethod]
        public void Double_ShouldNotBeBetweenPassTest()
        {
            ((double)0x06).ShouldNotBeBetween(0x00, 0x05);
            ((double)0x00).ShouldNotBeBetween(0x01, 0x05);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Double_ShouldNotBeBetweenFailWhereLowerGreaterThanUpperTest()
        {
            ((double)0x05).ShouldNotBeBetween(0x02, 0x01);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Double_ShouldNotBeBetweenFailWhereLowerEqualToUpperTest()
        {
            ((double)0x05).ShouldNotBeBetween(0x02, 0x02);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void Double_ShouldNotBeBetweenFailTest()
        {
            ((double)0x04).ShouldNotBeBetween(0x02, 0x05);
        }

        [TestMethod]
        public void Double_ShouldBePositivePassTest()
        {
            ((double)3).ShouldBePositive();
            ((double)0).ShouldBePositive();
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void Double_ShouldBePositiveFailTest()
        {
            ((double)-2).ShouldBePositive();
        }

        [TestMethod]
        public void Double_ShouldBeNegativePassTest()
        {
            ((double)-3).ShouldBeNegative();
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void Double_ShouldBeNegativeFailTest()
        {
            ((double)2).ShouldBeNegative();
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void Double_ShouldBeNegativeFailWhereZeroTest()
        {
            ((double)0).ShouldBeNegative();
        }

        [TestMethod]
        public void Double_ShouldBeIntegralPassTest()
        {
            ((double)3.0).ShouldBeIntegral();
            ((double)-3.0).ShouldBeIntegral();
            ((double)0.0).ShouldBeIntegral();
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void Double_ShouldBeIntegralFailTest()
        {
            ((double)3.345).ShouldBeIntegral();
        }

        [TestMethod]
        public void Double_ShouldBeFractionalPassTest()
        {
            ((double)3.5).ShouldBeFractional();
            ((double)-3.3).ShouldBeFractional();
            ((double)0.1).ShouldBeFractional();
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void Double_ShouldBeFractionalFailTest()
        {
            ((double)3.0).ShouldBeFractional();
        }

        [TestMethod]
        public void Double_ShouldRoundToPassTest()
        {
            ((double)3.5).ShouldRoundTo(4);
            ((double)-3.3).ShouldRoundTo(-3);
            ((double)0.1).ShouldRoundTo(0);
            ((double)4).ShouldRoundTo(4);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void Double_ShouldRoundToFailTest()
        {
            ((double)3.1).ShouldRoundTo(4);
        }
    }
}
