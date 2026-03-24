using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Direction used when a mob attracts (pulls) or pushes a character.
/// </summary>
public enum MobAttractDirection : byte
{
    /// <summary>Pull character to the left.</summary>
    [Label("ATTRACT_DIRECTION_LEFT")]
    Left = 1,

    /// <summary>Pull character to the right.</summary>
    [Label("ATTRACT_DIRECTION_RIGHT")]
    Right = 2,

    /// <summary>Pull character upward.</summary>
    [Label("ATTRACT_DIRECTION_UP")]
    Up = 3,

    /// <summary>Pull character downward.</summary>
    [Label("ATTRACT_DIRECTION_DOWN")]
    Down = 4,

    /// <summary>Hold character in place.</summary>
    [Label("ATTRACT_DIRECTION_STAND")]
    Stand = 5,

    /// <summary>Force character to jump left.</summary>
    [Label("ATTRACT_DIRECTION_LEFT_JUMP")]
    [Label("Left Jump", 1)]
    LeftJump = 6,

    /// <summary>Force character to jump right.</summary>
    [Label("ATTRACT_DIRECTION_RIGHT_JUMP")]
    [Label("Right Jump", 1)]
    RightJump = 7,
}
