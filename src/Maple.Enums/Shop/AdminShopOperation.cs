using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Admin NPC shop protocol operation codes.
/// </summary>
public enum AdminShopOperation : byte
{
    /// <summary>Client opens admin shop.</summary>
    [Label("AdminShopReq_OpenShop")]
    [Label("Req Open Shop", 1)]
    ReqOpenShop = 0,

    /// <summary>Client requests purchase.</summary>
    [Label("AdminShopReq_Trade")]
    [Label("Req Trade", 1)]
    ReqTrade = 1,

    /// <summary>Client closes shop.</summary>
    [Label("AdminShopReq_Close")]
    [Label("Req Close", 1)]
    ReqClose = 2,

    /// <summary>Client adds wish-list item.</summary>
    [Label("AdminShopReq_WishItem")]
    [Label("Req Wish Item", 1)]
    ReqWishItem = 3,

    /// <summary>Server trade result.</summary>
    [Label("AdminShopRes_Trade")]
    [Label("Res Trade", 1)]
    ResTrade = 4,

    /// <summary>Server reports sold out.</summary>
    [Label("AdminShopRes_SoldOut")]
    [Label("Res Sold Out", 1)]
    ResSoldOut = 5,
}
