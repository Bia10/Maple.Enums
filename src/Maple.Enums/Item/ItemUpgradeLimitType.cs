using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Item upgrade limit type governing which item can constrain scroll upgrade damage.
/// </summary>
public enum ItemUpgradeLimitType : byte
{
    /// <summary>Invalid limit type.</summary>
    [Label("ITEM_UPGRADE_LIMIT_TYPE_ERROR")]
    Error = 0,

    /// <summary>Limited by another item.</summary>
    /// <remarks>Documented original client typo in typos.md.</remarks>
    [Label("ITEM_UPGRADE_LIMIT_TYPE_LIMITBYOHTERITEM")]
    [Label("Limit By Other Item", 1)]
    LimitByOtherItem = 1,
}
