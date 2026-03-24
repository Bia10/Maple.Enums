using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Character job class code.
/// </summary>
public enum JobClass : byte
{
    /// <summary>No class.</summary>
    [Label("JC_NONE")]
    None = 0,

    /// <summary>Warrior class.</summary>
    [Label("JC_FIGHTER")]
    Fighter = 1,

    /// <summary>Mage class.</summary>
    [Label("JC_WIZARD")]
    Wizard = 2,

    /// <summary>Bowman class.</summary>
    [Label("JC_ARCHER")]
    Archer = 3,

    /// <summary>Thief class.</summary>
    [Label("JC_THIEF")]
    Thief = 4,

    /// <summary>Pirate class.</summary>
    [Label("JC_PIRATE")]
    Pirate = 5,

    /// <summary>Non-admin sentinel.</summary>
    [Label("JC_NO_WO_ADMIN")]
    [Label("No Wo Admin", 1)]
    NoWoAdmin = 6,

    /// <summary>Manager class.</summary>
    [Label("JC_MANAGER")]
    Manager = 8,

    /// <summary>Admin class.</summary>
    [Label("JC_ADMIN")]
    Admin = 9,

    /// <summary>Invalid class sentinel.</summary>
    [Label("JC_NO")]
    [Label("No Class", 1)]
    NoClass = 10,

    /// <summary>Dawn Warrior KoC.</summary>
    [Label("JC_SOULMASTER")]
    [Label("Soul Master", 1)]
    SoulMaster = 11,

    /// <summary>Blaze Wizard KoC.</summary>
    [Label("JC_FLAMEWIZARD")]
    [Label("Flame Wizard", 1)]
    FlameWizard = 12,

    /// <summary>Wind Archer KoC.</summary>
    [Label("JC_WINDBREAKER")]
    [Label("Wind Breaker", 1)]
    WindBreaker = 13,

    /// <summary>Night Walker KoC.</summary>
    [Label("JC_NIGHTWALKER")]
    [Label("Night Walker", 1)]
    NightWalker = 14,

    /// <summary>Thunder Breaker KoC.</summary>
    [Label("JC_STRIKER")]
    Striker = 15,

    /// <summary>Aran hero.</summary>
    [Label("JC_ARAN")]
    Aran = 21,

    /// <summary>Evan hero.</summary>
    [Label("JC_EVAN")]
    Evan = 22,

    /// <summary>Battle Mage resistance.</summary>
    [Label("JC_RES_WIZARD")]
    [Label("Res BMage", 1)]
    ResBMage = 32,

    /// <summary>Wild Hunter resistance.</summary>
    [Label("JC_RES_ARCHER")]
    [Label("Res Wild Hunt", 1)]
    ResWildHunt = 33,

    /// <summary>Mechanic resistance.</summary>
    [Label("JC_RES_PIRATE")]
    [Label("Res Mechanic", 1)]
    ResMechanic = 35,

    /// <summary>Dual Blade thief.</summary>
    [Label("JC_DUAL")]
    [Label("Dual Blade", 1)]
    DualBlade = 43,
}
