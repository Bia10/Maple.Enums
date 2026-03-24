using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Reason that item use is blocked for a character.
/// </summary>
public enum ItemUseBlockReason : byte
{
    /// <summary>Item use allowed.</summary>
    [Label("ITEM_USE_ALLOWED")]
    Allowed = 0,

    /// <summary>Blocked, unknown reason.</summary>
    [Label("ITEM_USE_BLOCKED_BY_UNKNOWN")]
    [Label("Blocked By Unknown", 1)]
    BlockedByUnknown = 1,

    /// <summary>Blocked by level.</summary>
    [Label("ITEM_USE_BLOCKED_BY_LEVEL")]
    [Label("Blocked By Level", 1)]
    BlockedByLevel = 2,

    /// <summary>Blocked by map.</summary>
    [Label("ITEM_USE_BLOCKED_BY_MAP")]
    [Label("Blocked By Map", 1)]
    BlockedByMap = 3,
}
