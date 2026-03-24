using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Skin color index as stored in Character.wz and character appearance data.
/// Values 6–8 are unused in V95 and omitted.
/// </summary>
public enum SkinColor : byte
{
    /// <summary>Light skin tone.</summary>
    Light = 0,

    /// <summary>Tanned skin tone.</summary>
    Tanned = 1,

    /// <summary>Dark skin tone.</summary>
    Dark = 2,

    /// <summary>Pale skin tone.</summary>
    Pale = 3,

    /// <summary>Ghost-white skin tone.</summary>
    [Label("Ghost White", 1)]
    GhostWhite = 4,

    /// <summary>Green skin tone.</summary>
    Green = 5,

    // Values 6–8 are unused in V95.

    /// <summary>Custom skin color 9.</summary>
    [Label("Custom 9", 1)]
    Custom9 = 9,

    /// <summary>Custom skin color 10.</summary>
    [Label("Custom 10", 1)]
    Custom10 = 10,

    /// <summary>Custom skin color 11.</summary>
    [Label("Custom 11", 1)]
    Custom11 = 11,
}
