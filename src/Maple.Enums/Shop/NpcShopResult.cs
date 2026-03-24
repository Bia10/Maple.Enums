using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// NPC/admin shop response result codes sent by the server.
/// </summary>
public enum NpcShopResult : byte
{
    /// <summary>Purchase completed successfully.</summary>
    [Label("ShopRes_BuySuccess")]
    [Label("Buy Success", 1)]
    BuySuccess = 0,

    /// <summary>Purchase failed: item out of stock.</summary>
    [Label("ShopRes_BuyNoStock")]
    [Label("Buy No Stock", 1)]
    BuyNoStock = 1,

    /// <summary>Purchase failed: insufficient mesos.</summary>
    [Label("ShopRes_BuyNoMoney")]
    [Label("Buy No Money", 1)]
    BuyNoMoney = 2,

    /// <summary>Purchase failed: unknown error.</summary>
    [Label("ShopRes_BuyUnknown")]
    [Label("Buy Unknown", 1)]
    BuyUnknown = 3,

    /// <summary>Sale completed successfully.</summary>
    [Label("ShopRes_SellSuccess")]
    [Label("Sell Success", 1)]
    SellSuccess = 4,

    /// <summary>Sale failed: no stock available.</summary>
    [Label("ShopRes_SellNoStock")]
    [Label("Sell No Stock", 1)]
    SellNoStock = 5,

    /// <summary>Sale failed: incorrect request.</summary>
    [Label("ShopRes_SellIncorrectRequest")]
    [Label("Sell Incorrect Request", 1)]
    SellIncorrectRequest = 6,

    /// <summary>Sale failed: unknown error.</summary>
    /// <remarks>Documented original client typo in typos.md.</remarks>
    [Label("ShopRes_SellUnkonwn")]
    [Label("Sell Unknown", 1)]
    SellUnknown = 7,

    /// <summary>Recharge completed successfully.</summary>
    [Label("ShopRes_RechargeSuccess")]
    [Label("Recharge Success", 1)]
    RechargeSuccess = 8,

    /// <summary>Recharge failed: no stock available.</summary>
    [Label("ShopRes_RechargeNoStock")]
    [Label("Recharge No Stock", 1)]
    RechargeNoStock = 9,

    /// <summary>Recharge failed: insufficient mesos.</summary>
    [Label("ShopRes_RechargeNoMoney")]
    [Label("Recharge No Money", 1)]
    RechargeNoMoney = 10,

    /// <summary>Recharge failed: incorrect request.</summary>
    [Label("ShopRes_RechargeIncorrectRequest")]
    [Label("Recharge Incorrect Request", 1)]
    RechargeIncorrectRequest = 11,

    /// <summary>Recharge failed: unknown error.</summary>
    [Label("ShopRes_RechargeUnknown")]
    [Label("Recharge Unknown", 1)]
    RechargeUnknown = 12,

    /// <summary>Purchase failed: insufficient tokens.</summary>
    [Label("ShopRes_BuyNoToken")]
    [Label("Buy No Token", 1)]
    BuyNoToken = 13,

    /// <summary>Restricted: character level too low.</summary>
    [Label("ShopRes_LimitLevel_Less")]
    [Label("Limit Level Less", 1)]
    LimitLevelLess = 14,

    /// <summary>Restricted: character level too high.</summary>
    [Label("ShopRes_LimitLevel_More")]
    [Label("Limit Level More", 1)]
    LimitLevelMore = 15,

    /// <summary>Purchase failed: item buy limit reached.</summary>
    [Label("ShopRes_CantBuyAnymore")]
    [Label("Cant Buy Anymore", 1)]
    CantBuyAnymore = 16,

    /// <summary>Transaction blocked by trade restrictions.</summary>
    [Label("ShopRes_TradeBlocked")]
    [Label("Trade Blocked", 1)]
    TradeBlocked = 17,

    /// <summary>Purchase failed: buy limit exceeded.</summary>
    [Label("ShopRes_BuyLimit")]
    [Label("Buy Limit", 1)]
    BuyLimit = 18,

    /// <summary>Server message response.</summary>
    [Label("ShopRes_ServerMsg")]
    [Label("Server Msg", 1)]
    ServerMsg = 19,
}
