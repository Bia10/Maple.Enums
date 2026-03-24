namespace Maple.Enums;

/// <summary>
/// Job category bitmask for nrJob equip/skill requirements.
/// Formula: jobBit = 1 &lt;&lt; (jobCode % 1000 / 100 - 1), where jobCode % 1000 / 100 ∈ [1,5].
/// Special values: 0 = all jobs allowed; -1 = Beginner only.
/// Max value 0x1F fits in byte.
/// See: .claude/V95ClientRe/V95ReJobAndSkillSystem.md §3
/// </summary>
[Flags]
public enum JobCategory : byte
{
    /// <summary>No job restriction.</summary>
    None = 0,

    /// <summary>Warrior jobs.</summary>
    Warrior = 0x01, // jobCode % 1000 / 100 == 1 (e.g. 100, 110, 120, 130…)

    /// <summary>Magician jobs.</summary>
    Magician = 0x02, // jobCode % 1000 / 100 == 2 (e.g. 200, 210, 220, 230…)

    /// <summary>Bowman jobs.</summary>
    Bowman = 0x04, // jobCode % 1000 / 100 == 3 (e.g. 300, 310, 320…)

    /// <summary>Thief jobs.</summary>
    Thief = 0x08, // jobCode % 1000 / 100 == 4 (e.g. 400, 410, 420…)

    /// <summary>Pirate jobs.</summary>
    Pirate = 0x10, // jobCode % 1000 / 100 == 5 (e.g. 500, 510, 520…)
}
