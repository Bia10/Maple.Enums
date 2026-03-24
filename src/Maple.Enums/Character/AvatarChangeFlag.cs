using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Avatar speed / appearance change flags used when updating other clients.
/// </summary>
[Flags]
public enum AvatarChangeFlag : byte
{
    /// <summary>No flags set.</summary>
    None = 0,

    /// <summary>Appearance changed.</summary>
    [Label("AVATAR_LOOK")]
    Look = 0x1,

    /// <summary>Speed changed.</summary>
    [Label("AVATAR_SPEED")]
    Speed = 0x2,

    /// <summary>Choco mount flag.</summary>
    [Label("AVATAR_CHOCO")]
    Choco = 0x4,
}
