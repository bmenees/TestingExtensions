using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SoftwareApproach.TestingExtensions.Tests
{
    [TestClass]
    public class TestingExceptionsTests
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        public void Testing_ExceptionsPassTest()
        {
            int zero = 0;
            Testing.ShouldThrowException<DivideByZeroException>(() => { int y = 15 / zero; });
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void Testing_ExceptionNotActualExceptionFailedTest()
        {
            int zero = 0;
            Testing.ShouldThrowException<Exception>(() => { int y = 15 / zero; });
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void Testing_ExceptionDifferentExceptionFailedTest()
        {
            int zero = 0;
            Testing.ShouldThrowException<InvalidCastException>(() => { int y = 15 / zero; });
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void Testing_ExceptionNoExceptionThrownFailedTest()
        {
            int divisor = 3;
            Testing.ShouldThrowException<DivideByZeroException>(() => { int y = 15 / divisor; });
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Testing_ExceptionWhereActionNullFailedTest()
        {
            Testing.ShouldThrowException<DivideByZeroException>(null);
        }
    }
}
