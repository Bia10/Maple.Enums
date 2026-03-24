using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Forced stat override flags used to lock character stats to specific values.
/// </summary>
[Flags]
public enum ForcedStatFlag : ushort
{
    /// <summary>No flags set (auto-assign stats).</summary>
    [Label("AUTO")]
    None = 0x0,

    /// <summary>Override STR.</summary>
    [Label("STR")]
    Str = 0x1,

    /// <summary>Override DEX.</summary>
    [Label("DEX")]
    Dex = 0x2,

    /// <summary>Override INT.</summary>
    [Label("INT")]
    Int = 0x4,

    /// <summary>Override LUK.</summary>
    [Label("LUK")]
    Luk = 0x8,

    /// <summary>Override physical attack.</summary>
    [Label("PAD")]
    Pad = 0x10,

    /// <summary>Override physical defense.</summary>
    [Label("PDD")]
    Pdd = 0x20,

    /// <summary>Override magic attack.</summary>
    [Label("MAD")]
    Mad = 0x40,

    /// <summary>Override magic defense.</summary>
    [Label("MDD")]
    Mdd = 0x80,

    /// <summary>Override accuracy.</summary>
    [Label("ACC")]
    Acc = 0x100,

    /// <summary>Override evasion.</summary>
    [Label("EVA")]
    Eva = 0x200,

    /// <summary>Override movement speed.</summary>
    [Label("SPEED")]
    Speed = 0x400,

    /// <summary>Override jump.</summary>
    [Label("JUMP")]
    Jump = 0x800,

    /// <summary>Override max speed.</summary>
    [Label("SPEEDMAX")]
    SpeedMax = 0x1000,

    /// <summary>All flags combined.</summary>
    [Label("ALL")]
    All = 0x1FFF,
}
