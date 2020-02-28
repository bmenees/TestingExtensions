﻿using System;

namespace SoftwareApproach.TestingExtensions
{
    public static partial class ExtensionMethods
    {
        /// <summary>
        /// Asserts that this short value is greater than a certain value.
        /// </summary>
        /// <param name="source">The short value to test.</param>
        /// <param name="comparer">The <i>short</i> to compare to.</param>
        /// <returns>The original <i>short</i> that was tested.</returns>
        public static short ShouldBeGreaterThan(this short source, short comparer)
        {
            return source.ShouldBeGreaterThan(comparer, String.Empty);
        }

        /// <summary>
        /// Asserts that this short value is greater than a certain value.
        /// </summary>
        /// <param name="source">The short value to test.</param>
        /// <param name="comparer">The <i>short</i> to compare to.</param>
        /// <param name="message">A message to display if the assertion fails.</param>
        /// <returns>The original <i>short</i> that was tested.</returns>
        public static short ShouldBeGreaterThan(this short source, short comparer, string message)
        {
            return source.ShouldBeGreaterThan(comparer, message, null);
        }

        /// <summary>
        /// Asserts that this short value is greater than a certain value.
        /// </summary>
        /// <param name="source">The short value to test.</param>
        /// <param name="comparer">The <i>short</i> to compare to.</param>
        /// <param name="message">A message to display if the assertion fails.</param>
        /// <param name="parameters">An array of parameters to use with a formatted message.</param>
        /// <returns>The original <i>short</i> that was tested.</returns>
        public static short ShouldBeGreaterThan(this short source, short comparer, string message, params object[] parameters)
        {
            if (source <= comparer)
                AssertHelper.HandleFail("ShouldBeGreaterThan", message.AppendMessage(Resources.ActualExpectedString, source, comparer), parameters);

            return source;
        }

        /// <summary>
        /// Asserts that this short value is greater than or equal to a certain value.
        /// </summary>
        /// <param name="source">The short value to test.</param>
        /// <param name="comparer">The <i>short</i> to compare to.</param>
        /// <returns>The original <i>short</i> that was tested.</returns>
        public static short ShouldBeGreaterThanOrEqualTo(this short source, short comparer)
        {
            return source.ShouldBeGreaterThanOrEqualTo(comparer, String.Empty);
        }

        /// <summary>
        /// Asserts that this short value is greater than or equal to a certain value.
        /// </summary>
        /// <param name="source">The short value to test.</param>
        /// <param name="comparer">The <i>short</i> to compare to.</param>
        /// <param name="message">A message to display if the assertion fails.</param>
        /// <returns>The original <i>short</i> that was tested.</returns>
        public static short ShouldBeGreaterThanOrEqualTo(this short source, short comparer, string message)
        {
            return source.ShouldBeGreaterThanOrEqualTo(comparer, message, null);
        }

        /// <summary>
        /// Asserts that this short value is greater than or equal to a certain value.
        /// </summary>
        /// <param name="source">The short value to test.</param>
        /// <param name="comparer">The <i>short</i> to compare to.</param>
        /// <param name="message">A message to display if the assertion fails.</param>
        /// <param name="parameters">An array of parameters to use with a formatted message.</param>
        /// <returns>The original <i>short</i> that was tested.</returns>
        public static short ShouldBeGreaterThanOrEqualTo(this short source, short comparer, string message, params object[] parameters)
        {
            if (source < comparer)
                AssertHelper.HandleFail("ShouldBeGreaterThanOrEqualTo", message.AppendMessage(Resources.ActualExpectedString, source, comparer), parameters);

            return source;
        }

        /// <summary>
        /// Asserts that this short value is less than a certain value.
        /// </summary>
        /// <param name="source">The short value to test.</param>
        /// <param name="comparer">The <i>short</i> to compare to.</param>
        /// <returns>The original <i>short</i> that was tested.</returns>
        public static short ShouldBeLessThan(this short source, short comparer)
        {
            return source.ShouldBeLessThan(comparer, String.Empty);
        }

        /// <summary>
        /// Asserts that this short value is less than a certain value.
        /// </summary>
        /// <param name="source">The short value to test.</param>
        /// <param name="comparer">The <i>short</i> to compare to.</param>
        /// <param name="message">A message to display if the assertion fails.</param>
        /// <returns>The original <i>short</i> that was tested.</returns>
        public static short ShouldBeLessThan(this short source, short comparer, string message)
        {
            return source.ShouldBeLessThan(comparer, message, null);
        }

        /// <summary>
        /// Asserts that this short value is less than a certain value.
        /// </summary>
        /// <param name="source">The short value to test.</param>
        /// <param name="comparer">The <i>short</i> to compare to.</param>
        /// <param name="message">A message to display if the assertion fails.</param>
        /// <param name="parameters">An array of parameters to use with a formatted message.</param>
        /// <returns>The original <i>short</i> that was tested.</returns>
        public static short ShouldBeLessThan(this short source, short comparer, string message, params object[] parameters)
        {
            if (source >= comparer)
                AssertHelper.HandleFail("ShouldBeLessThan", message.AppendMessage(Resources.ActualExpectedString, source, comparer), parameters);

            return source;
        }

