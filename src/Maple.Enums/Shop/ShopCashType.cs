using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Currency type used when making a Cash Shop purchase.
/// </summary>
public enum ShopCashType : byte
{
    /// <summary>Nexon Cash (NX Credit).</summary>
    [Label("CS_CASHTYPE_NX")]
    NexonCash = 1,

    /// <summary>MaplePoints (bonus/earned NX).</summary>
    [Label("CS_CASHTYPE_MP")]
    MaplePoint = 2,

    /// <summary>Prepaid NX Cash card balance.</summary>
    [Label("CS_CASHTYPE_PREPAID")]
    PrepaidNxCash = 4,
}
