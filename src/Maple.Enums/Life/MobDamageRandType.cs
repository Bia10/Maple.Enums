using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Mob RNG damage outcome category used when processing combat hits.
/// </summary>
public enum MobDamageRandType : byte
{
    /// <summary>Normal damage roll.</summary>
    [Label("MOB_DAMAGERAND_NORMAL")]
    Normal = 0,

    /// <summary>Fake (miss-display) damage roll.</summary>
    [Label("MOB_DAMAGERAND_FAKE")]
    Fake = 1,

    /// <summary>Blind-state reduced accuracy damage roll.</summary>
    [Label("MOB_DAMAGERAND_BLIND")]
    Blind = 2,

    /// <summary>Blocked damage roll.</summary>
    [Label("MOB_DAMAGERAND_BLOCKING")]
    Blocking = 3,

    /// <summary>Guarded damage roll.</summary>
    [Label("MOB_DAMAGERAND_GUARD")]
    Guard = 4,

    /// <summary>Swallow-evasion damage roll.</summary>
    [Label("MOB_DAMAGERAND_SWALLOW_EVASION")]
    [Label("Swallow Evasion", 1)]
    SwallowEvasion = 5,

    /// <summary>No damage roll applied.</summary>
    [Label("MOB_DAMAGERAND_NO")]
    No = 6,
}
