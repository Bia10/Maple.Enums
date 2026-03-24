using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Bitmask indicating which forced stat overrides to apply to equipment.
/// </summary>
[Flags]
public enum ModifyStatForcedType : ushort
{
    /// <summary>No flags set.</summary>
    None = 0,

    /// <summary>Forced STR (strength) override.</summary>
    STR = 0x1,

    /// <summary>Forced DEX (dexterity) override.</summary>
    DEX = 0x2,

    /// <summary>Forced INT (intelligence) override.</summary>
    INT = 0x4,

    /// <summary>Forced LUK (luck) override.</summary>
    LUK = 0x8,

    /// <summary>Forced physical attack power override.</summary>
    PAD = 0x10,

    /// <summary>Forced physical defense override.</summary>
    PDD = 0x20,

    /// <summary>Forced magic attack power override.</summary>
    MAD = 0x40,

    /// <summary>Forced magic defense override.</summary>
    MDD = 0x80,

    /// <summary>Forced accuracy override.</summary>
    ACC = 0x100,

    /// <summary>Forced evasion/avoidability override.</summary>
    EVA = 0x200,

    /// <summary>Forced movement speed override.</summary>
    Speed = 0x400,

    /// <summary>Forced jump power override.</summary>
    Jump = 0x800,

    /// <summary>Forced maximum movement speed override.</summary>
    [Label("Speed Max", 1)]
    SpeedMax = 0x1000,
}
