## String and Char Assertions
These assertion extension methods can be applied to only string object types (including **char** for the purposes of the documentation).

* [ShouldEqualIgnoringCase](#ShouldEqualIgnoringCase)
* [ShouldNotEqualIgnoringCase](#ShouldNotEqualIgnoringCase)
* [ShouldBeEmpty](#ShouldBeEmpty)
* [ShouldNotBeEmpty](#ShouldNotBeEmpty)
* [ShouldBePrintable](#ShouldBePrintable)
* [ShouldNotBePrintable](#ShouldNotBePrintable)
* [ShouldContain](#ShouldContain)
* [ShouldContainIgnoringCase](#ShouldContainIgnoringCase)
* [ShouldNotContain](#ShouldNotContain)
* [ShouldNotContainIgnoringCase](#ShouldNotContainIgnoringCase)
* [ShouldHaveLengthOf](#ShouldHaveLengthOf)
* [ShouldNotHaveLengthOf](#ShouldNotHaveLengthOf)
* [ShouldHaveLengthOfAtLeast](#ShouldHaveLengthOfAtLeast)
* [ShouldHaveLengthOfAtMost](#ShouldHaveLengthOfAtMost)

{anchor:ShouldEqualIgnoringCase}
### ShouldEqualIgnoringCase
Asserts that this string/char value is equal to the specified string/char (ignoring case).
#### Usage
Where **T** is: string or char
{code:c#}
public static T ShouldEqualIgnoringCase(this T source, T comparer)
public static T ShouldEqualIgnoringCase(this T source, T comparer, string message)
public static T ShouldEqualIgnoringCase(this T source, T comparer, string message, params object[]() parameters)
{code:c#}
#### Example
{code:c#}
[TestMethod](TestMethod)
public void Test()
{
   string foo = "foo";
   foo.ShouldEqualIgnoringCase("FOO");
}
{code:c#}
**Supported Releases:** All

{anchor:ShouldNotEqualIgnoringCase}
### ShouldNotEqualIgnoringCase
Asserts that this string/char value is not equal to the specified string/char (ignoring case).
#### Usage
Where **T** is: string or char
{code:c#}
public static T ShouldNotEqualIgnoringCase(this T source, T comparer)
public static T ShouldNotEqualIgnoringCase(this T source, T comparer, string message)
public static T ShouldNotEqualIgnoringCase(this T source, T comparer, string message, params object[]() parameters)
{code:c#}
#### Example
{code:c#}
[TestMethod](TestMethod)
public void Test()
{
   string foo = "foo";
   foo.ShouldNotEqualIgnoringCase("BAR");

   foo.ShouldNotEqualIgnoringCase("FOO");  // This assertion would fail
}
{code:c#}
**Supported Releases:** All

{anchor:ShouldBeEmpty}
### ShouldBeEmpty
Asserts that this string value is empty.
#### Usage
{code:c#}
public static string ShouldBeEmpty(this string source)
public static string ShouldBeEmpty(this string source, string message)
public static string ShouldBeEmpty(this string source, string message, params object[]() parameters)
{code:c#}
#### Example
{code:c#}
[TestMethod](TestMethod)
public void Test()
{
   string foo = "";
   foo.ShouldBeEmpty();
}
{code:c#}
**Supported Releases:** All

{anchor:ShouldNotBeEmpty}
### ShouldNotBeEmpty
Asserts that this string value is not empty.
#### Usage
{code:c#}
public static string ShouldNotBeEmpty(this string source)
public static string ShouldNotBeEmpty(this string source, string message)
public static string ShouldNotBeEmpty(this string source, string message, params object[]() parameters)
{code:c#}
#### Example
{code:c#}
[TestMethod](TestMethod)
public void Test()
{
   string foo = "foo";
   foo.ShouldNotBeEmpty();
}
{code:c#}
**Supported Releases:** All


{anchor:ShouldBePrintable}
### ShouldBePrintable
Asserts that this char value is in the printable range.
#### Usage
{code:c#}
public static char ShouldBePrintable(this char source)
public static char ShouldBePrintable(this char source, string message)
public static char ShouldBePrintable(this char source, string message, params object[]() parameters)
{code:c#}
#### Example
{code:c#}
[TestMethod](TestMethod)
public void Test()
{
   char foo = "f";
   foo.ShouldBePrintable();
}
{code:c#}
**Supported Releases:** All

{anchor:ShouldNotBePrintable}
### ShouldNotBePrintable
Asserts that this char value is not in the printable range.
#### Usage
{code:c#}
public static char ShouldNotBePrintable(this char source)
public static char ShouldNotBePrintable(this char source, string message)
public static char ShouldNotBePrintable(this char source, string message, params object[]() parameters)
{code:c#}
#### Example
{code:c#}
[TestMethod](TestMethod)
public void Test()
{
   char foo = (char)3;
   foo.ShouldNotBePrintable();
}
{code:c#}
**Supported Releases:** All

{anchor:ShouldContain}
### ShouldContain
Asserts that this string value contains the specified substring.
#### Usage
{code:c#}
public static string ShouldContain(this string source, string substring)
public static string ShouldContain(this string source, string substring, string message)
public static string ShouldContain(this string source, string substring, string message, params object[]() parameters)
{code:c#}
#### Example
{code:c#}
[TestMethod](TestMethod)
public void Test()
{
   string foo = "foobar";
   foo.ShouldContain("foo");
}
{code:c#}
**Supported Releases:** 1.1 and later

{anchor:ShouldContainIgnoringCase}
### ShouldContainIgnoringCase
Asserts that this string value contains the specified substring, ignoring case.
#### Usage
{code:c#}
public static string ShouldContainIgnoringCase(this string source, string substring)
public static string ShouldContainIgnoringCase(this string source, string substring, string message)
public static string ShouldContainIgnoringCase(this string source, string substring, string message, params object[]() parameters)
{code:c#}
#### Example
{code:c#}
[TestMethod](TestMethod)
public void Test()
{
   string foo = "foobar";
   foo.ShouldContainIgnoringCase("FOO");
}
{code:c#}
**Supported Releases:** 1.1 and later

{anchor:ShouldNotContain}
### ShouldNotContain
Asserts that this string value does not contain the specified substring.
#### Usage
{code:c#}
public static string ShouldNotContain(this string source, string substring)
public static string ShouldNotContain(this string source, string substring, string message)
public static string ShouldNotContain(this string source, string substring, string message, params object[]() parameters)
{code:c#}
#### Example
{code:c#}
[TestMethod](TestMethod)
public void Test()
{
   string foo = "foobar";
   foo.ShouldNotContain("bar");
}
{code:c#}
**Supported Releases:** 1.1 and later

{anchor:ShouldNotContainIgnoringCase}
### ShouldNotContainIgnoringCase
Asserts that this string value does not contain the specified substring, ignoring case.
#### Usage
{code:c#}
public static string ShouldNotContainIgnoringCase(this string source, string substring)
public static string ShouldNotContainIgnoringCase(this string source, string substring, string message)
public static string ShouldNotContainIgnoringCase(this string source, string substring, string message, params object[]() parameters)
{code:c#}
#### Example
{code:c#}
[TestMethod](TestMethod)
public void Test()
{
   string foo = "foobar";
   foo.ShouldNotContainIgnoringCase("TEST");
}
{code:c#}
**Supported Releases:** 1.1 and later

{anchor:ShouldHaveLengthOf}
### ShouldHaveLengthOf
Asserts that this string value has a specified length.
#### Usage
{code:c#}
public static string ShouldHaveLengthOf(this string source, int length)
public static string ShouldHaveLengthOf(this string source, int length, string message)
public static string ShouldHaveLengthOf(this string source, int length, string message, params object[]() parameters)
{code:c#}
#### Example
{code:c#}
[TestMethod](TestMethod)
public void Test()
{
   string foo = "foobar";
   foo.ShouldHaveLengthOf(6);
}
{code:c#}
**Supported Releases:** 1.2 and later

{anchor:ShouldNotHaveLengthOf}
### ShouldNotHaveLengthOf
Asserts that this string value does not have a specified length.
#### Usage
{code:c#}
public static string ShouldNotHaveLengthOf(this string source, int length)
public static string ShouldNotHaveLengthOf(this string source, int length, string message)
public static string ShouldNotHaveLengthOf(this string source, int length, string message, params object[]() parameters)
{code:c#}
#### Example
{code:c#}
[TestMethod](TestMethod)
public void Test()
{
   string foo = "foobar";
   foo.ShouldNotHaveLengthOf(5);
}
{code:c#}
**Supported Releases:** 1.2 and later

{anchor:ShouldHaveLengthOfAtLeast}
### ShouldHaveLengthOfAtLeast
Asserts that this string value has a minimum specified length.
#### Usage
{code:c#}
public static string ShouldHaveLengthOfAtLeast(this string source, int length)
public static string ShouldHaveLengthOfAtLeast(this string source, int length, string message)
public static string ShouldHaveLengthOfAtLeast(this string source, int length, string message, params object[]() parameters)
{code:c#}
#### Example
{code:c#}
[TestMethod](TestMethod)
public void Test()
{
   string foo = "foobar";
   foo.ShouldHaveLengthOfAtLeast(5);
}
{code:c#}
**Supported Releases:** 1.2 and later

{anchor:ShouldHaveLengthOfAtMost}
### ShouldHaveLengthOfAtMost
Asserts that this string value has a maximum specified length.
#### Usage
{code:c#}
public static string ShouldHaveLengthOfAtMost(this string source, int length)
public static string ShouldHaveLengthOfAtMost(this string source, int length, string message)
public static string ShouldHaveLengthOfAtMost(this string source, int length, string message, params object[]() parameters)
{code:c#}
#### Example
{code:c#}
[TestMethod](TestMethod)
public void Test()
{
   string foo = "foobar";
   foo.ShouldHaveLengthOfAtMost(7);
}
{code:c#}
**Supported Releases:** 1.2 and later