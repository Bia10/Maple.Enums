using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Bitmask indicating which targets a skill combat action applies to.
/// </summary>
[Flags]
public enum SkillCombatTargetFlag : byte
{
    /// <summary>No flags set.</summary>
    None = 0,

    /// <summary>Targets the caster.</summary>
    [Label("SCT_Self")]
    Self = 0x1,

    /// <summary>Targets party members.</summary>
    [Label("SCT_Party")]
    Party = 0x2,

    /// <summary>Targets monsters.</summary>
    [Label("SCT_Mob")]
    Mob = 0x4,
}
