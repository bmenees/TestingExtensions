using System;
using System.Globalization;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SoftwareApproach.TestingExtensions
{
    /// <summary>
    /// Contains methods to help with creating assertions.
    /// </summary>
    public static class AssertHelper
    {
        /// <summary>
        /// Creates a custom <see cref="AssertFailedException"/> and provides information for the exception.
        /// </summary>
        /// <param name="assertionName">The name of the assertion (typically the name of the assertion method).</param>
        /// <param name="message">A message for the assertion.</param>
        /// <param name="parameters">An array of parameters to use with a formatted message.</param>
        /// <exception cref="ArgumentNullException"><i>assertionName</i> is null</exception>
        /// <exception cref="ArgumentException"><i>assertionName</i> is an empty string</exception>
        public static void AssertFailed(string assertionName, string message, params object[] parameters)
        {
            if (String.IsNullOrEmpty(assertionName))
            {
                if (assertionName == null)
                {
                    throw new ArgumentNullException("assertionName");
                }
                else
                {
                    throw new ArgumentException("cannot be null or empty", "assertionName");
                }
            }

            HandleFail(assertionName, message ?? String.Empty, parameters);
        }

        internal static void HandleFail(string assertionName, string message, params object[] parameters)
        {
            Type t = typeof(Assert);
            MethodInfo mi = t.GetMethod("HandleFail", BindingFlags.Static | BindingFlags.NonPublic);
            try
            {
                mi.Invoke(null, new object[] { assertionName, message, parameters });
            }
            catch (TargetInvocationException ex)
            {
                throw ex.InnerException;
            }
        }

        internal static string AppendMessage(this string source, string message, params object[] parameters)
        {
            string messageString = String.Format(CultureInfo.CurrentCulture, message, parameters);
            return String.Format(CultureInfo.CurrentCulture, "{0} {1}", messageString, source);
        }
    }
}
