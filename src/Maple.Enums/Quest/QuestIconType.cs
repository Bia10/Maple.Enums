using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Quest icon types displayed over NPC heads.
/// </summary>
public enum QuestIconType : byte
{
    /// <summary>No icon displayed.</summary>
    [Label("QUEST_ICONTYPE_NONE")]
    None = 0,

    /// <summary>Quest available icon.</summary>
    [Label("QUEST_ICONTYPE_PERFORM")]
    Perform = 1,

    /// <summary>Quest nearly complete.</summary>
    [Label("QUEST_ICONTYPE_PRECOMPLETE")]
    [Label("Pre Complete", 1)]
    PreComplete = 2,

    /// <summary>Quest completable icon.</summary>
    [Label("QUEST_ICONTYPE_COMPLETE")]
    Complete = 3,

    /// <summary>Timed quest icon.</summary>
    [Label("QUEST_ICONTYPE_TIMER")]
    Timer = 4,

    /// <summary>Series quest available.</summary>
    [Label("QUEST_ICONTYPE_PERFORM_SERIES")]
    [Label("Perform Series", 1)]
    PerformSeries = 5,
}
