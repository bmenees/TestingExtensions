## Exception Assertions
These methods allow you to assert the throwing of an exception.

* [ShouldThrowException](#ShouldThrowException)

{anchor:ShouldThrowException}
### ShouldThrowException
Asserts that the Action should throw an exception.
#### Usage
Where **TExceptionType** is an Exception
{code:c#}
public static TExceptionType ShouldThrowException<TExceptionType>(Action action) 
public static TExceptionType ShouldThrowException<TExceptionType>(Action action, string message) 
public static TExceptionType ShouldThrowException<TExceptionType>(Action action, string message, params object[]() parameters) 
{code:c#}
#### Remarks
This method is contained in the **Testing** static class of the library.
Unlike the default Exception testing in Visual Studio, you can test multiple Exceptions within the same test method.
#### Example
{code:c#}
[TestMethod](TestMethod)
public void Test()
{
   int zero = 0;
   Testing.ShouldThrowException<DivideByZeroException>( () => int x = 12 / zero );
}
{code:c#}

{code:c#}
[TestMethod](TestMethod)
public void Test()
{
   // Multiple expected exceptions can be tested in the same test method
   int zero = 0;
   Testing.ShouldThrowException<DivideByZeroException>( () => int x = 12 / zero );
   Testing.ShouldThrowException<InvalidCastException>( () => bool x = (bool)DateTime.Now );
}
{code:c#}
**Supported Releases:** All