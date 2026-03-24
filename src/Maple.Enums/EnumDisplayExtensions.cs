using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Provides display label resolution for enum values using FastEnumUtility labels.
/// </summary>
/// <remarks>
/// Label index convention:
/// Index 0 = V95 PDB name, Index 1 = display name, Index 2+ = WZ codes / alternate identifiers.
/// </remarks>
public static class EnumDisplayExtensions
{
    /// <summary>
    /// Gets a human-readable display name for an enum value.
    /// </summary>
    /// <remarks>
    /// Priority: [Label(_, 1)] (display label) → [Label] if readable (no underscores) → member name.
    /// </remarks>
    /// <typeparam name="T">An enum type.</typeparam>
    /// <param name="value">The enum value to resolve a display label for.</param>
    /// <returns>A human-readable display string; never null or empty.</returns>
    public static string GetDisplayLabel<T>(this T value)
        where T : struct, Enum
    {
        string? display = value.GetLabel(1, throwIfNotFound: false);
        if (display is not null)
            return display;

        string? label = value.GetLabel(throwIfNotFound: false);
        if (label is not null && !label.Contains('_'))
            return label;

        return Enum.GetName(value) ?? value.ToString();
    }
}
