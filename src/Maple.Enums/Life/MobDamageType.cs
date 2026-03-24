using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Mob damage display randomisation types.
/// </summary>
public enum MobDamageType : byte
{
    /// <summary>Normal damage display.</summary>
    [Label("MOB_DAMAGERAND_NORMAL")]
    Normal = 0,

    /// <summary>Fake (miss-display) damage number.</summary>
    [Label("MOB_DAMAGERAND_FAKE")]
    Fake = 1,

    /// <summary>Blind-state reduced accuracy display.</summary>
    [Label("MOB_DAMAGERAND_BLIND")]
    Blind = 2,

    /// <summary>Blocked damage display.</summary>
    [Label("MOB_DAMAGERAND_BLOCKING")]
    Blocking = 3,

    /// <summary>Guarded damage display.</summary>
    [Label("MOB_DAMAGERAND_GUARD")]
    Guard = 4,

    /// <summary>Swallow-evasion damage display.</summary>
    [Label("MOB_DAMAGERAND_SWALLOW_EVASION")]
    [Label("Swallow Evasion", 1)]
    SwallowEvasion = 5,

    /// <summary>No damage display.</summary>
    [Label("MOB_DAMAGERAND_NO")]
    No = 6,
}
