using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Item log source indicating where an item originated or was consumed.
/// </summary>
public enum ItemLogSource : byte
{
    /// <summary>Unknown source.</summary>
    [Label("ITEMLOG_NONE")]
    None = 0,

    /// <summary>Picked up from ground.</summary>
    [Label("ITEMLOG_GROUND")]
    Ground = 1,

    /// <summary>Purchased from NPC shop.</summary>
    [Label("ITEMLOG_SHOP")]
    Shop = 2,

    /// <summary>Purchased from Cash Shop.</summary>
    [Label("ITEMLOG_CASHSHOP")]
    [Label("Cash Shop", 1)]
    CashShop = 3,

    /// <summary>Storage trunk.</summary>
    [Label("ITEMLOG_TRUNK")]
    Trunk = 4,

    /// <summary>Item expired.</summary>
    [Label("ITEMLOG_EXPIRED")]
    Expired = 5,

    /// <summary>Player trade.</summary>
    [Label("ITEMLOG_EXCHANGE")]
    Exchange = 6,

    /// <summary>Player shop.</summary>
    [Label("ITEMLOG_PERSONALSHOP")]
    [Label("Personal Shop", 1)]
    PersonalShop = 7,

    /// <summary>Hired merchant.</summary>
    [Label("ITEMLOG_ENTRUSTEDSHOP")]
    [Label("Entrusted Shop", 1)]
    EntrustedShop = 8,

    /// <summary>Mail parcel.</summary>
    [Label("ITEMLOG_PARCEL")]
    Parcel = 9,

    /// <summary>Quest reward.</summary>
    [Label("ITEMLOG_QUEST")]
    Quest = 10,

    /// <summary>Script-generated.</summary>
    [Label("ITEMLOG_SCRIPT")]
    Script = 11,

    /// <summary>GM command.</summary>
    [Label("ITEMLOG_ADMIN")]
    Admin = 12,

    /// <summary>Monster capture.</summary>
    [Label("ITEMLOG_BRIDLE")]
    Bridle = 13,

    /// <summary>Gachapon machine.</summary>
    [Label("ITEMLOG_GACHAPON")]
    Gachapon = 14,

    /// <summary>Duration expired.</summary>
    [Label("ITEMLOG_TIMEOVER")]
    [Label("Time Over", 1)]
    TimeOver = 15,

    /// <summary>Destroyed by scroll.</summary>
    [Label("ITEMLOG_CURSEDSCROLL")]
    [Label("Cursed Scroll", 1)]
    CursedScroll = 16,

    /// <summary>Lottery reward.</summary>
    [Label("ITEMLOG_LOTTERY")]
    Lottery = 17,

    /// <summary>Wedding event.</summary>
    [Label("ITEMLOG_WEDDING")]
    Wedding = 18,

    /// <summary>Crafted via Item Maker.</summary>
    [Label("ITEMLOG_ITEMMAKE")]
    [Label("Item Make", 1)]
    ItemMake = 19,

    /// <summary>Special medal reward.</summary>
    [Label("ITEMLOG_SPECIALMEDAL")]
    [Label("Special Medal", 1)]
    SpecialMedal = 20,

    /// <summary>Admin shop purchase.</summary>
    [Label("ITEMLOG_ADMINSHOP")]
    [Label("Admin Shop", 1)]
    AdminShop = 21,

    /// <summary>Event reward.</summary>
    [Label("ITEMLOG_EVENTREWARD")]
    [Label("Event Reward", 1)]
    EventReward = 22,

    /// <summary>Item replacement.</summary>
    [Label("ITEMLOG_REPLACE")]
    Replace = 23,

    /// <summary>Aran tutorial reward.</summary>
    [Label("ITEMLOG_ARANTUTORIAL")]
    [Label("Aran Tutorial", 1)]
    AranTutorial = 24,
}
