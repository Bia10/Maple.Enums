using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// NPC quest indicator display states.
/// </summary>
public enum NpcQuestState : byte
{
    /// <summary>Quest available but not yet started.</summary>
    [Label("NPC_QUESTSTATE_PRESTART")]
    [Label("Pre Start", 1)]
    PreStart = 0,

    /// <summary>Quest in progress.</summary>
    [Label("NPC_QUESTSTATE_PERFORM")]
    Perform = 1,

    /// <summary>Quest ready to be completed.</summary>
    [Label("NPC_QUESTSTATE_PRECOMPLETE")]
    [Label("Pre Complete", 1)]
    PreComplete = 2,

    /// <summary>Quest available nearby.</summary>
    [Label("NPC_QUESTSTATE_NEARSTART")]
    [Label("Near Start", 1)]
    NearStart = 3,

    /// <summary>Quest available, show worthless indicator.</summary>
    [Label("NPC_QUESTSTATE_PRESTART_SHOW_WORTHLESS")]
    [Label("Pre Start Show Worthless", 1)]
    PreStartShowWorthless = 4,

    /// <summary>Quest available, hide worthless indicator.</summary>
    [Label("NPC_QUESTSTATE_PRESTART_HIDE_WORTHLESS")]
    [Label("Pre Start Hide Worthless", 1)]
    PreStartHideWorthless = 5,

    /// <summary>No quest indicator displayed.</summary>
    [Label("NPC_QUESTSTATE_NONE")]
    None = 6,
}
