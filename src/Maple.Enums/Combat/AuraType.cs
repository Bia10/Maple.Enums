using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Guild skill aura color type.
/// Used to select the visual effect shown around a player when a guild aura buff is active.
/// </summary>
public enum AuraType : byte
{
    /// <summary>All aura colors combined.</summary>
    [Label("AURA_ALL")]
    All = 0,

    /// <summary>Dark blue guild aura.</summary>
    [Label("AURA_DARK_BLUE")]
    [Label("Dark Blue", 1)]
    DarkBlue = 1,

    /// <summary>Dark yellow guild aura.</summary>
    [Label("AURA_DARK_YELLOW")]
    [Label("Dark Yellow", 1)]
    DarkYellow = 2,

    /// <summary>Blue-yellow guild aura.</summary>
    /// <remarks>Documented original client typo in typos.md.</remarks>
    [Label("AURA_BLUE_YELOW")]
    [Label("Blue Yellow", 1)]
    BlueYellow = 3,
}
