using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Messenger (2-/3-person chat room) operation types.
/// </summary>
public enum MessengerOperation : byte
{
    /// <summary>Request to enter a messenger room.</summary>
    [Label("MSMP_Enter")]
    Enter = 0,

    /// <summary>Result of own enter request.</summary>
    [Label("MSMP_SelfEnterResult")]
    [Label("Self Enter Result", 1)]
    SelfEnterResult = 1,

    /// <summary>Leave the messenger room.</summary>
    [Label("MSMP_Leave")]
    Leave = 2,

    /// <summary>Invite another player to the messenger.</summary>
    [Label("MSMP_Invite")]
    Invite = 3,

    /// <summary>Result of an invitation attempt.</summary>
    [Label("MSMP_InviteResult")]
    [Label("Invite Result", 1)]
    InviteResult = 4,

    /// <summary>Invitation blocked by recipient.</summary>
    [Label("MSMP_Blocked")]
    Blocked = 5,

    /// <summary>Send or receive a chat message.</summary>
    [Label("MSMP_Chat")]
    Chat = 6,

    /// <summary>Update player avatar display.</summary>
    [Label("MSMP_Avatar")]
    Avatar = 7,

    /// <summary>Player migrated to another channel.</summary>
    [Label("MSMP_Migrated")]
    Migrated = 8,
}
