using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Monster Carnival team assignment.
/// </summary>
public enum MonsterCarnivalTeam : byte
{
    /// <summary>No team assigned.</summary>
    [Label("MCARNIVAL_TEAM_NONE")]
    None = 255,

    /// <summary>Red team.</summary>
    [Label("MCARNIVAL_TEAM_RED")]
    Red = 0,

    /// <summary>Blue team.</summary>
    [Label("MCARNIVAL_TEAM_BLUE")]
    Blue = 1,
}
