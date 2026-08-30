[![](https://img.shields.io/nuget/v/soenneker.enums.email.priority.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.enums.email.priority/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.enums.email.priority/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.enums.email.priority/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.enums.email.priority.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.enums.email.priority/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.enums.email.priority/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.enums.email.priority/actions/workflows/codeql.yml)

# Soenneker.Enums.Email.Priority

A string-backed enum-value type for carrying an email priority through application and transport contracts.

## Install

```bash
dotnet add package Soenneker.Enums.Email.Priority
```

## Usage

```csharp
using Soenneker.Enums.Email.Priority;

EmailPriority priority = EmailPriority.High;
string wireValue = priority.Value; // "High"

if (EmailPriority.TryFromValue(input, out EmailPriority? parsed))
{
    // parsed is Low, Normal, or High
}
```

Available values are `Low`, `Normal`, and `High`. `System.Text.Json` serializes the type as the matching string value and restores recognized values to the shared static instances. `FromValue` throws for unknown input; use `TryFromValue` for request values. `FromName` and `TryFromName` are also generated.

The type is a priority label, not a delivery guarantee. A sender must map it to the transport's priority headers or provider fields, and receiving clients may ignore those hints. It does not change queue ordering, retry policy, or provider service level on its own.
