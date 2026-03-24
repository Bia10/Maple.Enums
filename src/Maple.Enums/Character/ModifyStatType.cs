using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Bitmask indicating which character stats changed in a stat modification packet.
/// </summary>
[Flags]
public enum ModifyStatType : uint
{
    /// <summary>No flags set.</summary>
    None = 0,

    /// <summary>Skin color/type.</summary>
    Skin = 0x1,

    /// <summary>Face appearance.</summary>
    Face = 0x2,

    /// <summary>Hair style.</summary>
    Hair = 0x4,

    /// <summary>Active pet (slot 1).</summary>
    Pet = 0x8,

    /// <summary>Character level.</summary>
    Level = 0x10,

    /// <summary>Character job/class.</summary>
    Job = 0x20,

    /// <summary>Strength stat.</summary>
    Str = 0x40,

    /// <summary>Dexterity stat.</summary>
    Dex = 0x80,

    /// <summary>Intelligence stat.</summary>
    Int = 0x100,

    /// <summary>Luck stat.</summary>
    Luk = 0x200,

    /// <summary>Current hit points.</summary>
    Hp = 0x400,

    /// <summary>Maximum hit points.</summary>
    [Label("Max HP", 1)]
    MaxHp = 0x800,

    /// <summary>Current mana points.</summary>
    Mp = 0x1000,

    /// <summary>Maximum mana points.</summary>
    [Label("Max MP", 1)]
    MaxMp = 0x2000,

    /// <summary>Available ability points.</summary>
    Ap = 0x4000,

    /// <summary>Available skill points.</summary>
    Sp = 0x8000,

    /// <summary>Experience points.</summary>
    Exp = 0x10000,

    /// <summary>Popularity (fame).</summary>
    Pop = 0x20000,

    /// <summary>Mesos (currency).</summary>
    Money = 0x40000,

    /// <summary>Active pet (slot 2).</summary>
    [Label("Pet 2", 1)]
    Pet2 = 0x80000,

    /// <summary>Active pet (slot 3).</summary>
    [Label("Pet 3", 1)]
    Pet3 = 0x100000,

    /// <summary>Temporary EXP bonus.</summary>
    [Label("Temp EXP", 1)]
    TempExp = 0x200000,
}
