[![](https://img.shields.io/nuget/v/soenneker.extensions.spans.readonly.types.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.extensions.spans.readonly.types/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.extensions.spans.readonly.types/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.extensions.spans.readonly.types/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.extensions.spans.readonly.types.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.extensions.spans.readonly.types/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.extensions.spans.readonly.types/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.extensions.spans.readonly.types/actions/workflows/codeql.yml)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.Extensions.Spans.Readonly.Types
Builds a fast, order-sensitive hash key for a span of runtime `Type` objects.

## Installation

```bash
dotnet add package Soenneker.Extensions.Spans.Readonly.Types
```

## Usage

```csharp
using Soenneker.Extensions.Spans.Readonly.Types;

ReadOnlySpan<Type> signature = [typeof(string), typeof(int)];
int key = signature.ToHashKey();
```

The same type objects in the same order produce the same key within a process; changing the order changes the hash. An empty span returns `0`.

The hash uses runtime object identity. It is not stable across processes or application runs, is not cryptographic, and is not guaranteed unique—store the original type sequence alongside it if collisions must be resolved.