        /// <summary>
        /// Asserts that this short value is less than or equal to a certain value.
        /// </summary>
        /// <param name="source">The short value to test.</param>
        /// <param name="comparer">The <i>short</i> to compare to.</param>
        /// <returns>The original <i>short</i> that was tested.</returns>
        public static short ShouldBeLessThanOrEqualTo(this short source, short comparer)
        {
            return source.ShouldBeLessThanOrEqualTo(comparer, String.Empty);
        }

        /// <summary>
        /// Asserts that this short value is less than or equal to a certain value.
        /// </summary>
        /// <param name="source">The short value to test.</param>
        /// <param name="comparer">The <i>short</i> to compare to.</param>
        /// <param name="message">A message to display if the assertion fails.</param>
        /// <returns>The original <i>short</i> that was tested.</returns>
        public static short ShouldBeLessThanOrEqualTo(this short source, short comparer, string message)
        {
            return source.ShouldBeLessThanOrEqualTo(comparer, message, null);
        }

        /// <summary>
        /// Asserts that this short value is less than or equal to a certain value.
        /// </summary>
        /// <param name="source">The short value to test.</param>
        /// <param name="comparer">The <i>short</i> to compare to.</param>
        /// <param name="message">A message to display if the assertion fails.</param>
        /// <param name="parameters">An array of parameters to use with a formatted message.</param>
        /// <returns>The original <i>short</i> that was tested.</returns>
        public static short ShouldBeLessThanOrEqualTo(this short source, short comparer, string message, params object[] parameters)
        {
            if (source > comparer)
                AssertHelper.HandleFail("ShouldBeLessThanOrEqualTo", message.AppendMessage(Resources.ActualExpectedString, source, comparer), parameters);

            return source;
        }

        /// <summary>
        /// Asserts that this short value is between two values.
        /// </summary>
        /// <param name="source">The short value to test.</param>
        /// <param name="lowerInclusive">The lower inclusive <i>short</i> to be greater than or equal to.</param>
        /// <param name="upperInclusive">The upper inclusive <i>short</i> to be less than or equal to.</param>
        /// <returns>The original <i>short</i> that was tested.</returns>
        /// <exception cref="ArgumentOutOfRangeException">Thrown if the lowerInclusive argument is greater than or equal to the upperInclusive argument.</exception>
        public static short ShouldBeBetween(this short source, short lowerInclusive, short upperInclusive)
        {
            return source.ShouldBeBetween(lowerInclusive, upperInclusive, String.Empty);
        }

        /// <summary>
        /// Asserts that this short value is between two values.
        /// </summary>
        /// <param name="source">The short value to test.</param>
        /// <param name="lowerInclusive">The lower inclusive <i>short</i> to be greater than or equal to.</param>
        /// <param name="upperInclusive">The upper inclusive <i>short</i> to be less than or equal to.</param>
        /// <param name="message">A message to display if the assertion fails.</param>
        /// <returns>The original <i>short</i> that was tested.</returns>
        /// <exception cref="ArgumentOutOfRangeException">Thrown if the lowerInclusive argument is greater than or equal to the upperInclusive argument.</exception>
        public static short ShouldBeBetween(this short source, short lowerInclusive, short upperInclusive, string message)
        {
            return source.ShouldBeBetween(lowerInclusive, upperInclusive, message, null);
        }

        /// <summary>
        /// Asserts that this short value is between two values.
        /// </summary>
        /// <param name="source">The short value to test.</param>
        /// <param name="lowerInclusive">The lower inclusive <i>short</i> to be greater than or equal to.</param>
        /// <param name="upperInclusive">The upper inclusive <i>short</i> to be less than or equal to.</param>
        /// <param name="message">A message to display if the assertion fails.</param>
        /// <param name="parameters">An array of parameters to use with a formatted message.</param>
        /// <returns>The original <i>short</i> that was tested.</returns>
        /// <exception cref="ArgumentOutOfRangeException">Thrown if the lowerInclusive argument is greater than or equal to the upperInclusive argument.</exception>
        public static short ShouldBeBetween(this short source, short lowerInclusive, short upperInclusive, string message, params object[] parameters)
        {
            if (lowerInclusive >= upperInclusive)
                throw new ArgumentOutOfRangeException("lowerInclusive", Resources.ArgumentOutOfRangeExceptionLowerNotLessThanUpperMessage);
            if (source < lowerInclusive || source > upperInclusive)
                AssertHelper.HandleFail("ShouldBeBetween", message.AppendMessage(Resources.ActualExpectedRangeString, source, lowerInclusive, upperInclusive), parameters);

            return source;
        }

