using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Rainbow Week event mode type.
/// </summary>
public enum RainbowWeekType : byte
{
    /// <summary>Boss monster mode.</summary>
    [Label("RAINBOWWEEK_BOSSMOB")]
    [Label("Boss Mob", 1)]
    BossMob = 0,

    /// <summary>Monster massacre mode.</summary>
    [Label("RAINBOWWEEK_MASSACRE")]
    Massacre = 1,

    /// <summary>Event inactive.</summary>
    [Label("RAINBOWWEEK_NO")]
    No = 2,
}
