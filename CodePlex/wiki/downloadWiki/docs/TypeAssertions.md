## Type Assertions
These assertion extension methods can be applied to only Type object types.

* [ShouldBeAssignableFrom](#ShouldBeAssignableFrom)

{anchor:ShouldBeAssignableFrom}
### ShouldBeAssignableFrom
Asserts that this type value is assignable from another type.
#### Usage
{code:c#}
public static Type ShouldBeAssignableFrom(this Type source, Type comparer)
public static Type ShouldBeAssignableFrom(this Type source, Type comparer, string message)
public static Type ShouldBeAssignableFrom(this Type source, Type comparer, string message, params object[]() parameters)
public static Type ShouldBeAssignableFrom<TComparer>(this Type source)
public static Type ShouldBeAssignableFrom<TComparer>((this Type source, string message)
public static Type ShouldBeAssignableFrom<TComparer>((this Type source, string message, params object[]() parameters)
{code:c#}
#### Example
{code:c#}
[TestMethod](TestMethod)
public void Test()
{
   Type foo = typeof(ICollection);
   foo.ShouldBeAssignableFrom(IEnumerable);

   Type foo = typeof(IList);
   foo.ShouldBeAssignableFrom<IEnumerable>();
}
{code:c#}
**Supported Releases:** 1.2 and later
