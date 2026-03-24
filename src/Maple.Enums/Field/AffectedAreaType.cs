using FastEnumUtility;

namespace Maple.Enums;

/// <summary>Type of affected area zone spawned on a map field.</summary>
public enum AffectedAreaType : byte
{
    /// <summary>Area from mob skill.</summary>
    [Label("Mob Skill", 1)]
    MobSkill = 0,

    /// <summary>Area from player skill.</summary>
    [Label("User Skill", 1)]
    UserSkill = 1,

    /// <summary>Smoke screen zone.</summary>
    Smoke = 2,

    /// <summary>Buff-granting zone.</summary>
    Buff = 3,

    /// <summary>Blessed mist heal zone.</summary>
    [Label("Blessed Mist", 1)]
    BlessedMist = 4,
}
