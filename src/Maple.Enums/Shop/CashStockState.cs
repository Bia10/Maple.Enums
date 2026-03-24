using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Cash shop stock availability state codes.
/// </summary>
public enum CashStockState : int
{
    /// <summary>Unlimited stock.</summary>
    [Label("CS_StockState_Infinite")]
    Infinite = -2,

    /// <summary>Stock available.</summary>
    [Label("CS_StockState_Enough")]
    Enough = -1,

    /// <summary>Out of stock.</summary>
    [Label("CS_StockState_NoStock")]
    [Label("No Stock", 1)]
    NoStock = 1,

    /// <summary>Outside sale period.</summary>
    [Label("CS_StockState_NotAvailableTime")]
    [Label("Not Available Time", 1)]
    NotAvailableTime = 2,
}
