using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Chat target type.
/// Specifies the audience/channel for chat messages.
/// </summary>
public enum ChatTargetType : byte
{
    /// <summary>Direct friend message.</summary>
    [Label("ID_CHAT_TARGET_FRIEND")]
    Friend = 0,

    /// <summary>Friend group message.</summary>
    [Label("ID_CHAT_TARGET_FRIEND_GROUP")]
    [Label("Friend Group", 1)]
    FriendGroup = 1,

    /// <summary>Party chat.</summary>
    [Label("ID_CHAT_TARGET_PARTY")]
    Party = 2,

    /// <summary>Expedition chat.</summary>
    [Label("ID_CHAT_TARGET_EXPEDITION")]
    Expedition = 3,

    /// <summary>Guild chat.</summary>
    [Label("ID_CHAT_TARGET_GUILD")]
    Guild = 4,

    /// <summary>Alliance chat.</summary>
    [Label("ID_CHAT_TARGET_ALLIANCE")]
    Alliance = 5,

    /// <summary>Couple chat.</summary>
    [Label("ID_CHAT_TARGET_COUPLE")]
    Couple = 6,

    /// <summary>Private whisper.</summary>
    [Label("ID_CHAT_TARGET_WHISPER")]
    Whisper = 7,

    /// <summary>Broadcast to all.</summary>
    [Label("ID_CHAT_TARGET_ALL")]
    All = 8,
}
