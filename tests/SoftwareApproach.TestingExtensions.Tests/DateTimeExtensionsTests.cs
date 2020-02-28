using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SoftwareApproach.TestingExtensions.Tests
{
    [TestClass]
    public class DateTimeExtensionsTests
    {
        [TestMethod]
        public void DateTime_ShouldBeBeforePassTest()
        {
            DateTime.MinValue.ShouldBeBefore(DateTime.MaxValue);
            DateTime.Now.AddSeconds(-1).ShouldBeBefore(DateTime.Now);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void DateTime_ShouldBeBeforeFailTest()
        {
            DateTime.MaxValue.ShouldBeBefore(DateTime.MinValue);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void DateTime_ShouldBeBeforeFailWhereEqualTest()
        {
            DateTime.MinValue.ShouldBeBefore(DateTime.MinValue);
        }

        [TestMethod]
        public void DateTime_ShouldBeBeforeOrSameAsPassTest()
        {
            DateTime.MinValue.ShouldBeBeforeOrSameAs(DateTime.MaxValue);
            DateTime.MinValue.ShouldBeBeforeOrSameAs(DateTime.MinValue);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void DateTime_ShouldBeBeforeOrSameAsFailTest()
        {
            DateTime.MaxValue.ShouldBeBeforeOrSameAs(DateTime.MinValue);
        }

        [TestMethod]
        public void DateTime_ShouldBeAfterPassTest()
        {
            DateTime.MaxValue.ShouldBeAfter(DateTime.MinValue);
            DateTime.Now.AddHours(1).ShouldBeAfter(DateTime.Now);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void DateTime_ShouldBeAfterFailTest()
        {
            DateTime.MinValue.ShouldBeAfter(DateTime.MaxValue);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void DateTime_ShouldBeAfterFailWhereEqualTest()
        {
            DateTime.MinValue.ShouldBeAfter(DateTime.MinValue);
        }

        [TestMethod]
        public void DateTime_ShouldBeAfterOrSameAsPassTest()
        {
            DateTime.MaxValue.ShouldBeAfterOrSameAs(DateTime.MinValue);
            DateTime.MinValue.ShouldBeAfterOrSameAs(DateTime.MinValue);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void DateTime_ShouldBeAfterOrSameAsFailTest()
        {
            DateTime.MinValue.ShouldBeAfterOrSameAs(DateTime.MaxValue);
        }
    }
}
