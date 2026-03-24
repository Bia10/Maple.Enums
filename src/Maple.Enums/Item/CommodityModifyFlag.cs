using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Commodity (Cash Shop item definition) modification bit-flags.
/// </summary>
[Flags]
public enum CommodityModifyFlag : uint
{
    /// <summary>No flags set.</summary>
    None = 0,

    /// <summary>Item ID changed.</summary>
    [Label("CM_ITEMID")]
    [Label("Item Id", 1)]
    ItemId = 0x1,

    /// <summary>Quantity changed.</summary>
    [Label("CM_COUNT")]
    Count = 0x2,

    /// <summary>Price changed.</summary>
    [Label("CM_PRICE")]
    Price = 0x4,

    /// <summary>Bonus amount changed.</summary>
    [Label("CM_BONUS")]
    Bonus = 0x8,

    /// <summary>Sort priority changed.</summary>
    [Label("CM_PRIORITY")]
    Priority = 0x10,

    /// <summary>Duration changed.</summary>
    [Label("CM_PERIOD")]
    Period = 0x20,

    /// <summary>Maple Point price changed.</summary>
    [Label("CM_MAPLEPOINT")]
    [Label("Maple Point", 1)]
    MaplePoint = 0x40,

    /// <summary>Meso price changed.</summary>
    [Label("CM_MESO")]
    Meso = 0x80,

    /// <summary>Premium-only flag changed.</summary>
    [Label("CM_FORPREMIUMUSER")]
    [Label("For Premium User", 1)]
    ForPremiumUser = 0x100,

    /// <summary>Gender restriction changed.</summary>
    [Label("CM_COMMODITYGENDER")]
    [Label("Commodity Gender", 1)]
    CommodityGender = 0x200,

    /// <summary>On-sale flag changed.</summary>
    [Label("CM_ONSALE")]
    [Label("On Sale", 1)]
    OnSale = 0x400,

    /// <summary>Category class changed.</summary>
    [Label("CM_CLASS")]
    Class = 0x800,

    /// <summary>Purchase limit changed.</summary>
    [Label("CM_LIMIT")]
    Limit = 0x1000,

    /// <summary>Prepaid cash flag changed.</summary>
    [Label("CM_PBCASH")]
    [Label("Pb Cash", 1)]
    PbCash = 0x2000,

    /// <summary>Prepaid point flag changed.</summary>
    [Label("CM_PBPOINT")]
    [Label("Pb Point", 1)]
    PbPoint = 0x4000,

    /// <summary>Prepaid gift flag changed.</summary>
    [Label("CM_PBGIFT")]
    [Label("Pb Gift", 1)]
    PbGift = 0x8000,

    /// <summary>Package SN changed.</summary>
    [Label("CM_PACKAGESN")]
    [Label("Package Sn", 1)]
    PackageSn = 0x10000,

    /// <summary>Required fame changed.</summary>
    [Label("CM_REQPOP")]
    [Label("Req Pop", 1)]
    ReqPop = 0x20000,

    /// <summary>Required level changed.</summary>
    [Label("CM_REQLEV")]
    [Label("Req Lev", 1)]
    ReqLev = 0x40000,

    /// <summary>All fields modified.</summary>
    [Label("CM_ALL")]
    All = 0x7FFFF,
}
