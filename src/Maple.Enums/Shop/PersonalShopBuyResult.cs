using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Personal shop buy result codes.
/// </summary>
public enum PersonalShopBuyResult : byte
{
    /// <summary>Purchase completed successfully.</summary>
    [Label("PSBuy_Success")]
    Success = 0,

    /// <summary>Item is out of stock.</summary>
    [Label("PSBuy_NoStock")]
    [Label("No Stock", 1)]
    NoStock = 1,

    /// <summary>Buyer does not have enough mesos.</summary>
    [Label("PSBuy_NoMoney")]
    [Label("No Money", 1)]
    NoMoney = 2,

    /// <summary>Purchase price exceeds the allowed limit.</summary>
    [Label("PSBuy_OverPrice")]
    [Label("Over Price", 1)]
    OverPrice = 3,

    /// <summary>Shop owner would exceed the meso cap.</summary>
    [Label("PSBuy_HostTooMuchMoney")]
    [Label("Host Too Much Money", 1)]
    HostTooMuchMoney = 4,

    /// <summary>Buyer has no available inventory slot.</summary>
    [Label("PSBuy_NoSlot")]
    [Label("No Slot", 1)]
    NoSlot = 5,

    /// <summary>Only the specific item can be purchased.</summary>
    [Label("PSBuy_OnlyItem")]
    [Label("Only Item", 1)]
    OnlyItem = 6,

    /// <summary>Item is gender-restricted and does not match buyer.</summary>
    [Label("PSBuy_GenderMismatch")]
    [Label("Gender Mismatch", 1)]
    GenderMismatch = 7,

    /// <summary>Buyer is under the age-7 restriction.</summary>
    [Label("PSBuy_Under7Age")]
    Under7Age = 8,

    /// <summary>Item has expired.</summary>
    [Label("PSBuy_ItemExpired")]
    [Label("Item Expired", 1)]
    ItemExpired = 9,

    /// <summary>Purchase was denied.</summary>
    [Label("PSBuy_Denied")]
    Denied = 10,

    /// <summary>User is denied from purchasing.</summary>
    [Label("PSBuy_DeniedUser")]
    [Label("Denied User", 1)]
    DeniedUser = 11,

    /// <summary>Item CRC integrity check failed.</summary>
    [Label("PSBuy_ItemCRCFailed")]
    [Label("Item Crc Failed", 1)]
    ItemCrcFailed = 12,

    /// <summary>Unknown error occurred.</summary>
    [Label("PSBuy_Unknown")]
    Unknown = 13,

    /// <summary>Transaction exceeds the meso limit.</summary>
    [Label("PSBuy_MoneyLimit")]
    [Label("Money Limit", 1)]
    MoneyLimit = 14,
}
