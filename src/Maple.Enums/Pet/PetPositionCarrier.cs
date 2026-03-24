using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Pet position carrier types relative to the player.
/// </summary>
public enum PetPositionCarrier : byte
{
    /// <summary>Default pet position relative to owner.</summary>
    [Label("PPC_NORMAL")]
    Normal = 0,

    /// <summary>Pet positioned to the left of owner.</summary>
    [Label("PPC_LEFT")]
    Left = 1,

    /// <summary>Pet positioned to the right of owner.</summary>
    [Label("PPC_RIGHT")]
    Right = 2,

    /// <summary>Pet positioned far to the left of owner.</summary>
    [Label("PPC_FAR_LEFT")]
    [Label("Far Left", 1)]
    FarLeft = 3,

    /// <summary>Pet positioned far to the right of owner.</summary>
    [Label("PPC_FAR_RIGHT")]
    [Label("Far Right", 1)]
    FarRight = 4,

    /// <summary>Pet positioned close to owner, normal side.</summary>
    [Label("PPC_CLOSE_NORMAL")]
    [Label("Close Normal", 1)]
    CloseNormal = 5,
}
