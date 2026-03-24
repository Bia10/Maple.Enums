using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Quest lifecycle action type used in game log / server-side quest auditing.
/// </summary>
public enum QuestLogAction : int
{
    /// <summary>Quest accepted entry.</summary>
    [Label("QuestAccept")]
    Accept = 1,

    /// <summary>Quest completed entry.</summary>
    [Label("QuestComplete")]
    Complete = 2,

    /// <summary>Quest resigned entry.</summary>
    [Label("QuestResign")]
    Resign = 3,

    /// <summary>Quest failed entry.</summary>
    [Label("QuestFail")]
    Fail = 4,
}
