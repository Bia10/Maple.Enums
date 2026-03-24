namespace Maple.Enums;

/// <summary>
/// Reactor trigger event type.
/// Max value 100 fits in byte.
/// </summary>
public enum ReactorEventType : byte
{
    /// <summary>Player attacks reactor.</summary>
    Hit = 0,

    /// <summary>Player touches reactor.</summary>
    Touch = 1,

    /// <summary>Specific skill triggered.</summary>
    Skill = 2,

    /// <summary>Quest state condition.</summary>
    Quest = 3,

    /// <summary>State timer expired.</summary>
    Timeout = 100,
}
