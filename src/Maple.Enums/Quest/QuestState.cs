using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Quest progress state.
/// </summary>
public enum QuestState : byte
{
    /// <summary>Quest not yet started.</summary>
    [Label("QUEST_STATE_NONE")]
    [Label("Not Started", 1)]
    NotStarted = 0,

    /// <summary>Quest currently active.</summary>
    [Label("QUEST_STATE_PERFORM")]
    [Label("In Progress", 1)]
    InProgress = 1,

    /// <summary>Quest fully completed.</summary>
    [Label("QUEST_STATE_COMPLETE")]
    Completed = 2,

    /// <summary>Party quest state.</summary>
    [Label("QUEST_STATE_PARTYQUEST")]
    [Label("Party Quest", 1)]
    PartyQuest = 3,

    /// <summary>Quest unavailable.</summary>
    [Label("QUEST_STATE_NO")]
    Cannot = 4,
}