        /// <summary>
        /// Asserts that this short value is between two values.
        /// </summary>
        /// <param name="source">The short value to test.</param>
        /// <param name="lowerExclusive">The lower inclusive <i>short</i> to be less than.</param>
        /// <param name="upperExclusive">The upper inclusive <i>short</i> to be greater than.</param>
        /// <returns>The original <i>short</i> that was tested.</returns>
        /// <exception cref="ArgumentOutOfRangeException">Thrown if the lowerExclusive argument is greater than or equal to the upperExclusive argument.</exception>
        public static short ShouldNotBeBetween(this short source, short lowerExclusive, short upperExclusive)
        {
            return source.ShouldNotBeBetween(lowerExclusive, upperExclusive, String.Empty);
        }

        /// <summary>
        /// Asserts that this short value is between two values.
        /// </summary>
        /// <param name="source">The short value to test.</param>
        /// <param name="lowerExclusive">The lower inclusive <i>short</i> to be less than.</param>
        /// <param name="upperExclusive">The upper inclusive <i>short</i> to be greater than.</param>
        /// <param name="message">A message to display if the assertion fails.</param>
        /// <returns>The original <i>short</i> that was tested.</returns>
        /// <exception cref="ArgumentOutOfRangeException">Thrown if the lowerExclusive argument is greater than or equal to the upperExclusive argument.</exception>
        public static short ShouldNotBeBetween(this short source, short lowerExclusive, short upperExclusive, string message)
        {
            return source.ShouldNotBeBetween(lowerExclusive, upperExclusive, message, null);
        }

        /// <summary>
        /// Asserts that this short value is between two values.
        /// </summary>
        /// <param name="source">The short value to test.</param>
        /// <param name="lowerExclusive">The lower inclusive <i>short</i> to be less than.</param>
        /// <param name="upperExclusive">The upper inclusive <i>short</i> to be greater than.</param>
        /// <param name="message">A message to display if the assertion fails.</param>
        /// <param name="parameters">An array of parameters to use with a formatted message.</param>
        /// <returns>The original <i>short</i> that was tested.</returns>
        /// <exception cref="ArgumentOutOfRangeException">Thrown if the lowerExclusive argument is greater than or equal to the upperExclusive argument.</exception>
        public static short ShouldNotBeBetween(this short source, short lowerExclusive, short upperExclusive, string message, params object[] parameters)
        {
            if (lowerExclusive >= upperExclusive)
                throw new ArgumentOutOfRangeException("lowerExclusive", Resources.ArgumentOutOfRangeExceptionLowerNotLessThanUpperMessage);
            if (source >= lowerExclusive && source <= upperExclusive)
                AssertHelper.HandleFail("ShouldNotBeBetween", message.AppendMessage(Resources.ActualExpectedRangeString, source, lowerExclusive, upperExclusive), parameters);

            return source;
        }

        /// <summary>
        /// Asserts that this short value is positive or zero.
        /// </summary>
        /// <param name="source">The short value to test.</param>
        /// <returns>The original <i>short</i> that was tested.</returns>
        public static short ShouldBePositive(this short source)
        {
            return source.ShouldBePositive(String.Empty);
        }

        /// <summary>
        /// Asserts that this short value is positive or zero.
        /// </summary>
        /// <param name="source">The short value to test.</param>
        /// <param name="message">A message to display if the assertion fails.</param>
        /// <returns>The original <i>short</i> that was tested.</returns>
        public static short ShouldBePositive(this short source, string message)
        {
            return source.ShouldBePositive(message, null);
        }

        /// <summary>
        /// Asserts that this short value is positive or zero.
        /// </summary>
        /// <param name="source">The short value to test.</param>
        /// <param name="message">A message to display if the assertion fails.</param>
        /// <param name="parameters">An array of parameters to use with a formatted message.</param>
        /// <returns>The original <i>short</i> that was tested.</returns>
        public static short ShouldBePositive(this short source, string message, params object[] parameters)
        {
            if (source < 0)
                AssertHelper.HandleFail("ShouldBePositive", message.AppendMessage(Resources.ActualString, source), parameters);

            return source;
        }

        /// <summary>
        /// Asserts that this short value is negative.
        /// </summary>
        /// <param name="source">The short value to test.</param>
        /// <returns>The original <i>short</i> that was tested.</returns>
        public static short ShouldBeNegative(this short source)
        {
            return source.ShouldBeNegative(String.Empty);
        }

        /// <summary>
        /// Asserts that this short value is negative.
        /// </summary>
        /// <param name="source">The short value to test.</param>
        /// <param name="message">A message to display if the assertion fails.</param>
        /// <returns>The original <i>short</i> that was tested.</returns>
        public static short ShouldBeNegative(this short source, string message)
        {
            return source.ShouldBeNegative(message, null);
        }

        /// <summary>
        /// Asserts that this short value is negative.
        /// </summary>
        /// <param name="source">The short value to test.</param>
        /// <param name="message">A message to display if the assertion fails.</param>
        /// <param name="parameters">An array of parameters to use with a formatted message.</param>
        /// <returns>The original <i>short</i> that was tested.</returns>
        public static short ShouldBeNegative(this short source, string message, params object[] parameters)
        {
            if (source >= 0)
                AssertHelper.HandleFail("ShouldBeNegative", message.AppendMessage(Resources.ActualString, source), parameters);

            return source;
        }
    }
}
