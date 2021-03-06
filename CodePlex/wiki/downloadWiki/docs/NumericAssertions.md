## Numeric Assertions
These assertion extension methods can be applied to only numeric object types (including **char** for the purposes of the documentation).

* [ShouldBeGreaterThan](#ShouldBeGreaterThan)
* [ShouldBeGreaterThanOrEqualTo](#ShouldBeGreaterThanOrEqualTo)
* [ShouldBeLessThan](#ShouldBeLessThan)
* [ShouldBeLessThanOrEqualTo](#ShouldBeLessThanOrEqualTo)
* [ShouldBeBetween](#ShouldBeBetween)
* [ShouldNotBeBetween](#ShouldNotBeBetween)
* [ShouldBePositive](#ShouldBePositive)
* [ShouldBeNegative](#ShouldBeNegative)
* [ShouldBeIntegral](#ShouldBeIntegral)
* [ShouldBeFractional](#ShouldBeFractional)
* [ShouldRoundTo](#ShouldRoundTo)

{anchor:ShouldBeGreaterThan}
### ShouldBeGreaterThan
Asserts that this value is greater than a certain value.
#### Usage
Where **T** is: short, int, long, ushort, uint, ulong, byte, sbyte, char, float, double, or decimal
{code:c#}
public static T ShouldBeGreaterThan(this T source, T comparer)
public static T ShouldBeGreaterThan(this T source, T comparer, string message)
public static T ShouldBeGreaterThan(this T source, T comparer, string message, params object[]() parameters)
{code:c#}
#### Example
{code:c#}
[TestMethod](TestMethod)
public void Test()
{
   int number = 5;
   number.ShouldBeGreaterThan(4);
}
{code:c#}
**Supported Releases:** All

{anchor:ShouldBeGreaterThanOrEqualTo}
### ShouldBeGreaterThanOrEqualTo
Asserts that this value is greater than or equal to a certain value.
#### Usage
Where **T** is: short, int, long, ushort, uint, ulong, byte, sbyte, char, float, double, or decimal
{code:c#}
public static T ShouldBeGreaterThanOrEqualTo(this T source, T comparer)
public static T ShouldBeGreaterThanOrEqualTo(this T source, T comparer, string message)
public static T ShouldBeGreaterThanOrEqualTo(this T source, T comparer, string message, params object[]() parameters)
{code:c#}
#### Example
{code:c#}
[TestMethod](TestMethod)
public void Test()
{
   int number = 5;
   number.ShouldBeGreaterThanOrEqualTo(4);
   number.ShouldBeGreaterThanOrEqualTo(5);
}
{code:c#}
**Supported Releases:** All


{anchor:ShouldBeLessThan}
### ShouldBeLessThan
Asserts that this value is less than a certain value.
#### Usage
Where **T** is: short, int, long, ushort, uint, ulong, byte, sbyte, char, float, double, or decimal
{code:c#}
public static T ShouldBeLessThan(this T source, T comparer)
public static T ShouldBeLessThan(this T source, T comparer, string message)
public static T ShouldBeLessThan(this T source, T comparer, string message, params object[]() parameters)
{code:c#}
#### Example
{code:c#}
[TestMethod](TestMethod)
public void Test()
{
   int number = 5;
   number.ShouldBeLessThan(6);
}
{code:c#}
**Supported Releases:** All

{anchor:ShouldBeLessThanOrEqualTo}
### ShouldBeLessThanOrEqualTo
Asserts that this value is less than or equal to a certain value.
#### Usage
Where **T** is: short, int, long, ushort, uint, ulong, byte, sbyte, char, float, double, or decimal
{code:c#}
public static T ShouldBeLessThanOrEqualTo(this T source, T comparer)
public static T ShouldBeLessThanOrEqualTo(this T source, T comparer, string message)
public static T ShouldBeLessThanOrEqualTo(this T source, T comparer, string message, params object[]() parameters)
{code:c#}
#### Example
{code:c#}
[TestMethod](TestMethod)
public void Test()
{
   int number = 5;
   number.ShouldBeLessThanOrEqualTo(5);
   number.ShouldBeLessThanOrEqualTo(6);
}
{code:c#}
**Supported Releases:** All

{anchor:ShouldBeBetween}
### ShouldBeBetween
Asserts that this value is between two values.
#### Usage
Where **T** is: short, int, long, ushort, uint, ulong, byte, sbyte, char, float, double, or decimal
{code:c#}
public static T ShouldBeBetween(this T source, T lowerInclusive, T upperInclusive)
public static T ShouldBeBetween(this T source, T lowerInclusive, T upperInclusive, string message)
public static T ShouldBeBetween(this T source, T lowerInclusive, T upperInclusive, string message, params object[]() parameters)
{code:c#}
#### Example
{code:c#}
[TestMethod](TestMethod)
public void Test()
{
   int number = 5;
   number.ShouldBeBetween(4, 6);
}
{code:c#}
**Supported Releases:** All

{anchor:ShouldNotBeBetween}
### ShouldNotBeBetween
Asserts that this value is not between two values.
#### Usage
Where **T** is: short, int, long, ushort, uint, ulong, byte, sbyte, char, float, double, or decimal
{code:c#}
public static T ShouldNotBeBetween(this T source, T lowerExclusive, T upperExclusive)
public static T ShouldNotBeBetween(this T source, T lowerExclusive, T upperExclusive, string message)
public static T ShouldNotBeBetween(this T source, T lowerExclusive, T upperExclusive, string message, params object[]() parameters)
{code:c#}
#### Example
{code:c#}
[TestMethod](TestMethod)
public void Test()
{
   int number = 5;
   number.ShouldNotBeBetween(6, 9);
}
{code:c#}
**Supported Releases:** All

{anchor:ShouldBePositive}
### ShouldBePositive
Asserts that this value is positive or zero.
#### Usage
Where **T** is: short, int, long, sbyte, float, double, or decimal
{code:c#}
public static T ShouldBePositive(this T source)
public static T ShouldBePositive(this T source, string message)
public static T ShouldBePositive(this T source, string message, params object[]() parameters)
{code:c#}
#### Example
{code:c#}
[TestMethod](TestMethod)
public void Test()
{
   int number = 5;
   number.ShouldBePositive();
}
{code:c#}
**Supported Releases:** All

{anchor:ShouldBeNegative}
### ShouldBeNegative
Asserts that this value is negative.
#### Usage
Where **T** is: short, int, long, sbyte, float, double, or decimal
{code:c#}
public static T ShouldBeNegative(this T source)
public static T ShouldBeNegative(this T source, string message)
public static T ShouldBeNegative(this T source, string message, params object[]() parameters)
{code:c#}
#### Example
{code:c#}
[TestMethod](TestMethod)
public void Test()
{
   int number = -5;
   number.ShouldBeNegative();
}
{code:c#}
**Supported Releases:** All

{anchor:ShouldBeIntegral}
### ShouldBeIntegral
Asserts that this value is integral (does not have a fractional component).
#### Usage
Where **T** is: float, double, or decimal
{code:c#}
public static T ShouldBeIntegral(this T source)
public static T ShouldBeIntegral(this T source, string message)
public static T ShouldBeIntegral(this T source, string message, params object[]() parameters)
{code:c#}
#### Example
{code:c#}
[TestMethod](TestMethod)
public void Test()
{
   double number = 3.0;
   number.ShouldBeIntegral();
}
{code:c#}
**Supported Releases:** All

{anchor:ShouldBeFractional}
### ShouldBeFractional
Asserts that this value is has a fractional component.
#### Usage
Where **T** is: float, double, or decimal
{code:c#}
public static T ShouldBeFractional(this T source)
public static T ShouldBeFractional(this T source, string message)
public static T ShouldBeFractional(this T source, string message, params object[]() parameters)
{code:c#}
#### Example
{code:c#}
[TestMethod](TestMethod)
public void Test()
{
   double number = 3.34;
   number.ShouldBeFractional();
}
{code:c#}
**Supported Releases:** All

{anchor:ShouldRoundTo}
### ShouldRoundTo
Asserts that this value rounds to a specified value.
#### Usage
Where **T** is: float, double, or decimal
{code:c#}
public static T ShouldRoundTo(this T source, T comparer)
public static T ShouldRoundTo(this T source, T comparer, string message)
public static T ShouldRoundTo(this T source, T comparer, string message, params object[]() parameters)
{code:c#}
#### Example
{code:c#}
[TestMethod](TestMethod)
public void Test()
{
   double number = 3.34;
   number.ShouldRoundTo(3);
}
{code:c#}
**Supported Releases:** All