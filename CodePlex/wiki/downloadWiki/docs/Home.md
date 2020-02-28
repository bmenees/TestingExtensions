## Project Description
The Visual Studio Testing Extensions is a library that exposes a set of extension methods to provide a way to write more readable unit tests in the Visual Studio Unit Testing environment.  It is developed in C# 4.0 and requires the .NET 4.0 runtime.

## Latest News
**Now on NuGet:** [http://nuget.org/List/Packages/VisualStudioTestingExtensions](http://nuget.org/List/Packages/VisualStudioTestingExtensions)

## Documentation
Detailed documentation can be found here: [Documentation](Documentation) 

## Summary
This project was created to add to the basic assertions that unit testing in Visual Studio (VS) provides.  In VS, the way to do unit testing assertions is to write test code such as the following:

{code:c#}
[TestMethod](TestMethod)
public void OldWay_Test()
{
   int number = 5;
   Assert.AreEqual(number, 5);
   Assert.IsTrue(number > 4);
   Assert.IsTrue(number > -1);
}
{code:c#}

While this approach is sufficient for most cases, I was looking to provide a more readable way to write unit tests.  This library contains a number or extension methods that allow you to perform assertions using the following syntax:

{code:c#}
[TestMethod](TestMethod)
public void NewWay_Test()
{
   int number = 5;
   number.ShouldEqual(5);
   number.ShouldBeGreaterThan(4);
   number.ShouldBePositive();
}
{code:c#}

Another feature of this library is the ability to chain assertions.  Each assertion method returns the original source value, so the same test above can also be written the following way:

{code:c#}
[TestMethod](TestMethod)
public void NewWay_Test()
{
   int number = 5;
   number.ShouldEqual(5) 
      .ShouldBeGreaterThan(4)
      .ShouldBePositive();
}
{code:c#}

When an assertion fails, the failure notification is the same behavior that VS provides out of the box, displaying the assertion that caused the failure and the arguments associated with the assertion.

The other feature that this library provides is the ability to assert multiple expected exceptions in a single test method, rather than being limited to one expected exception like VS provides.  You can provide the snippet to test for an exception via an Action() delegate.  An example of this is shown below:

{code:c#}
[TestMethod](TestMethod)
public void Testing_ExceptionsTest()
{
   int zero = 0;
   Testing.ShouldThrowException<DivideByZeroException>(() => { int y = 15 / zero; });
   Testing.ShouldThrowException<ArgumentNullException>(() => { throw new ArgumentNullException(); });
}
{code:c#}

The source release for this project contains a complete suite of unit tests to validate the expected functionality that the library provides.  In addition, the unit tests are a good example of the various extension methods that the library provides.

If you are interested in contributing to this project, please let me know.  
There will also be more information on the project available here: [http://blogs.msdn.com/miah](http://blogs.msdn.com/miah)
Feel free to ask me questions also on [Twitter](http://www.twitter.com/JeremiahClark)