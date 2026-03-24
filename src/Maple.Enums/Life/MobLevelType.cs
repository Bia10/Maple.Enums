using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Mob difficulty/level category.
/// </summary>
public enum MobLevelType : byte
{
    /// <summary>Normal difficulty mob.</summary>
    [Label("MOB_LEVEL_NORMAL")]
    Normal = 0,

    /// <summary>Easy difficulty mob.</summary>
    [Label("MOB_LEVEL_EASY")]
    Easy = 1,

    /// <summary>Hard difficulty mob.</summary>
    [Label("MOB_LEVEL_HARD")]
    Hard = 2,
}
