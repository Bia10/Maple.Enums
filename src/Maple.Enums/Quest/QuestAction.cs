namespace Maple.Enums;

/// <summary>Quest start/complete action type sent by the client.</summary>
public enum QuestAction : byte
{
    /// <summary>Begin the quest.</summary>
    Start = 0,

    /// <summary>Complete the quest.</summary>
    End = 1,
}
