using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Medal quest category.
/// Classifies medal quest types.
/// </summary>
public enum MedalQuestCategory : byte
{
    /// <summary>Job advancement quest.</summary>
    [Label("MEDAL_QUEST_JOB")]
    Job = 0,

    /// <summary>Normal quest.</summary>
    [Label("MEDAL_QUEST_NORMAL")]
    Normal = 1,

    /// <summary>Challenge quest.</summary>
    [Label("MEDAL_QUEST_CHALLENGE")]
    Challenge = 2,

    /// <summary>Event quest.</summary>
    [Label("MEDAL_QUEST_EVENT")]
    Event = 3,
}
