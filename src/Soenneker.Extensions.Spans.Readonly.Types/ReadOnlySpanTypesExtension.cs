using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;

namespace Soenneker.Extensions.Spans.Readonly.Types;

/// <summary>
/// Helpful extension methods surrounding ReadOnlySpan of Type
/// </summary>
public static class ReadOnlySpanTypesExtension
{
    /// <summary>
    /// Computes a hash code that uniquely represents the sequence and identity of the specified span of types.
    /// </summary>
    [Pure]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int ToHashKey(this System.ReadOnlySpan<System.Type> types)
    {
        int len = types.Length;

        if (len == 0)
            return 0;

        var hash = unchecked((int)2166136261);

        for (var i = 0; i < len; i++)
            hash = unchecked((hash * 16777619) ^ RuntimeHelpers.GetHashCode(types[i]));

        return hash;
    }
}