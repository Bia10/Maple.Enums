using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Medal quest display state in the medal quest UI.
/// </summary>
public enum MedalQuestState : byte
{
    /// <summary>Quest in progress.</summary>
    [Label("MEDAL_QUEST_STATE_PERFORM")]
    Perform = 0,

    /// <summary>Quest obtainable.</summary>
    [Label("MEDAL_QUEST_STATE_OBTAINABLE")]
    Obtainable = 1,

    /// <summary>Quest unavailable.</summary>
    [Label("MEDAL_QUEST_STATE_NO")]
    No = 2,

    /// <summary>Quest completed.</summary>
    [Label("MEDAL_QUEST_STATE_COMPLETE")]
    Complete = 3,
}
