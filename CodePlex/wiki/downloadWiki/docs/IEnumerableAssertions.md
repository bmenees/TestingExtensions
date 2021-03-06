## IEnumerable<T> Assertions
These assertion extension methods can be applied to only IEnumerable<T> object types.

* [ShouldBeEmpty](#ShouldBeEmpty)
* [ShouldNotBeEmpty](#ShouldNotBeEmpty)
* [ShouldContain](#ShouldContain)
* [ShouldNotContain](#ShouldNotContain)
* [ShouldHaveCountOf](#ShouldHaveCountOf)
* [ShouldNotHaveCountOf](#ShouldNotHaveCountOf)
* [ShouldHaveCountOfAtLeast](#ShouldHaveCountOfAtLeast)
* [ShouldHaveCountOfAtMost](#ShouldHaveCountOfAtMost)

{anchor:ShouldBeEmpty}
### ShouldBeEmpty
Asserts that this IEnumerable<T> does not contain any items.
#### Usage
{code:c#}
public static IEnumerable<T> ShouldBeEmpty<T>(this IEnumerable<T> source)
public static IEnumerable<T> ShouldBeEmpty<T>(this IEnumerable<T> source, string message)
public static IEnumerable<T> ShouldBeEmpty<T>(this IEnumerable<T> source, string message, params object[]() parameters)
{code:c#}
#### Example
{code:c#}
[TestMethod](TestMethod)
public void Test()
{
   IEnumerable<int> foo = new List<int>();
   foo.ShouldBeEmpty();
}
{code:c#}
**Supported Releases:** 1.2 and later
{anchor:ShouldNotBeEmpty}
### ShouldNotBeEmpty
Asserts that this IEnumerable<T> contains items.
#### Usage
{code:c#}
public static IEnumerable<T> ShouldNotBeEmpty<T>(this IEnumerable<T> source)
public static IEnumerable<T> ShouldNotBeEmpty<T>(this IEnumerable<T> source, string message)
public static IEnumerable<T> ShouldNotBeEmpty<T>(this IEnumerable<T> source, string message, params object[]() parameters)
{code:c#}
#### Example
{code:c#}
[TestMethod](TestMethod)
public void Test()
{
   IEnumerable<int> foo = new List<int>() { 1, 2, 3 };
   foo.ShouldNotBeEmpty();
}
{code:c#}
**Supported Releases:** 1.2 and later
{anchor:ShouldContain}
### ShouldContain
Asserts that this IEnumerable<T> contains the specified item.
#### Usage
{code:c#}
public static IEnumerable<T> ShouldContain<T>(this IEnumerable<T> source, T item)
public static IEnumerable<T> ShouldContain<T>(this IEnumerable<T> source, T item, string message)
public static IEnumerable<T> ShouldContain<T>(this IEnumerable<T> source, T item, string message, params object[]() parameters)
{code:c#}
#### Example
{code:c#}
[TestMethod](TestMethod)
public void Test()
{
   IEnumerable<int> foo = new List<int>() { 1, 2, 3 };
   foo.ShouldContain(1);
}
{code:c#}
**Supported Releases:** 1.2 and later
{anchor:ShouldNotContain}
### ShouldNotContain
Asserts that this IEnumerable<T> does not contain the specified item.
#### Usage
{code:c#}
public static IEnumerable<T> ShouldNotContain<T>(this IEnumerable<T> source, T item)
public static IEnumerable<T> ShouldNotContain<T>(this IEnumerable<T> source, T item, string message)
public static IEnumerable<T> ShouldNotContain<T>(this IEnumerable<T> source, T item, string message, params object[]() parameters)
{code:c#}
#### Example
{code:c#}
[TestMethod](TestMethod)
public void Test()
{
   IEnumerable<int> foo = new List<int>() { 1, 2, 3 };
   foo.ShouldNotContain(0);
}
{code:c#}
**Supported Releases:** 1.2 and later
{anchor:ShouldHaveCountOf}
### ShouldHaveCountOf
Asserts that this IEnumerable<T> contains the specified number of items.
#### Usage
{code:c#}
public static IEnumerable<T> ShouldHaveCountOf<T>(this IEnumerable<T> source, int count)
public static IEnumerable<T> ShouldHaveCountOf<T>(this IEnumerable<T> source, int count, string message)
public static IEnumerable<T> ShouldHaveCountOf<T>(this IEnumerable<T> source, int count, string message, params object[]() parameters)
{code:c#}
#### Example
{code:c#}
[TestMethod](TestMethod)
public void Test()
{
   IEnumerable<int> foo = new List<int>() { 1, 2, 3 };
   foo.ShouldHaveCountOf(3);
}
{code:c#}
**Supported Releases:** 1.2 and later

{anchor:ShouldNotHaveCountOf}
### ShouldNotHaveCountOf
Asserts that this IEnumerable<T> does not contain the specified number of items.
#### Usage
{code:c#}
public static IEnumerable<T> ShouldNotHaveCountOf<T>(this IEnumerable<T> source, int count)
public static IEnumerable<T> ShouldNotHaveCountOf<T>(this IEnumerable<T> source, int count, string message)
public static IEnumerable<T> ShouldNotHaveCountOf<T>(this IEnumerable<T> source, int count, string message, params object[]() parameters)
{code:c#}
#### Example
{code:c#}
[TestMethod](TestMethod)
public void Test()
{
   IEnumerable<int> foo = new List<int>() { 1, 2, 3 };
   foo.ShouldNotHaveCountOf(4);
}
{code:c#}
**Supported Releases:** 1.2 and later

{anchor:ShouldHaveCountOfAtLeast}
### ShouldHaveCountOfAtLeast
Asserts that this IEnumerable<T> contains a minimum specified number of items.
#### Usage
{code:c#}
public static IEnumerable<T> ShouldHaveCountOfAtLeast<T>(this IEnumerable<T> source, int count)
public static IEnumerable<T> ShouldHaveCountOfAtLeast<T>(this IEnumerable<T> source, int count, string message)
public static IEnumerable<T> ShouldHaveCountOfAtLeast<T>(this IEnumerable<T> source, int count, string message, params object[]() parameters)
{code:c#}
#### Example
{code:c#}
[TestMethod](TestMethod)
public void Test()
{
   IEnumerable<int> foo = new List<int>() { 1, 2, 3 };
   foo.ShouldHaveCountOfAtLeast(2);
}
{code:c#}
**Supported Releases:** 1.2 and later

{anchor:ShouldHaveCountOfAtMost}
### ShouldHaveCountOfAtMost
Asserts that this IEnumerable<T> contains a maximum specified number of items.
#### Usage
{code:c#}
public static IEnumerable<T> ShouldHaveCountOfAtMost<T>(this IEnumerable<T> source, int count)
public static IEnumerable<T> ShouldHaveCountOfAtMost<T>(this IEnumerable<T> source, int count, string message)
public static IEnumerable<T> ShouldHaveCountOfAtMost<T>(this IEnumerable<T> source, int count, string message, params object[]() parameters)
{code:c#}
#### Example
{code:c#}
[TestMethod](TestMethod)
public void Test()
{
   IEnumerable<int> foo = new List<int>() { 1, 2, 3 };
   foo.ShouldHaveCountOfAtMost(4);
}
{code:c#}
**Supported Releases:** 1.2 and later