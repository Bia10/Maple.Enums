using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Mini room (trade/shop) invite result codes.
/// </summary>
public enum MiniRoomInviteResult : byte
{
    /// <summary>Invitation sent successfully.</summary>
    [Label("MRInvite_Success")]
    Success = 0,

    /// <summary>Target character not found.</summary>
    [Label("MRInvite_NoCharacter")]
    [Label("No Character", 1)]
    NoCharacter = 1,

    /// <summary>Target cannot receive invitations.</summary>
    [Label("MRInvite_CannotInvite")]
    [Label("Cannot Invite", 1)]
    CannotInvite = 2,

    /// <summary>Invitation was rejected.</summary>
    [Label("MRInvite_Rejected")]
    Rejected = 3,

    /// <summary>Invitation blocked by target.</summary>
    [Label("MRInvite_Blocked")]
    Blocked = 4,
}
