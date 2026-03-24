using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Mob attack range classification.
/// </summary>
public enum MobAttackRange : byte
{
    /// <summary>Melee range attack.</summary>
    [Label("AT_RANGE")]
    Range = 0,

    /// <summary>Ranged projectile attack.</summary>
    [Label("AT_SHOOT")]
    Shoot = 1,

    /// <summary>Piercing attack that passes through targets.</summary>
    [Label("AT_PIERCE")]
    Pierce = 2,

    /// <summary>Area-of-effect attack (type 1).</summary>
    [Label("AT_AREA1")]
    Area1 = 3,

    /// <summary>Area-of-effect attack (type 2).</summary>
    [Label("AT_AREA2")]
    Area2 = 4,
}
