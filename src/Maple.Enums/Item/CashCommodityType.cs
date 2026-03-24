using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Cash item commodity type indicating sale / limitation status.
/// </summary>
public enum CashCommodityType : byte
{
    /// <summary>Normal commodity.</summary>
    [Label("CS_COMMODITY_NONE")]
    None = 0,

    /// <summary>Limited stock item.</summary>
    [Label("CS_COMMODITY_LIMITED")]
    Limited = 1,

    /// <summary>First-purchase cash limited.</summary>
    [Label("CS_COMMODITY_LIMITED_FIRST_CASH")]
    [Label("Limited First Cash", 1)]
    LimitedFirstCash = 2,

    /// <summary>Limited by NX credit ID.</summary>
    [Label("CS_COMMODITY_LIMITED_NXCID")]
    [Label("Limited Nxc Id", 1)]
    LimitedNxcId = 3,
}
