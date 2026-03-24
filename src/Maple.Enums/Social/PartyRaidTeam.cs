using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Party Raid (PvP) team assignment (Red vs Blue).
/// </summary>
public enum PartyRaidTeam : byte
{
    /// <summary>No team assigned.</summary>
    [Label("PRTeam_None")]
    None = 255,

    /// <summary>Red team.</summary>
    [Label("PRTeam_Red")]
    Red = 0,

    /// <summary>Blue team.</summary>
    [Label("PRTeam_Blue")]
    Blue = 1,
}
