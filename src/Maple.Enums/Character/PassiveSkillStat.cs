using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Passive skill stat rate indices
/// Used by the passive skill system to index into rate arrays.
/// </summary>
public enum PassiveSkillStat : byte
{
    /// <summary>Max HP rate.</summary>
    [Label("MHPR")]
    MaxHpRate = 0,

    /// <summary>Max MP rate.</summary>
    [Label("MMPR")]
    MaxMpRate = 1,

    /// <summary>Critical hit rate.</summary>
    [Label("CR")]
    CriticalRate = 2,

    /// <summary>Critical damage minimum.</summary>
    [Label("CDMIN")]
    CriticalDamageMin = 3,

    /// <summary>Accuracy rate.</summary>
    [Label("ACCR")]
    AccuracyRate = 4,

    /// <summary>Evasion rate.</summary>
    [Label("EVAR")]
    EvasionRate = 5,

    /// <summary>Attack rate.</summary>
    [Label("AR")]
    AttackRate = 6,

    /// <summary>Elemental resistance rate.</summary>
    [Label("ER")]
    ElementalRate = 7,

    /// <summary>Physical damage decrease rate.</summary>
    [Label("PDDR")]
    PhysicalDamageDecrease = 8,

    /// <summary>Magical damage decrease rate.</summary>
    [Label("MDDR")]
    MagicalDamageDecrease = 9,

    /// <summary>Physical defense rate.</summary>
    [Label("PDR")]
    PhysicalDefenseRate = 10,

    /// <summary>Magical defense rate.</summary>
    [Label("MDR")]
    MagicalDefenseRate = 11,

    /// <summary>Drop item probability rate.</summary>
    [Label("DIPR")]
    DropItemProbRate = 12,

    /// <summary>Physical damage rate.</summary>
    [Label("PDAMR")]
    PhysicalDamageRate = 13,

    /// <summary>Magical damage rate.</summary>
    [Label("MDAMR")]
    MagicalDamageRate = 14,

    /// <summary>Physical attack damage rate.</summary>
    [Label("PADR")]
    PhysicalAttackDamageRate = 15,

    /// <summary>Magical attack damage rate.</summary>
    [Label("MADR")]
    MagicalAttackDamageRate = 16,

    /// <summary>EXP gain rate.</summary>
    [Label("EXPR")]
    ExpRate = 17,

    /// <summary>Item drop probability rate.</summary>
    [Label("IMPR")]
    ItemProbRate = 18,

    /// <summary>Abnormal status resistance rate.</summary>
    [Label("ASRR")]
    AbnormalStatusResistRate = 19,

    /// <summary>Territory buff effect rate.</summary>
    [Label("TERR")]
    TerritoryEffectRate = 20,

    /// <summary>Meso gain rate.</summary>
    [Label("MESOR")]
    MesoRate = 21,
}
