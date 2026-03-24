using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Item log operation type indicating the kind of item transfer.
/// </summary>
public enum ItemLogType : byte
{
    /// <summary>Character-to-character.</summary>
    [Label("ITEMLOG_TYPE_CHARTOCHAR")]
    [Label("Char To Char", 1)]
    CharToChar = 0,

    /// <summary>Character to storage.</summary>
    [Label("ITEMLOG_TYPE_CHARTOSPOT")]
    [Label("Char To Spot", 1)]
    CharToSpot = 1,

    /// <summary>Storage to character.</summary>
    [Label("ITEMLOG_TYPE_SPOTTOCHAR")]
    [Label("Spot To Char", 1)]
    SpotToChar = 2,

    /// <summary>Item destroyed.</summary>
    [Label("ITEMLOG_TYPE_DESTROY")]
    Destroy = 3,

    /// <summary>Item created.</summary>
    [Label("ITEMLOG_TYPE_CREATE")]
    Create = 4,

    /// <summary>Item count adjustment.</summary>
    [Label("ITEMLOG_TYPE_ITEMCOUNT")]
    [Label("Item Count", 1)]
    ItemCount = 99,
}
