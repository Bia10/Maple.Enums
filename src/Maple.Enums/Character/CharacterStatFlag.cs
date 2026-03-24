using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Bitmask flags indicating which character stats to include in an update packet.
/// Used in CharacterStat encode/decode operations to selectively transmit stat fields.
/// </summary>
[Flags]
public enum CharacterStatFlag : uint
{
    /// <summary>No flags set.</summary>
    None = 0,

    /// <summary>Skin color.</summary>
    [Label("CS_SKIN")]
    Skin = 0x1,

    /// <summary>Face type.</summary>
    [Label("CS_FACE")]
    Face = 0x2,

    /// <summary>Hair style.</summary>
    [Label("CS_HAIR")]
    Hair = 0x4,

    /// <summary>Pet serial number, slot 1.</summary>
    [Label("CS_PETSN")]
    [Label("Pet Sn", 1)]
    PetSn = 0x8,

    /// <summary>Character level.</summary>
    [Label("CS_LEV")]
    Level = 0x10,

    /// <summary>Job class.</summary>
    [Label("CS_JOB")]
    Job = 0x20,

    /// <summary>Strength.</summary>
    [Label("CS_STR")]
    Str = 0x40,

    /// <summary>Dexterity.</summary>
    [Label("CS_DEX")]
    Dex = 0x80,

    /// <summary>Intelligence.</summary>
    [Label("CS_INT")]
    Int = 0x100,

    /// <summary>Luck.</summary>
    [Label("CS_LUK")]
    Luk = 0x200,

    /// <summary>Current HP.</summary>
    [Label("CS_HP")]
    Hp = 0x400,

    /// <summary>Max HP.</summary>
    [Label("CS_MHP")]
    [Label("Max HP", 1)]
    MaxHp = 0x800,

    /// <summary>Current MP.</summary>
    [Label("CS_MP")]
    Mp = 0x1000,

    /// <summary>Max MP.</summary>
    [Label("CS_MMP")]
    [Label("Max MP", 1)]
    MaxMp = 0x2000,

    /// <summary>Ability points.</summary>
    [Label("CS_AP")]
    Ap = 0x4000,

    /// <summary>Skill points.</summary>
    [Label("CS_SP")]
    Sp = 0x8000,

    /// <summary>Experience.</summary>
    [Label("CS_EXP")]
    Exp = 0x10000,

    /// <summary>Popularity (fame).</summary>
    [Label("CS_POP")]
    Pop = 0x20000,

    /// <summary>Mesos.</summary>
    [Label("CS_MONEY")]
    Money = 0x40000,

    /// <summary>Pet serial number, slot 2.</summary>
    [Label("CS_PETSN2")]
    [Label("Pet Sn2", 1)]
    PetSn2 = 0x80000,

    /// <summary>Pet serial number, slot 3.</summary>
    [Label("CS_PETSN3")]
    [Label("Pet Sn3", 1)]
    PetSn3 = 0x100000,

    /// <summary>Temporary experience.</summary>
    [Label("CS_TEMPEXP")]
    [Label("Temp Exp", 1)]
    TempExp = 0x200000,
}
