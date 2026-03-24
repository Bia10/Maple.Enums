using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Quest completion result type.
/// Reason codes for quest start/complete validation.
/// </summary>
public enum QuestCompleteResultType : byte
{
    /// <summary>Quest completed successfully.</summary>
    [Label("QUEST_COMPLETESUCCESS")]
    Success = 0,

    /// <summary>Wrong NPC interaction.</summary>
    [Label("QUEST_COMPLETEFAIL_NPC")]
    [Label("Fail Npc", 1)]
    FailNpc = 1,

    /// <summary>Missing required items.</summary>
    [Label("QUEST_COMPLETEFAIL_ITEM")]
    [Label("Fail Item", 1)]
    FailItem = 2,

    /// <summary>Prerequisite quest incomplete.</summary>
    [Label("QUEST_COMPLETEFAIL_PREQUEST")]
    [Label("Fail Pre Quest", 1)]
    FailPreQuest = 3,

    /// <summary>Quest info check failed.</summary>
    [Label("QUEST_COMPLETEFAIL_INFO")]
    [Label("Fail Info", 1)]
    FailInfo = 4,

    /// <summary>Other info check failed.</summary>
    [Label("QUEST_COMPLETEFAIL_OTHERINFO")]
    [Label("Fail Other Info", 1)]
    FailOtherInfo = 5,

    /// <summary>Monster kill requirement unmet.</summary>
    [Label("QUEST_COMPLETEFAIL_MOB")]
    [Label("Fail Mob", 1)]
    FailMob = 6,

    /// <summary>Protected item conflict.</summary>
    [Label("QUEST_COMPLETEFAIL_PROTECTEDITEM")]
    [Label("Fail Protected Item", 1)]
    FailProtectedItem = 7,

    /// <summary>Required pet not found.</summary>
    [Label("QUEST_COMPLETEFAIL_PETNOEXIST")]
    [Label("Fail Pet No Exist", 1)]
    FailPetNoExist = 8,

    /// <summary>Pet condition not met.</summary>
    [Label("QUEST_COMPLETEFAIL_PETCONDITION")]
    [Label("Fail Pet Condition", 1)]
    FailPetCondition = 9,

    /// <summary>Insufficient meso amount.</summary>
    [Label("QUEST_COMPLETEFAIL_MESO")]
    [Label("Fail Meso", 1)]
    FailMeso = 10,

    /// <summary>Time requirement not met.</summary>
    [Label("QUEST_COMPLETEFAIL_TIME")]
    [Label("Fail Time", 1)]
    FailTime = 11,

    /// <summary>Unknown failure reason.</summary>
    [Label("QUEST_COMPLETEFAIL_UNKNOWN")]
    [Label("Fail Unknown", 1)]
    FailUnknown = 12,

    /// <summary>Wrong morph state.</summary>
    [Label("QUEST_COMPLETEFAIL_MORPH")]
    [Label("Fail Morph", 1)]
    FailMorph = 13,

    /// <summary>Required buff missing.</summary>
    [Label("QUEST_COMPLETEFAIL_BUFF")]
    [Label("Fail Buff", 1)]
    FailBuff = 14,

    /// <summary>Excluded buff is active.</summary>
    [Label("QUEST_COMPLETEFAIL_EXCEPTBUFF")]
    [Label("Fail Except Buff", 1)]
    FailExceptBuff = 15,

    /// <summary>Level requirement not met.</summary>
    [Label("QUEST_COMPLETEFAIL_LEVEL")]
    [Label("Fail Level", 1)]
    FailLevel = 16,

    /// <summary>Persistent timer not expired.</summary>
    [Label("QUEST_COMPLETEFAIL_TIMEKEEP")]
    [Label("Fail Time Keep", 1)]
    FailTimeKeep = 17,

    /// <summary>Wrong day of week.</summary>
    [Label("QUEST_COMPLETEFAIL_DAYOFWEEK")]
    [Label("Fail Day Of Week", 1)]
    FailDayOfWeek = 18,
}
