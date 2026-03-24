using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Stored in Mob.wz/{id}.img/info/moveAbility and also WZ info/type in some WZ layouts.
/// </summary>
public enum MobMoveAbility : byte
{
    /// <summary>Stationary; cannot move.</summary>
    [Label("MOVEABILITY_STOP")]
    [Label("Stationary", 1)]
    Stop = 0,

    /// <summary>Walks along terrain.</summary>
    [Label("MOVEABILITY_WALK")]
    Walk = 1,

    /// <summary>Walks in random directions.</summary>
    [Label("MOVEABILITY_WALK_RANDOM")]
    [Label("Walk (Random)", 1)]
    WalkRandom = 2,

    /// <summary>Can jump over obstacles.</summary>
    [Label("MOVEABILITY_JUMP")]
    Jump = 3,

    /// <summary>Targeted flight toward a destination.</summary>
    [Label("MOVEABILITY_FLY")]
    Fly = 4,

    /// <summary>Flies in random directions.</summary>
    [Label("MOVEABILITY_FLY_RANDOM")]
    [Label("Fly (Random)", 1)]
    FlyRandom = 5,

    /// <summary>Follows/escorts another entity.</summary>
    [Label("MOVEABILITY_ESCORT")]
    Escort = 6,
}
