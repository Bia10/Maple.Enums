using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Cash shop purchase action type.
/// </summary>
public enum CashShopPurchaseType : byte
{
    /// <summary>Direct item purchase.</summary>
    [Label("CS_PURCHASE_BUY")]
    Buy = 0,

    /// <summary>Avatar item purchase.</summary>
    [Label("CS_PURCHASE_BUY_AVATAR")]
    [Label("Buy Avatar", 1)]
    BuyAvatar = 1,

    /// <summary>Gift to another player.</summary>
    [Label("CS_PURCHASE_GIFT")]
    Gift = 2,

    /// <summary>Inventory slot expansion.</summary>
    [Label("CS_INCREASE_SLOT")]
    [Label("Increase Slot", 1)]
    IncreaseSlot = 3,

    /// <summary>Gachapon copy purchase.</summary>
    [Label("CS_PURCHASE_CASHGACHAPONCOPY")]
    [Label("Cash Gachapon Copy", 1)]
    CashGachaponCopy = 4,
}
