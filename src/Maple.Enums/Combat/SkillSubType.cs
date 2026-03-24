using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Skill sub-type values stored in skill info/skillType WZ node.
/// Note: this is NOT an Active/Passive/Summon flag. Value 0 covers all regular skills.
/// Passive skills are identified by PsdSkillId != null; summon skills by a separate ID lookup.
/// </summary>
public enum SkillSubType : byte
{
    /// <summary>Normal active or buff skill.</summary>
    [Label("Active")]
    Regular = 0, // Normal active/buff/summon skill (no special sub-type)

    /// <summary>Mastery book skill.</summary>
    Mastery = 1, // Mastery book skill (ST_MASTERY)

    /// <summary>Weapon booster skill.</summary>
    Booster = 2, // Weapon booster (ST_BOOSTER)

    /// <summary>Auto-follow-up attack.</summary>
    [Label("Final Attack")]
    FinalAttack = 3, // Fires automatically after a normal attack (ST_FINALATTACK)

    /// <summary>Aran combo attack.</summary>
    [Label("Serial Attack")]
    SerialAttack = 4, // Aran combo serial attack (ST_SERIALATTACK)
}
