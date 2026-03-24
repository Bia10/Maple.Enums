using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Summoned creature attack state machine phase.
/// </summary>
public enum SummonedAttackState : byte
{
    /// <summary>No active attack.</summary>
    [Label("AS_NONE")]
    None = 0,

    /// <summary>Pre-hit windup phase.</summary>
    [Label("AS_BEFOREHIT")]
    [Label("Before Hit", 1)]
    BeforeHit = 1,

    /// <summary>Attack connecting.</summary>
    [Label("AS_HIT")]
    Hit = 2,

    /// <summary>Cooldown between attacks.</summary>
    [Label("AS_WAITING")]
    Waiting = 3,

    /// <summary>Leaving or despawning.</summary>
    [Label("AS_LEAVE")]
    Leave = 4,
}
