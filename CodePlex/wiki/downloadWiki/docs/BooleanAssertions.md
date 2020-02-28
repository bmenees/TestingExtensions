## Boolean Assertions
These assertion extension methods can be applied to only boolean object types.

* [ShouldBeFalse](#ShouldBeFalse)
* [ShouldBeTrue](#ShouldBeTrue)

{anchor:ShouldBeFalse}
### ShouldBeFalse
Asserts that this boolean value is false.
#### Usage
{code:c#}
public static bool ShouldBeFalse(this bool source)
public static bool ShouldBeFalse(this bool source, string message)
public static bool ShouldBeFalse(this bool source, string message, params object[]() parameters)
public static bool? ShouldBeFalse(this bool? source)
public static bool? ShouldBeFalse(this bool? source, string message)
public static bool? ShouldBeFalse(this bool? source, string message, params object[]() parameters)
{code:c#}
#### Example
{code:c#}
[TestMethod](TestMethod)
public void Test()
{
   bool foo = false;
   foo.ShouldBeFalse();

   bool? bar= false;
   bar.ShouldBeFalse();
}
{code:c#}
**Supported Releases:** All

{anchor:ShouldBeTrue}
### ShouldBeTrue
Asserts that this boolean value is true.
#### Usage
{code:c#}
public static bool ShouldBeTrue(this bool source)
public static bool ShouldBeTrue(this bool source, string message)
public static bool ShouldBeTrue(this bool source, string message, params object[]() parameters)
public static bool? ShouldBeTrue(this bool? source)
public static bool? ShouldBeTrue(this bool? source, string message)
public static bool? ShouldBeTrue(this bool? source, string message, params object[]() parameters)
{code:c#}
#### Example
{code:c#}
[TestMethod](TestMethod)
public void Test()
{
   bool foo = true;
   foo.ShouldBeTrue();

   bool? bar= true;
   bar.ShouldBeTrue();
}
{code:c#}
**Supported Releases:** All