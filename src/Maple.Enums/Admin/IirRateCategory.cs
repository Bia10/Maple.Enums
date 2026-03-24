using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Item/experience rate category (normal vs. premium membership), used for rate-log buckets.
/// </summary>
public enum IirRateCategory : byte
{
    /// <summary>Normal drop rate.</summary>
    [Label("IIR_Drop_Normal")]
    [Label("Drop Normal", 1)]
    DropNormal = 0,

    /// <summary>Premium drop rate.</summary>
    [Label("IIR_Drop_Premium")]
    [Label("Drop Premium", 1)]
    DropPremium = 1,

    /// <summary>Normal EXP rate.</summary>
    [Label("IIR_Exp_Normal")]
    [Label("Exp Normal", 1)]
    ExpNormal = 2,

    /// <summary>Premium EXP rate.</summary>
    [Label("IIR_Exp_Premium")]
    [Label("Exp Premium", 1)]
    ExpPremium = 3,
}
