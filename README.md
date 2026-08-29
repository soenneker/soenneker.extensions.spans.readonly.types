[![](https://img.shields.io/nuget/v/soenneker.extensions.spans.readonly.types.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.extensions.spans.readonly.types/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.extensions.spans.readonly.types/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.extensions.spans.readonly.types/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.extensions.spans.readonly.types.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.extensions.spans.readonly.types/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.extensions.spans.readonly.types/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.extensions.spans.readonly.types/actions/workflows/codeql.yml)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.Extensions.Spans.Readonly.Types
Helpful extension methods surrounding ReadOnlySpan of Type.

## Installation

```bash
dotnet add package Soenneker.Extensions.Spans.Readonly.Types
```

## Quick start

```csharp
using Soenneker.Extensions.Spans.Readonly.Types;

// Given an existing System.ReadOnlySpan<System.Type> named types:
var result = types.ToHashKey();
```

## Common operations

- `ToHashKey()` - Computes a hash code that uniquely represents the sequence and identity of the specified span of types.
