## AssertHelper
These methods help with creating custom assertions.

* [AssertFailure](#AssertFailure)

{anchor:AssertFailure}
### AssertFailure
Creates a custom _AssertFailedException_ and provides information for the exception.
#### Usage
{code:c#}
public static void AssertFailed(string assertionName, string message, params object[]() parameters)
{code:c#}
**Supported Releases:** 1.2 and later