## Generic Assertions
These assertion extension methods can be applied to any type of object.

* [ShouldEqual](#ShouldEqual)
* [ShouldNotEqual](#ShouldNotEqual)
* [ShouldBeSameAs](#ShouldBeSameAs)
* [ShouldNotBeSameAs](#ShouldNotBeSameAs)
* [ShouldBeNull](#ShouldBeNull)
* [ShouldNotBeNull](#ShouldNotBeNull)
* [ShouldBeOfType](#ShouldBeOfType)
* [ShouldNotBeOfType](#ShouldNotBeOfType)

{anchor:ShouldEqual}
### ShouldEqual
Asserts that this object is equal to another object.
#### Usage
{code:c#}
public static T ShouldEqual<T>(this T source, T comparer)
public static T ShouldEqual<T>(this T source, T comparer, string message)
public static T ShouldEqual<T>(this T source, T comparer, string message, params object[]() parameters)
{code:c#}
#### Example
{code:c#}
[TestMethod](TestMethod)
public void Test()
{
   int number = 5;
   number.ShouldEqual(5);
   
   string foo = "foo";
   foo.ShouldEqual("foo");
}
{code:c#}
**Supported Releases:** All

{anchor:ShouldNotEqual}
### ShouldNotEqual
Asserts that this object is not equal to another object.
#### Usage
{code:c#}
public static T ShouldNotEqual<T>(this T source, T comparer)
public static T ShouldNotEqual<T>(this T source, T comparer, string message)
public static T ShouldNotEqual<T>(this T source, T comparer, string message, params object[]() parameters)
{code:c#}
#### Example
{code:c#}
[TestMethod](TestMethod)
public void Test()
{
   int number = 5;
   number.ShouldNotEqual(4);
   
   string foo = "foo";
   foo.ShouldNotEqual("bar");
}
{code:c#}
**Supported Releases:** All

{anchor:ShouldBeSameAs}
### ShouldBeSameAs
Asserts that this object has the same reference as another object.
#### Usage
{code:c#}
public static T ShouldBeSameAs<T>(this T source, T comparer)
public static T ShouldBeSameAs<T>(this T source, T comparer, string message)
public static T ShouldBeSameAs<T>(this T source, T comparer, string message, params object[]() parameters)
{code:c#}
#### Example
{code:c#}
[TestMethod](TestMethod)
public void Test()
{
   int i = 4;
   object firstObject = i;
   object secondObject = firstObject;

   firstObject.ShouldBeSameAs(secondObject);
}
{code:c#}
**Supported Releases:** All


{anchor:ShouldNotBeSameAs}
### ShouldNotBeSameAs
Asserts that this object does not have the same reference as another object.
#### Usage
{code:c#}
public static T ShouldNotBeSameAs<T>(this T source, T comparer)
public static T ShouldNotBeSameAs<T>(this T source, T comparer, string message)
public static T ShouldNotBeSameAs<T>(this T source, T comparer, string message, params object[]() parameters)
{code:c#}
#### Example
{code:c#}
[TestMethod](TestMethod)
public void Test()
{
   int i = 4;
   object firstObject = i;
   object secondObject = i;

   firstObject.ShouldNotBeSameAs(secondObject);
}
{code:c#}
**Supported Releases:** All

{anchor:ShouldBeNull}
### ShouldBeNull
Asserts that this object is null.
#### Usage
{code:c#}
public static T ShouldBeNull<T>(this T source)
public static T ShouldBeNull<T>(this T source, string message)
public static T ShouldBeNull<T>(this T source, string message, params object[]() parameters)
{code:c#}
#### Example
{code:c#}
[TestMethod](TestMethod)
public void Test()
{
   object foo = null;
   foo.ShouldBeNull();
}
{code:c#}
**Supported Releases:** All

{anchor:ShouldNotBeNull}
### ShouldNotBeNull
Asserts that this object is not null.
#### Usage
{code:c#}
public static T ShouldNotBeNull<T>(this T source)
public static T ShouldNotBeNull<T>(this T source, string message)
public static T ShouldNotBeNull<T>(this T source, string message, params object[]() parameters)
{code:c#}
#### Example
{code:c#}
[TestMethod](TestMethod)
public void Test()
{
   object foo = new object();
   foo.ShouldNotBeNull();
}
{code:c#}
**Supported Releases:** All

{anchor:ShouldBeOfType}
### ShouldBeOfType
Asserts that this object is a certain type.
#### Usage
{code:c#}
public static T ShouldBeOfType<T>(this T source, Type type)
public static T ShouldBeOfType<T>(this T source, Type type, string message)
public static T ShouldBeOfType<T>(this T source, Type type, string message, params object[]() parameters)
{code:c#}
#### Example
{code:c#}
[TestMethod](TestMethod)
public void Test()
{
   false.ShouldBeOfType(typeof(bool));
   "foo".ShouldBeOfType(typeof(string));
}
{code:c#}
**Supported Releases:** All

{anchor:ShouldNotBeOfType}
### ShouldNotBeOfType
Asserts that this object is not a certain type.
#### Usage
{code:c#}
public static T ShouldNotBeOfType<T>(this T source, Type type)
public static T ShouldNotBeOfType<T>(this T source, Type type, string message)
public static T ShouldNotBeOfType<T>(this T source, Type type, string message, params object[]() parameters)
{code:c#}
#### Example
{code:c#}
[TestMethod](TestMethod)
public void Test()
{
   false.ShouldNotBeOfType(typeof(string));
   "foo".ShouldNotBeOfType(typeof(bool));
}
{code:c#}
**Supported Releases:** All