using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Party advert job search filter flags — used when filtering party listings by job class.
/// </summary>
[Flags]
public enum PartyAdverJobSearchFlag : int
{
    /// <summary>No flags set.</summary>
    None = 0,

    /// <summary>Match all jobs.</summary>
    [Label("SEARCHING_JOB_ALLJOB")]
    [Label("All Job", 1)]
    AllJob = 0x1,

    /// <summary>Filter for Beginner class.</summary>
    [Label("SEARCHING_JOB_BEGINNER")]
    Beginner = 0x2,

    /// <summary>Filter for Warrior class.</summary>
    [Label("SEARCHING_JOB_WARRIOR")]
    Warrior = 0x4,

    /// <summary>Filter for Warrior 1st job branch.</summary>
    [Label("SEARCHING_JOB_WARRIOR1")]
    Warrior1 = 0x8,

    /// <summary>Filter for Warrior 2nd job branch.</summary>
    [Label("SEARCHING_JOB_WARRIOR2")]
    Warrior2 = 0x10,

    /// <summary>Filter for Warrior 3rd job branch.</summary>
    [Label("SEARCHING_JOB_WARRIOR3")]
    Warrior3 = 0x20,

    /// <summary>Filter for Soul Master (Cygnus Knight) class.</summary>
    [Label("SEARCHING_JOB_SOULMASTER")]
    [Label("Soul Master", 1)]
    SoulMaster = 0x40,

    /// <summary>Filter for Aran (Hero) class.</summary>
    [Label("SEARCHING_JOB_ARAN")]
    Aran = 0x80,

    /// <summary>Filter for Wizard/Magician class.</summary>
    [Label("SEARCHING_JOB_WIZARD")]
    Wizard = 0x100,

    /// <summary>Filter for Wizard 1st job branch.</summary>
    [Label("SEARCHING_JOB_WIZARD1")]
    Wizard1 = 0x200,

    /// <summary>Filter for Wizard 2nd job branch.</summary>
    [Label("SEARCHING_JOB_WIZARD2")]
    Wizard2 = 0x400,

    /// <summary>Filter for Wizard 3rd job branch.</summary>
    [Label("SEARCHING_JOB_WIZARD3")]
    Wizard3 = 0x800,

    /// <summary>Filter for Flame Wizard (Cygnus Knight) class.</summary>
    [Label("SEARCHING_JOB_FLAMEWIZARD")]
    [Label("Flame Wizard", 1)]
    FlameWizard = 0x1000,

    /// <summary>Filter for Evan (Hero) class.</summary>
    [Label("SEARCHING_JOB_EVAN")]
    Evan = 0x2000,

    /// <summary>Filter for Battle Mage (Resistance) class.</summary>
    [Label("SEARCHING_JOB_BMAGE")]
    BMage = 0x4000,

    /// <summary>Filter for Pirate class.</summary>
    [Label("SEARCHING_JOB_PIRATE")]
    Pirate = 0x8000,

    /// <summary>Filter for Pirate 1st job branch.</summary>
    [Label("SEARCHING_JOB_PIRATE1")]
    Pirate1 = 0x10000,

    /// <summary>Filter for Pirate 2nd job branch.</summary>
    [Label("SEARCHING_JOB_PIRATE2")]
    Pirate2 = 0x20000,

    /// <summary>Filter for Thunder Breaker/Striker (Cygnus Knight) class.</summary>
    [Label("SEARCHING_JOB_STRIKER")]
    Striker = 0x40000,

    /// <summary>Filter for Mechanic (Resistance) class.</summary>
    [Label("SEARCHING_JOB_MECHANIC")]
    Mechanic = 0x80000,

    /// <summary>Filter for Thief class.</summary>
    [Label("SEARCHING_JOB_THIEF")]
    Thief = 0x100000,

    // 0x200000 is reserved/unused in V95 — gap between Thief and Thief1 is intentional.

    /// <summary>Filter for Thief 1st job branch.</summary>
    [Label("SEARCHING_JOB_THIEF1")]
    Thief1 = 0x400000,

    /// <summary>Filter for Thief 2nd job branch.</summary>
    [Label("SEARCHING_JOB_THIEF2")]
    Thief2 = 0x800000,

    /// <summary>Filter for Night Walker (Cygnus Knight) class.</summary>
    [Label("SEARCHING_JOB_NIGHTWALKER")]
    [Label("Night Walker", 1)]
    NightWalker = 0x1000000,

    /// <summary>Filter for Dual Blade class.</summary>
    [Label("SEARCHING_JOB_DUALBLADE")]
    [Label("Dual Blade", 1)]
    DualBlade = 0x2000000,

    /// <summary>Filter for Bowman class.</summary>
    [Label("SEARCHING_JOB_BOWMAN")]
    Bowman = 0x4000000,

    /// <summary>Filter for Bowman 1st job branch.</summary>
    [Label("SEARCHING_JOB_BOWMAN1")]
    Bowman1 = 0x8000000,

    /// <summary>Filter for Bowman 2nd job branch.</summary>
    [Label("SEARCHING_JOB_BOWMAN2")]
    Bowman2 = 0x10000000,

    /// <summary>Filter for Wind Breaker (Cygnus Knight) class.</summary>
    [Label("SEARCHING_JOB_WINDBREAKER")]
    [Label("Wind Breaker", 1)]
    WindBreaker = 0x20000000,

    /// <summary>Filter for Wild Hunter (Resistance) class.</summary>
    [Label("SEARCHING_JOB_WILDHUNTER")]
    [Label("Wild Hunter", 1)]
    WildHunter = 0x40000000,
}
