## ICollection<T> Assertions
These assertion extension methods can be applied to only ICollection<T> object types.

* [ShouldBeEmpty](#ShouldBeEmpty)
* [ShouldNotBeEmpty](#ShouldNotBeEmpty)
* [ShouldContain](#ShouldContain)
* [ShouldNotContain](#ShouldNotContain)
* [ShouldHaveCountOf](#ShouldHaveCountOf)

{anchor:ShouldBeEmpty}
### ShouldBeEmpty
Asserts that this ICollection<T> does not contain any items.
#### Usage
{code:c#}
public static ICollection<T> ShouldBeEmpty<T>(this ICollection<T> source)
public static ICollection<T> ShouldBeEmpty<T>(this ICollection<T> source, string message)
public static ICollection<T> ShouldBeEmpty<T>(this ICollection<T> source, string message, params object[]() parameters)
{code:c#}
#### Example
{code:c#}
[TestMethod](TestMethod)
public void Test()
{
   List<int> foo = new List<int>();
   foo.ShouldBeEmpty();
}
{code:c#}
**Supported Releases:** 1.1 and later
{anchor:ShouldNotBeEmpty}
### ShouldNotBeEmpty
Asserts that this ICollection<T> contains items.
#### Usage
{code:c#}
public static ICollection<T> ShouldNotBeEmpty<T>(this ICollection<T> source)
public static ICollection<T> ShouldNotBeEmpty<T>(this ICollection<T> source, string message)
public static ICollection<T> ShouldNotBeEmpty<T>(this ICollection<T> source, string message, params object[]() parameters)
{code:c#}
#### Example
{code:c#}
[TestMethod](TestMethod)
public void Test()
{
   List<int> foo = new List<int>() { 1, 2, 3 };
   foo.ShouldNotBeEmpty();
}
{code:c#}
**Supported Releases:** 1.1 and later
{anchor:ShouldContain}
### ShouldContain
Asserts that this ICollection<T> contains the specified item.
#### Usage
{code:c#}
public static ICollection<T> ShouldContain<T>(this ICollection<T> source, T item)
public static ICollection<T> ShouldContain<T>(this ICollection<T> source, T item, string message)
public static ICollection<T> ShouldContain<T>(this ICollection<T> source, T item, string message, params object[]() parameters)
{code:c#}
#### Example
{code:c#}
[TestMethod](TestMethod)
public void Test()
{
   List<int> foo = new List<int>() { 1, 2, 3 };
   foo.ShouldContain(1);
}
{code:c#}
**Supported Releases:** 1.1 and later
{anchor:ShouldNotContain}
### ShouldNotContain
Asserts that this ICollection<T> does not contain the specified item.
#### Usage
{code:c#}
public static ICollection<T> ShouldNotContain<T>(this ICollection<T> source, T item)
public static ICollection<T> ShouldNotContain<T>(this ICollection<T> source, T item, string message)
public static ICollection<T> ShouldNotContain<T>(this ICollection<T> source, T item, string message, params object[]() parameters)
{code:c#}
#### Example
{code:c#}
[TestMethod](TestMethod)
public void Test()
{
   List<int> foo = new List<int>() { 1, 2, 3 };
   foo.ShouldNotContain(0);
}
{code:c#}
**Supported Releases:** 1.1 and later
{anchor:ShouldHaveCountOf}
### ShouldHaveCountOf
Asserts that this ICollection<T> contains the specified number of items.
#### Usage
{code:c#}
public static ICollection<T> ShouldHaveCountOf<T>(this ICollection<T> source, int count)
public static ICollection<T> ShouldHaveCountOf<T>(this ICollection<T> source, int count, string message)
public static ICollection<T> ShouldHaveCountOf<T>(this ICollection<T> source, int count, string message, params object[]() parameters)
{code:c#}
#### Example
{code:c#}
[TestMethod](TestMethod)
public void Test()
{
   List<int> foo = new List<int>() { 1, 2, 3 };
   foo.ShouldHaveCountOf(3);
}
{code:c#}
**Supported Releases:** 1.1 and later