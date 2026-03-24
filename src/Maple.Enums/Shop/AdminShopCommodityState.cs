using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Admin shop commodity availability states.
/// </summary>
public enum AdminShopCommodityState : byte
{
    /// <summary>Item available for purchase.</summary>
    [Label("AdminShopCommodity_OnSale")]
    [Label("On Sale", 1)]
    OnSale = 0,

    /// <summary>Permanently sold out.</summary>
    [Label("AdminShopCommodity_SoldOut")]
    [Label("Sold Out", 1)]
    SoldOut = 1,

    /// <summary>Daily stock exhausted.</summary>
    [Label("AdminShopCommodity_SoldOutForTheDay")]
    [Label("Sold Out For The Day", 1)]
    SoldOutForTheDay = 2,

    /// <summary>Per-player limit reached.</summary>
    [Label("AdminShopCommodity_SoldOutForThePerson")]
    [Label("Sold Out For The Person", 1)]
    SoldOutForThePerson = 3,
}
