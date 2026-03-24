using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Extended quest job requirement flags for Resistance classes.
/// Bit 0x4 is reserved/unused in V95 — gap between Wildhunter (0x2) and Mechanic (0x8) is intentional.
/// </summary>
[Flags]
public enum QuestJobExFlags : byte
{
    /// <summary>No flags set.</summary>
    None = 0,

    /// <summary>Battle Mage class.</summary>
    [Label("Battle Mage", 1)]
    Bmage = 0x1,

    /// <summary>Wild Hunter class.</summary>
    [Label("Wild Hunter", 1)]
    WildHunter = 0x2,

    /// <summary>Mechanic class.</summary>
    Mechanic = 0x8,
}
