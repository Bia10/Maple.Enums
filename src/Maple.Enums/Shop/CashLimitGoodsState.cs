using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Cash shop limit goods availability state codes.
/// </summary>
public enum CashLimitGoodsState : int
{
    /// <summary>Not a limited good.</summary>
    [Label("CS_LimitGoodsState_NotLimitGoods")]
    [Label("Not Limit Goods", 1)]
    NotLimitGoods = -2,

    /// <summary>Stock remaining.</summary>
    [Label("CS_LimitGoodsState_Enough")]
    Enough = -1,

    /// <summary>Sold out.</summary>
    [Label("CS_LimitGoodsState_NoGoods")]
    [Label("No Goods", 1)]
    NoGoods = 1,

    /// <summary>Outside sale window.</summary>
    [Label("CS_LimitGoodsState_NotAvailableTime")]
    [Label("Not Available Time", 1)]
    NotAvailableTime = 2,

    /// <summary>Lookup error.</summary>
    [Label("CS_LimitGoodsState_SearchErr")]
    [Label("Search Error", 1)]
    SearchError = 3,
}
