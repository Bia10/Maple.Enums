using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Enchant scroll category.
/// </summary>
public enum EnchantScrollCategory : byte
{
    /// <summary>No enchant scroll category. Invalid default.</summary>
    [Label("ENCHANT_SCROLL_CATEGORY_NONE")]
    None = 0,

    /// <summary>Standard enchant scroll.</summary>
    [Label("ENCHANT_SCROLL_CATEGORY_NORMAL")]
    Normal = 1,

    /// <summary>Visitor enchant scroll.</summary>
    [Label("ENCHANT_SCROLL_CATEGORY_VISITOR")]
    Visitor = 2,
}
