using FastEnumUtility;

namespace Maple.Enums;

/// <summary>Client quest request operation type.</summary>
public enum QuestRequestType : byte
{
    /// <summary>Recover lost quest item.</summary>
    [Label("Lost Item", 1)]
    LostItem = 0,

    /// <summary>Accept a quest.</summary>
    [Label("Accept Quest", 1)]
    AcceptQuest = 1,

    /// <summary>Complete a quest.</summary>
    [Label("Complete Quest", 1)]
    CompleteQuest = 2,

    /// <summary>Resign from quest.</summary>
    [Label("Resign Quest", 1)]
    ResignQuest = 3,

    /// <summary>Run quest start script.</summary>
    [Label("Opening Script", 1)]
    OpeningScript = 4,

    /// <summary>Run quest end script.</summary>
    [Label("Complete Script", 1)]
    CompleteScript = 5,
}
