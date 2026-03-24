using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Evan dragon entity animation action type.
/// </summary>
public enum DragonActionType : byte
{
    /// <summary>Idle stance.</summary>
    [Label("DRAGONACT_STAND")]
    Stand = 0,

    /// <summary>Walking animation.</summary>
    [Label("DRAGONACT_MOVE")]
    Move = 1,

    /// <summary>Basic attack.</summary>
    [Label("DRAGONACT_SHOOT1")]
    Shoot1 = 2,

    /// <summary>Magic missile skill.</summary>
    [Label("DRAGONACT_MAGICMISSILE")]
    [Label("Magic Missile", 1)]
    MagicMissile = 3,

    /// <summary>Lightning bolt skill.</summary>
    [Label("DRAGONACT_LIGHTING_BOLT")]
    [Label("Lightning Bolt", 1)]
    LightningBolt = 4,

    /// <summary>Ice breath attack.</summary>
    [Label("DRAGONACT_ICE_BREATHE")]
    [Label("Ice Breathe", 1)]
    IceBreathe = 5,

    /// <summary>Fire breath attack.</summary>
    [Label("DRAGONACT_BREATHE")]
    Breathe = 6,

    /// <summary>Ice breath charge-up.</summary>
    [Label("DRAGONACT_ICE_BREATHE_PREPARE")]
    [Label("Ice Breathe Prepare", 1)]
    IceBreathePrepare = 7,

    /// <summary>Fire breath charge-up.</summary>
    [Label("DRAGONACT_BREATHE_PREPARE")]
    [Label("Breathe Prepare", 1)]
    BreathePrepare = 8,

    /// <summary>Blaze skill.</summary>
    [Label("DRAGONACT_BLAZE")]
    Blaze = 9,

    /// <summary>Fire circle skill.</summary>
    [Label("DRAGONACT_FIRE_CIRCLE")]
    [Label("Fire Circle", 1)]
    FireCircle = 10,

    /// <summary>Illusion skill.</summary>
    [Label("DRAGONACT_ILLUSION")]
    Illusion = 11,

    /// <summary>Magic flare skill.</summary>
    [Label("DRAGONACT_MAGICFLARE")]
    [Label("Magic Flare", 1)]
    MagicFlare = 12,

    /// <summary>Elemental reset buff.</summary>
    [Label("DRAGONACT_ELEMENTAL_RESET")]
    [Label("Elemental Reset", 1)]
    ElementalReset = 13,

    /// <summary>Magic resistance buff.</summary>
    /// <remarks>Documented original client typo in typos.md.</remarks>
    [Label("DRAGONACT_MAGIC_REGISTANCE")]
    [Label("Magic Resistance", 1)]
    MagicResistance = 14,

    /// <summary>Recovery aura buff.</summary>
    [Label("DRAGONACT_RECOVERY_AURA")]
    [Label("Recovery Aura", 1)]
    RecoveryAura = 15,

    /// <summary>Magic booster buff.</summary>
    [Label("DRAGONACT_MAGIC_BOOSTER")]
    [Label("Magic Booster", 1)]
    MagicBooster = 16,

    /// <summary>Magic shield buff.</summary>
    [Label("DRAGONACT_MAGIC_SHIELD")]
    [Label("Magic Shield", 1)]
    MagicShield = 17,

    /// <summary>Flame wheel attack.</summary>
    [Label("DRAGONACT_FLAME_WHEEL")]
    [Label("Flame Wheel", 1)]
    FlameWheel = 18,

    /// <summary>Killing wing attack.</summary>
    [Label("DRAGONACT_KILLING_WING")]
    [Label("Killing Wing", 1)]
    KillingWing = 19,

    /// <summary>Onyx blessing buff.</summary>
    [Label("DRAGONACT_ONIX_BLESSING")]
    [Label("Onix Blessing", 1)]
    OnixBlessing = 20,

    /// <summary>Earthquake attack.</summary>
    [Label("DRAGONACT_EARTHQUAKE")]
    Earthquake = 21,

    /// <summary>Soul stone revival.</summary>
    [Label("DRAGONACT_SOULSTONE")]
    [Label("Soul Stone", 1)]
    SoulStone = 22,

    /// <summary>Dragon thrust attack.</summary>
    [Label("DRAGONACT_DRAGONTHRUST")]
    [Label("Dragon Thrust", 1)]
    DragonThrust = 23,

    /// <summary>Ghost lettering skill.</summary>
    [Label("DRAGONACT_GHOST_LETTERING")]
    [Label("Ghost Lettering", 1)]
    GhostLettering = 24,

    /// <summary>Dark fog skill.</summary>
    [Label("DRAGONACT_DARKFOG")]
    [Label("Dark Fog", 1)]
    DarkFog = 25,

    /// <summary>Slow debuff skill.</summary>
    [Label("DRAGONACT_SLOW")]
    Slow = 26,

    /// <summary>Maple hero buff.</summary>
    [Label("DRAGONACT_MAPLE_HERO")]
    [Label("Maple Hero", 1)]
    MapleHero = 27,

    /// <summary>Dragon awakening.</summary>
    [Label("DRAGONACT_AWAKENING")]
    Awakening = 28,
}
