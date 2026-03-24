using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Battlefield (PvP) team assignment.
/// Used in sheep vs wolves PvP event.
/// </summary>
public enum BattlefieldTeam : byte
{
    /// <summary>No team assigned.</summary>
    [Label("BATTLEFIELD_TEAM_NONE")]
    None = 255,

    /// <summary>Sheep (defender) team.</summary>
    [Label("BATTLEFIELD_TEAM_SHEEP")]
    Sheep = 0,

    /// <summary>Wolves (attacker) team.</summary>
    [Label("BATTLEFIELD_TEAM_WOLVES")]
    Wolves = 1,

    /// <summary>Naked sheep variant.</summary>
    [Label("BATTLEFIELD_TEAM_SHEEP_NAKED")]
    [Label("Sheep Naked", 1)]
    SheepNaked = 2,
}
