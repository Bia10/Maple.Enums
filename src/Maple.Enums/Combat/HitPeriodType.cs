using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Recurring damage hit period category (poison ticks, stun, etc.).
/// </summary>
public enum HitPeriodType : int
{
    /// <summary>No hit period.</summary>
    [Label("HitPeriod_None")]
    None = -1,

    /// <summary>Standard hit interval.</summary>
    [Label("HitPeriod_Basic")]
    Basic = 0,

    /// <summary>Poison tick interval.</summary>
    [Label("HitPeriod_Poison")]
    Poison = 1,

    /// <summary>Area damage interval.</summary>
    [Label("HitPeriod_Areal")]
    Areal = 2,

    /// <summary>Stun period.</summary>
    [Label("HitPeriod_StopMotion")]
    [Label("Stop Motion", 1)]
    StopMotion = 3,

    /// <summary>Sentinel count.</summary>
    [Label("HitPeriod_No")]
    No = 4,
}
