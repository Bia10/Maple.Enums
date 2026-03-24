using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Quest job requirement flags — bitmask of job branches a quest is available to.
/// </summary>
[Flags]
public enum QuestJobFlags : uint
{
    /// <summary>No flags set.</summary>
    None = 0,

    /// <summary>Explorer Beginner.</summary>
    Novice = 0x1,

    /// <summary>Explorer Warrior branch.</summary>
    Swordman = 0x2,

    /// <summary>Explorer Magician branch.</summary>
    Magician = 0x4,

    /// <summary>Explorer Archer branch.</summary>
    Archer = 0x8,

    /// <summary>Explorer Thief branch.</summary>
    Rogue = 0x10,

    /// <summary>Explorer Pirate branch.</summary>
    Pirate = 0x20,

    // Bits 0x40–0x200 are reserved/unused in V95 (gap between Pirate and Noblesse).

    /// <summary>Cygnus Knight Beginner.</summary>
    Noblesse = 0x400,

    /// <summary>Cygnus Dawn Warrior.</summary>
    [Label("Soul Fighter", 1)]
    SoulFighter = 0x800,

    /// <summary>Cygnus Blaze Wizard.</summary>
    [Label("Flame Wizard", 1)]
    FlameWizard = 0x1000,

    /// <summary>Cygnus Wind Archer.</summary>
    [Label("Wind Breaker", 1)]
    WindBreaker = 0x2000,

    /// <summary>Cygnus Night Walker.</summary>
    [Label("Night Walker", 1)]
    NightWalker = 0x4000,

    /// <summary>Cygnus Thunder Breaker.</summary>
    [Label("Thunder Breaker", 1)]
    Striker = 0x8000,

    // Bits 0x10000–0x80000 are reserved/unused in V95 (gap between Striker and Legend).

    /// <summary>Legend Beginner class.</summary>
    Legend = 0x100000,

    /// <summary>Aran hero class.</summary>
    Aran = 0x200000,

    /// <summary>Evan dragon master.</summary>
    Evan = 0x400000,
}
