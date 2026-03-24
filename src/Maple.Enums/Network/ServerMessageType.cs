using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Server message type.
/// Classifies types of messages displayed to the player via the system message UI.
/// </summary>
public enum ServerMessageType : byte
{
    /// <summary>Item or meso pickup notice.</summary>
    [Label("MS_DropPickUpMessage")]
    [Label("Drop Pick Up Message", 1)]
    DropPickUpMessage = 0,

    /// <summary>Quest progress update.</summary>
    [Label("MS_QuestRecordMessage")]
    [Label("Quest Record Message", 1)]
    QuestRecordMessage = 1,

    /// <summary>Cash item expired notice.</summary>
    [Label("MS_CashItemExpireMessage")]
    [Label("Cash Item Expire Message", 1)]
    CashItemExpireMessage = 2,

    /// <summary>EXP gained notice.</summary>
    [Label("MS_IncEXPMessage")]
    [Label("Inc Exp Message", 1)]
    IncExpMessage = 3,

    /// <summary>SP gained notice.</summary>
    [Label("MS_IncSPMessage")]
    [Label("Inc Sp Message", 1)]
    IncSpMessage = 4,

    /// <summary>Fame changed notice.</summary>
    [Label("MS_IncPOPMessage")]
    [Label("Inc Pop Message", 1)]
    IncPopMessage = 5,

    /// <summary>Mesos gained notice.</summary>
    [Label("MS_IncMoneyMessage")]
    [Label("Inc Money Message", 1)]
    IncMoneyMessage = 6,

    /// <summary>Guild points gained notice.</summary>
    [Label("MS_IncGPMessage")]
    [Label("Inc Gp Message", 1)]
    IncGpMessage = 7,

    /// <summary>Buff applied notice.</summary>
    [Label("MS_GiveBuffMessage")]
    [Label("Give Buff Message", 1)]
    GiveBuffMessage = 8,

    /// <summary>Regular item expired notice.</summary>
    [Label("MS_GeneralItemExpireMessage")]
    [Label("General Item Expire Message", 1)]
    GeneralItemExpireMessage = 9,

    /// <summary>System-wide broadcast.</summary>
    [Label("MS_SystemMessage")]
    [Label("System Message", 1)]
    SystemMessage = 10,

    /// <summary>Extended quest update.</summary>
    [Label("MS_QuestRecordExMessage")]
    [Label("Quest Record Ex Message", 1)]
    QuestRecordExMessage = 11,

    /// <summary>Item protection expired.</summary>
    [Label("MS_ItemProtectExpireMessage")]
    [Label("Item Protect Expire Message", 1)]
    ItemProtectExpireMessage = 12,

    /// <summary>Expiring item replacement notice.</summary>
    [Label("MS_ItemExpireReplaceMessage")]
    [Label("Item Expire Replace Message", 1)]
    ItemExpireReplaceMessage = 13,

    /// <summary>Skill buff expired notice.</summary>
    [Label("MS_SkillExpireMessage")]
    [Label("Skill Expire Message", 1)]
    SkillExpireMessage = 14,
}
