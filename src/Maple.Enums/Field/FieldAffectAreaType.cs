using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Field affect area (AoE) source type classification.
/// </summary>
public enum FieldAffectAreaType : byte
{
    /// <summary>Mob skill AoE.</summary>
    [Label("AffectArea_MobSkill")]
    [Label("Mob Skill", 1)]
    MobSkill = 0,

    /// <summary>Player skill AoE.</summary>
    [Label("AffectArea_UserSkill")]
    [Label("User Skill", 1)]
    UserSkill = 1,

    /// <summary>Smoke screen AoE.</summary>
    [Label("AffectArea_Smoke")]
    Smoke = 2,

    /// <summary>Buff zone AoE.</summary>
    [Label("AffectArea_Buff")]
    Buff = 3,

    /// <summary>Blessed mist AoE.</summary>
    [Label("AffectArea_BlessedMist")]
    [Label("Blessed Mist", 1)]
    BlessedMist = 4,
}
