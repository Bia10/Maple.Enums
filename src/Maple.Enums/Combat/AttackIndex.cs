using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Attack source index types (mob physical, mob magic, counter, obstacle, stat).
/// </summary>
public enum AttackIndex : int
{
    /// <summary>Physical mob attack.</summary>
    [Label("AttackIndex_Mob_Physical")]
    [Label("Mob Physical", 1)]
    MobPhysical = 0,

    /// <summary>Magic mob attack.</summary>
    [Label("AttackIndex_Mob_Magic")]
    [Label("Mob Magic", 1)]
    MobMagic = -1,

    /// <summary>Counter / reflect damage.</summary>
    [Label("AttackIndex_Counter")]
    Counter = -2,

    /// <summary>Map obstacle damage.</summary>
    [Label("AttackIndex_Obstacle")]
    Obstacle = -3,

    /// <summary>Status effect damage.</summary>
    [Label("AttackIndex_Stat")]
    Stat = -4,
}
