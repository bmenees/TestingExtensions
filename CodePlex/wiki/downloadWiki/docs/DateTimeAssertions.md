## DateTime Assertions
These assertion extension methods can be applied to only DateTime object types.

* [ShouldBeBefore](#ShouldBeBefore)
* [ShouldBeBeforeOrSameAs](#ShouldBeBeforeOrSameAs)
* [ShouldBeAfter](#ShouldBeAfter)
* [ShouldBeAfterOrSameAs](#ShouldBeAfterOrSameAs)

{anchor:ShouldBeBefore}
### ShouldBeBefore
Asserts that this DateTime value is before the specified DateTime value.
#### Usage
{code:c#}
public static DateTime ShouldBeBefore(this DateTime source, DateTime comparer)
public static DateTime ShouldBeBefore(this DateTime source, DateTime comparer, string message)
public static DateTime ShouldBeBefore(this DateTime source, DateTime comparer, string message, params object[]() parameters)
{code:c#}
#### Example
{code:c#}
[TestMethod](TestMethod)
public void Test()
{
   DateTime foo = DateTime.Now;
   foo.ShouldBeBefore(Datetime.MaxValue);
}
{code:c#}
**Supported Releases:** 1.1 and later

{anchor:ShouldBeBeforeOrSameAs}
### ShouldBeBeforeOrSameAs
Asserts that this DateTime value is before or the same as the specified DateTime value.
#### Usage
{code:c#}
public static DateTime ShouldBeBeforeOrSameAs(this DateTime source, DateTime comparer)
public static DateTime ShouldBeBeforeOrSameAs(this DateTime source, DateTime comparer, string message)
public static DateTime ShouldBeBeforeOrSameAs(this DateTime source, DateTime comparer, string message, params object[]() parameters)
{code:c#}
#### Example
{code:c#}
[TestMethod](TestMethod)
public void Test()
{
   DateTime foo = DateTime.Now;
   foo.ShouldBeBeforeOrSameAs(Datetime.MaxValue);

   DateTime foo = DateTime.Now;
   foo.ShouldBeBeforeOrSameAs(foo);

}
{code:c#}
**Supported Releases:** 1.1 and later

{anchor:ShouldBeAfter}
### ShouldBeAfter
Asserts that this DateTime value is after the specified DateTime value.
#### Usage
{code:c#}
public static DateTime ShouldBeAfter(this DateTime source, DateTime comparer)
public static DateTime ShouldBeAfter(this DateTime source, DateTime comparer, string message)
public static DateTime ShouldBeAfter(this DateTime source, DateTime comparer, string message, params object[]() parameters)
{code:c#}
#### Example
{code:c#}
[TestMethod](TestMethod)
public void Test()
{
   DateTime foo = DateTime.Now;
   foo.ShouldBeAfter(Datetime.MinValue);
}
{code:c#}
**Supported Releases:** 1.1 and later

{anchor:ShouldBeAfterOrSameAs}
### ShouldBeAfterOrSameAs
Asserts that this DateTime value is after or the same as the specified DateTime value.
#### Usage
{code:c#}
public static DateTime ShouldBeAfterOrSameAs(this DateTime source, DateTime comparer)
public static DateTime ShouldBeAfterOrSameAs(this DateTime source, DateTime comparer, string message)
public static DateTime ShouldBeAfterOrSameAs(this DateTime source, DateTime comparer, string message, params object[]() parameters)
{code:c#}
#### Example
{code:c#}
[TestMethod](TestMethod)
public void Test()
{
   DateTime foo = DateTime.Now;
   foo.ShouldBeAfterOrSameAs(Datetime.MinValue);

   DateTime foo = DateTime.Now;
   foo.ShouldBeAfterOrSameAs(foo);

}
{code:c#}
**Supported Releases:** 1.1 and later