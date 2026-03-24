using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// GM / admin permission level (Level 1–5 and the super-level 10).
/// </summary>
public enum AdminLevel : int
{
    /// <summary>Lowest GM tier.</summary>
    [Label("ADMIN_LEVEL_1")]
    Level1 = 0,

    /// <summary>Basic GM commands.</summary>
    [Label("ADMIN_LEVEL_2")]
    Level2 = 1,

    /// <summary>Mid-tier GM access.</summary>
    [Label("ADMIN_LEVEL_3")]
    Level3 = 2,

    /// <summary>Senior GM access.</summary>
    [Label("ADMIN_LEVEL_4")]
    Level4 = 3,

    /// <summary>Lead GM access.</summary>
    [Label("ADMIN_LEVEL_5")]
    Level5 = 4,

    /// <summary>Super admin / developer.</summary>
    [Label("ADMIN_LEVEL_10")]
    Level10 = 5,
}
