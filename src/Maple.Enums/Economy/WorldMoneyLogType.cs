using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Economy/meso tracking log type for the world money audit system.
/// </summary>
public enum WorldMoneyLogType : byte
{
    /// <summary>Meso created via mob drop.</summary>
    [Label("IssuedOnDrop")]
    IssuedOnDrop = 0,

    /// <summary>Meso created via NPC shop sale.</summary>
    [Label("IssuedOnShop")]
    IssuedOnShop = 1,

    /// <summary>Meso created via admin shop.</summary>
    [Label("IssuedOnAdminShop")]
    IssuedOnAdminShop = 2,

    /// <summary>Meso created via quest reward.</summary>
    [Label("IssuedOnQuest")]
    IssuedOnQuest = 3,

    /// <summary>Meso created via script.</summary>
    [Label("IssuedOnScript")]
    IssuedOnScript = 4,

    /// <summary>Meso created via coupon.</summary>
    [Label("IssuedOnCoupon")]
    IssuedOnCoupon = 5,

    /// <summary>Meso created via lie detector.</summary>
    [Label("IssuedOnLieDetector")]
    IssuedOnLieDetector = 6,

    /// <summary>Meso created via mini game.</summary>
    [Label("IssuedOnMiniGame")]
    IssuedOnMiniGame = 7,

    /// <summary>Meso created via money pocket.</summary>
    [Label("IssuedOnMoneyPocket")]
    IssuedOnMoneyPocket = 8,

    /// <summary>Meso removed via NPC shop buy.</summary>
    [Label("RecalledByShop")]
    RecalledByShop = 100,

    /// <summary>Meso removed via admin shop.</summary>
    [Label("RecalledByAdminShop")]
    RecalledByAdminShop = 101,

    /// <summary>Meso removed via tax.</summary>
    [Label("RecalledByTax")]
    RecalledByTax = 102,

    /// <summary>Meso removed via quest cost.</summary>
    [Label("RecalledByQuest")]
    RecalledByQuest = 103,

    /// <summary>Meso removed via script.</summary>
    [Label("RecalledByScript")]
    RecalledByScript = 104,

    /// <summary>Meso removed via expiration.</summary>
    [Label("RecalledByExpire")]
    RecalledByExpire = 105,

    /// <summary>Meso removed via item maker fee.</summary>
    [Label("RecalledByItemMaker")]
    RecalledByItemMaker = 106,

    /// <summary>Meso removed via lie detector.</summary>
    [Label("RecalledByLieDetector")]
    RecalledByLieDetector = 107,

    /// <summary>Meso removed via mini game.</summary>
    [Label("RecalledByMiniGame")]
    RecalledByMiniGame = 108,

    /// <summary>Meso removed via claim fee.</summary>
    [Label("RecalledByClaim")]
    RecalledByClaim = 109,

    /// <summary>Meso removed via marriage fee.</summary>
    [Label("RecalledByMarriage")]
    RecalledByMarriage = 110,

    /// <summary>Meso removed via family fee.</summary>
    [Label("RecalledByFamily")]
    RecalledByFamily = 111,

    /// <summary>Meso removed via friend fee.</summary>
    [Label("RecalledByFriend")]
    RecalledByFriend = 112,

    /// <summary>Meso removed via guild fee.</summary>
    [Label("RecalledByGuild")]
    RecalledByGuild = 113,

    /// <summary>Meso removed via skill fee.</summary>
    [Label("RecalledBySkill")]
    RecalledBySkill = 114,

    /// <summary>Meso removed via party ad fee.</summary>
    [Label("RecalledByPartyAdver")]
    RecalledByPartyAdver = 115,

    /// <summary>Meso removed via durability repair.</summary>
    [Label("RecalledByRepairDurability")]
    RecalledByRepairDurability = 116,
}
