using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// NPC/admin shop request operation codes sent by the client.
/// </summary>
public enum NpcShopOperation : byte
{
    /// <summary>Client request to buy an item.</summary>
    [Label("ShopReq_Buy")]
    Buy = 0,

    /// <summary>Client request to sell an item.</summary>
    [Label("ShopReq_Sell")]
    Sell = 1,

    /// <summary>Client request to recharge a rechargeable item.</summary>
    [Label("ShopReq_Recharge")]
    Recharge = 2,

    /// <summary>Client request to close the shop.</summary>
    [Label("ShopReq_Close")]
    Close = 3,
}
