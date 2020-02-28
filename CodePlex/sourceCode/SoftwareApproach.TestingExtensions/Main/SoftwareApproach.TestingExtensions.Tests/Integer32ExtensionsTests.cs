using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace SoftwareApproach.TestingExtensions.Tests
{
    [TestClass]
    public class Integer32ExtensionsTests
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        public void Int_ShouldBeGreaterThanPassTest()
        {
            ((int)0x01).ShouldBeGreaterThan(0x00);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void Int_ShouldBeGreaterThanFailTest()
        {
            ((int)0x44).ShouldBeGreaterThan(0x45);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void Int_ShouldBeGreaterThanFailWhereEqualTest()
        {
            ((int)0x44).ShouldBeGreaterThan(0x44);
        }

        [TestMethod]
        public void Int_ShouldBeGreaterThanOrEqualToPassTest()
        {
            ((int)0x01).ShouldBeGreaterThanOrEqualTo(0x00);
            ((int)0x01).ShouldBeGreaterThanOrEqualTo(0x01);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void Int_ShouldBeGreaterThanOrEqualToFailTest()
        {
            ((int)0x44).ShouldBeGreaterThanOrEqualTo(0x45);
        }

        [TestMethod]
        public void Int_ShouldBeLessThanPassTest()
        {
            ((int)0x01).ShouldBeLessThan(0x02);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void Int_ShouldBeLessThanFailTest()
        {
            ((int)0x44).ShouldBeLessThan(0x43);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void Int_ShouldBeLessThanFailWhereEqualTest()
        {
            ((int)0x44).ShouldBeLessThan(0x44);
        }

        [TestMethod]
        public void Int_ShouldBeLessThanOrEqualToPassTest()
        {
            ((int)0x01).ShouldBeLessThanOrEqualTo(0x02);
            ((int)0x01).ShouldBeLessThanOrEqualTo(0x01);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void Int_ShouldBeLessThanOrEqualToFailTest()
        {
            ((int)0x44).ShouldBeLessThanOrEqualTo(0x43);
        }

        [TestMethod]
        public void Int_ShouldBeBetweenPassTest()
        {
            ((int)0x01).ShouldBeBetween(0x00, 0x05);
            ((int)0x01).ShouldBeBetween(0x01, 0x05);
            ((int)0x01).ShouldBeBetween(0x01, 0x05);
            ((int)0x05).ShouldBeBetween(0x01, 0x05);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Int_ShouldBeBetweenFailWhereLowerGreaterThanUpperTest()
        {
            ((int)0x05).ShouldBeBetween(0x02, 0x01);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Int_ShouldBeBetweenFailWhereLowerEqualToUpperTest()
        {
            ((int)0x05).ShouldBeBetween(0x02, 0x02);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void Int_ShouldBeBetweenFailWhereLessThanLowerTest()
        {
            ((int)0x01).ShouldBeBetween(0x02, 0x05);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void Int_ShouldBeBetweenFailWhereGreaterThanUpperTest()
        {
            ((int)0x06).ShouldBeBetween(0x02, 0x05);
        }

        [TestMethod]
        public void Int_ShouldNotBeBetweenPassTest()
        {
            ((int)0x06).ShouldNotBeBetween(0x00, 0x05);
            ((int)0x00).ShouldNotBeBetween(0x01, 0x05);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Int_ShouldNotBeBetweenFailWhereLowerGreaterThanUpperTest()
        {
            ((int)0x05).ShouldNotBeBetween(0x02, 0x01);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Int_ShouldNotBeBetweenFailWhereLowerEqualToUpperTest()
        {
            ((int)0x05).ShouldNotBeBetween(0x02, 0x02);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void Int_ShouldNotBeBetweenFailTest()
        {
            ((int)0x04).ShouldNotBeBetween(0x02, 0x05);
        }

        [TestMethod]
        public void Int_ShouldBePositivePassTest()
        {
            ((int)3).ShouldBePositive();
            ((int)0).ShouldBePositive();
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void Int_ShouldBePositiveFailTest()
        {
            ((int)-2).ShouldBePositive();
        }

        [TestMethod]
        public void Int_ShouldBeNegativePassTest()
        {
            ((int)-3).ShouldBeNegative();
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void Int_ShouldBeNegativeFailTest()
        {
            ((int)2).ShouldBeNegative();
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void Int_ShouldBeNegativeFailWhereZeroTest()
        {
            ((int)0).ShouldBeNegative();
        }
    }
}
