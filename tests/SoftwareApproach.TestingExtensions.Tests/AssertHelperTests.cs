using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace SoftwareApproach.TestingExtensions.Tests
{
    [TestClass]
    public class AssertHelperTests
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AssertFailed_should_throw_argument_exception_if_assertionName_is_null()
        {
            AssertHelper.AssertFailed(null, "test", "test");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void AssertFailed_should_throw_argument_exception_if_assertionName_is_empty_string()
        {
            AssertHelper.AssertFailed(String.Empty, "test", "test");
        }

        [TestMethod]
        public void AssertFailed_should_create_assertion_failure()
        {
            string assertionName = "TestAssertion";
            string message = "TestMessage: {0}";
            string param = "TestParam";

            bool exceptionCaught = false;
            try
            {
                AssertHelper.AssertFailed(assertionName, message, param);
            }
            catch (AssertFailedException afe)
            {
                exceptionCaught = true;
                Assert.IsTrue(afe.Message.Contains(assertionName));
                Assert.IsTrue(afe.Message.Contains(String.Format(message, param)));
            }
            if (!exceptionCaught) Assert.Fail("AssertFailed did not throw an exception as expected.");
        }

        [TestMethod]
        public void AssertHelper_HandleFailTest()
        {
            bool exceptionCaught = false;
            try
            {
                AssertHelper.HandleFail("TestAssertion", "Test Message: {0}", "Test Param");
            }
            catch (AssertFailedException afe)
            {
                exceptionCaught = true;
                Assert.IsTrue(afe.Message.Contains("TestAssertion"));
                Assert.IsTrue(afe.Message.Contains("Test Message"));
                Assert.IsTrue(afe.Message.Contains("Test Param"));
            }

            if (!exceptionCaught) Assert.Fail("HandleFail did not throw an exception as expected.");
        }

        [TestMethod]
        public void AssertHelper_AppendMessageTest()
        {
            string actual = AssertHelper.AppendMessage("SourceString", "SomeMessage: {0}", "SomeParam");
            string expected = "SomeMessage: SomeParam SourceString";
            Assert.AreEqual(expected, actual);
        }
    }
}
