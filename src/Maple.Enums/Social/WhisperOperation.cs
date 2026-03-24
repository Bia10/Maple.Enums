using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Whisper message operation types.
/// </summary>
[Flags]
public enum WhisperOperation : byte
{
    /// <summary>Find player location.</summary>
    [Label("WP_Location")]
    Location = 0x1,

    /// <summary>Send whisper message.</summary>
    [Label("WP_Whisper")]
    Whisper = 0x2,

    /// <summary>Whisper request.</summary>
    [Label("WP_Request")]
    Request = 0x4,

    /// <summary>Whisper result.</summary>
    [Label("WP_Result")]
    Result = 0x8,

    /// <summary>Receive whisper.</summary>
    [Label("WP_Receive")]
    Receive = 0x10,

    /// <summary>Whisper blocked.</summary>
    [Label("WP_Blocked")]
    Blocked = 0x20,

    /// <summary>Find friend location.</summary>
    [Label("WP_Location_F")]
    [Label("Location Friend", 1)]
    LocationFriend = 0x40,

    /// <summary>GM whisper.</summary>
    [Label("WP_Manager")]
    Manager = 0x80,
}
