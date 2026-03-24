using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Mob ban/kill type.
/// </summary>
public enum MobBanType : sbyte
{
    /// <summary>No ban type specified.</summary>
    [Label("MOBBANTYPE_NONE")]
    None = 0,

    /// <summary>Mob removed by collision.</summary>
    [Label("MOBBANTYPE_COLLISION")]
    Collision = 1,

    /// <summary>Mob killed by player attack.</summary>
    [Label("MOBBANTYPE_USERATTACK")]
    [Label("User Attack", 1)]
    UserAttack = 2,

    /// <summary>Mob removed by another mob's skill.</summary>
    [Label("MOBBANTYPE_MOBSKILL")]
    [Label("Mob Skill", 1)]
    MobSkill = -1,
}
