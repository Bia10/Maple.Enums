using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Potential stat type indices for equipment potential lines.
/// </summary>
public enum PotentialStatType : byte
{
    /// <summary>Increase physical attack (PAD).</summary>
    [Label("incPAD")]
    IncPad = 0,

    /// <summary>Increase magic attack (MAD).</summary>
    [Label("incMAD")]
    IncMad = 1,

    /// <summary>Increase accuracy.</summary>
    [Label("incACC")]
    IncAcc = 2,

    /// <summary>Increase evasion.</summary>
    [Label("incEVA")]
    IncEva = 3,

    /// <summary>Increase movement speed.</summary>
    [Label("incSpeed")]
    IncSpeed = 4,

    /// <summary>Increase jump power.</summary>
    [Label("incJump")]
    IncJump = 5,

    /// <summary>Increase maximum HP.</summary>
    [Label("incMaxHP")]
    IncMaxHp = 6,

    /// <summary>Increase maximum MP.</summary>
    [Label("incMaxMP")]
    IncMaxMp = 7,

    /// <summary>Increase STR stat.</summary>
    [Label("incSTR")]
    IncStr = 8,

    /// <summary>Increase INT stat.</summary>
    [Label("incINT")]
    IncInt = 9,

    /// <summary>Increase LUK stat.</summary>
    [Label("incLUK")]
    IncLuk = 10,

    /// <summary>Increase DEX stat.</summary>
    [Label("incDEX")]
    IncDex = 11,

    /// <summary>Modify required level.</summary>
    [Label("incReqLevel")]
    IncReqLevel = 12,

    /// <summary>Random option from a pool.</summary>
    [Label("randOption")]
    RandOption = 13,

    /// <summary>Random stat modifier.</summary>
    [Label("randStat")]
    RandStat = 14,
}
