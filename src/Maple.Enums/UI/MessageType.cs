using FastEnumUtility;

namespace Maple.Enums;

/// <summary>Client message notification type (item pickup, EXP gain, quest update, etc.).</summary>
public enum MessageType : byte
{
    /// <summary>Item drop pickup notification.</summary>
    [Label("Drop Pick Up", 1)]
    DropPickUp = 0,

    /// <summary>Quest progress record update.</summary>
    [Label("Quest Record", 1)]
    QuestRecord = 1,

    /// <summary>Cash item expiration notice.</summary>
    [Label("Cash Item Expire", 1)]
    CashItemExpire = 2,

    /// <summary>Experience points gained notification.</summary>
    [Label("Inc EXP", 1)]
    IncEXP = 3,

    /// <summary>Skill points gained notification.</summary>
    [Label("Inc SP", 1)]
    IncSP = 4,

    /// <summary>Fame/popularity change notification.</summary>
    [Label("Inc POP", 1)]
    IncPOP = 5,

    /// <summary>Mesos gained or lost notification.</summary>
    [Label("Inc Money", 1)]
    IncMoney = 6,

    /// <summary>Guild points gained notification.</summary>
    [Label("Inc GP", 1)]
    IncGP = 7,

    /// <summary>Buff effect applied notification.</summary>
    [Label("Give Buff", 1)]
    GiveBuff = 8,

    /// <summary>General item expiration notice.</summary>
    [Label("General Item Expire", 1)]
    GeneralItemExpire = 9,

    /// <summary>System message broadcast.</summary>
    System = 10,

    /// <summary>Extended quest record update.</summary>
    [Label("Quest Record Ex", 1)]
    QuestRecordEx = 11,

    /// <summary>Item protection expiration notice.</summary>
    [Label("Item Protect Expire", 1)]
    ItemProtectExpire = 12,

    /// <summary>Item expiration with replacement notice.</summary>
    [Label("Item Expire Replace", 1)]
    ItemExpireReplace = 13,

    /// <summary>Skill effect expiration notice.</summary>
    [Label("Skill Expire", 1)]
    SkillExpire = 14,
}
