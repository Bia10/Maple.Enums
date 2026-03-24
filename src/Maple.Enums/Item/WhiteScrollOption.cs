using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// White scroll usage options for equipment upgrades.
/// </summary>
public enum WhiteScrollOption : byte
{
    /// <summary>Not yet chosen.</summary>
    [Label("WHITE_SCROLL_NOT_SET")]
    [Label("Not Set", 1)]
    NotSet = 0,

    /// <summary>Do not use white scroll.</summary>
    [Label("WHITE_SCROLL_NO_USE")]
    [Label("No Use", 1)]
    NoUse = 1,

    /// <summary>Use white scroll.</summary>
    [Label("WHITE_SCROLL_USE")]
    Use = 2,
}
