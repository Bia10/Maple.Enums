using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Admin shop (NPC shop) trade failure result codes.
/// </summary>
public enum AdminShopTradeResult : byte
{
    /// <summary>No error.</summary>
    [Label("AdminShopTradeFail_None")]
    None = 0,

    /// <summary>Invalid serial number.</summary>
    [Label("AdminShopTradeFail_WrongSN")]
    [Label("Wrong Sn", 1)]
    WrongSn = 1,

    /// <summary>Level requirement not met.</summary>
    [Label("AdminShopTradeFail_WrongLevel")]
    [Label("Wrong Level", 1)]
    WrongLevel = 2,

    /// <summary>Outside sale period.</summary>
    [Label("AdminShopTradeFail_WrongPeriod")]
    [Label("Wrong Period", 1)]
    WrongPeriod = 3,

    /// <summary>Insufficient mesos.</summary>
    [Label("AdminShopTradeFail_NotEnoughMeso")]
    [Label("Not Enough Meso", 1)]
    NotEnoughMeso = 4,

    /// <summary>Meso cap exceeded.</summary>
    [Label("AdminShopTradeFail_TooMuchMeso")]
    [Label("Too Much Meso", 1)]
    TooMuchMeso = 5,

    /// <summary>Item permanently sold out.</summary>
    [Label("AdminShopTradeFail_SoldOut")]
    [Label("Sold Out", 1)]
    SoldOut = 6,

    /// <summary>Daily stock exhausted.</summary>
    [Label("AdminShopTradeFail_SoldOutForTheDay")]
    [Label("Sold Out For The Day", 1)]
    SoldOutForTheDay = 7,

    /// <summary>Per-player limit reached.</summary>
    [Label("AdminShopTradeFail_SoldOutForThePerson")]
    [Label("Sold Out For The Person", 1)]
    SoldOutForThePerson = 8,

    /// <summary>Purchase count exceeded.</summary>
    [Label("AdminShopTradeFail_OverCount")]
    [Label("Over Count", 1)]
    OverCount = 9,

    /// <summary>Trade is blocked.</summary>
    [Label("AdminShopTradeFail_TradeBlocked")]
    [Label("Trade Blocked", 1)]
    TradeBlocked = 10,

    /// <summary>Unknown failure.</summary>
    [Label("AdminShopTradeFail_Unknown")]
    Unknown = 11,
}
