# <img src="/src/icon.png" height="30px"> Verify.NSubstitute

[![Build status](https://ci.appveyor.com/api/projects/status/2yqj2feuuhlb1kf0?svg=true)](https://ci.appveyor.com/project/SimonCropp/Verify-NSubstitute)
[![NuGet Status](https://img.shields.io/nuget/v/Verify.NSubstitute.svg)](https://www.nuget.org/packages/Verify.NSubstitute/)

Adds [Verify](https://github.com/VerifyTests/Verify) support for verifying [NSubstitute](https://nsubstitute.github.io/) types.


## NuGet package

https://nuget.org/packages/Verify.NSubstitute/


## Usage

Before any tests have run call:

```
VerifyNSubstitute.Enable();
```

Given an interface:

<!-- snippet: ITarget.cs -->
<a id='snippet-ITarget.cs'></a>
```cs
public interface ITarget
{
    void Method(int a, int b);
}
```
<sup><a href='/src/Tests/ITarget.cs#L1-L4' title='Snippet source file'>snippet source</a> | <a href='#snippet-ITarget.cs' title='Start of snippet'>anchor</a></sup>
<!-- endSnippet -->

It `.ReceivedCalls()` can be verified:

<!-- snippet: ReceivedCalls -->
<a id='snippet-receivedcalls'></a>
```cs
[Fact]
public Task Test()
{
    var target = Substitute.For<ITarget>();
    target.Method(1, 2);
    return Verify(target.ReceivedCalls());
}
```
<sup><a href='/src/Tests/Tests.cs#L6-L16' title='Snippet source file'>snippet source</a> | <a href='#snippet-receivedcalls' title='Start of snippet'>anchor</a></sup>
<!-- endSnippet -->

Will result in:

<!-- snippet: Tests.Test.verified.txt -->
<a id='snippet-Tests.Test.verified.txt'></a>
```txt
[
  {
    Method: ITarget.Method(int a, int b),
    Arguments: [
      1,
      2
    ]
  }
]
```
<sup><a href='/src/Tests/Tests.Test.verified.txt#L1-L9' title='Snippet source file'>snippet source</a> | <a href='#snippet-Tests.Test.verified.txt' title='Start of snippet'>anchor</a></sup>
<!-- endSnippet -->
