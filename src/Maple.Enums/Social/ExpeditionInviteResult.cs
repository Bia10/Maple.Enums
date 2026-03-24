using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Expedition invite/join result codes.
/// </summary>
public enum ExpeditionInviteResult : byte
{
    /// <summary>Target user invalid.</summary>
    [Label("ExpeditionInviteResult_InvalidUser")]
    [Label("Invalid User", 1)]
    InvalidUser = 0,

    /// <summary>Target is a GM.</summary>
    [Label("ExpeditionInviteResult_Admin")]
    Admin = 1,

    /// <summary>Target already in party.</summary>
    [Label("ExpeditionInviteResult_InParty")]
    [Label("In Party", 1)]
    InParty = 2,

    /// <summary>Target outside level range.</summary>
    [Label("ExpeditionInviteResult_OutOfLevelRange")]
    [Label("Out Of Level Range", 1)]
    OutOfLevelRange = 3,

    /// <summary>Target is blocked.</summary>
    [Label("ExpeditionInviteResult_BlockedUser")]
    [Label("Blocked User", 1)]
    BlockedUser = 4,

    /// <summary>Target already invited.</summary>
    [Label("ExpeditionInviteResult_AlreadyInvited")]
    [Label("Already Invited", 1)]
    AlreadyInvited = 5,

    /// <summary>Already invited by this user.</summary>
    [Label("ExpeditionInviteResult_AlreadyInvitedbyInviter")]
    [Label("Already Invited By Inviter", 1)]
    AlreadyInvitedByInviter = 6,

    /// <summary>Invitation sent.</summary>
    [Label("ExpeditionInviteResult_Sent")]
    Sent = 7,

    /// <summary>Invitation accepted.</summary>
    [Label("ExpeditionInviteResult_Accept")]
    Accept = 8,

    /// <summary>Invitation rejected.</summary>
    [Label("ExpeditionInviteResult_Reject")]
    Reject = 9,

    /// <summary>Successfully joined.</summary>
    [Label("ExpeditionJoinResult_Success")]
    [Label("Join Success", 1)]
    JoinSuccess = 10,

    /// <summary>Expedition is full.</summary>
    [Label("ExpeditionJoinResult_Full")]
    [Label("Join Full", 1)]
    JoinFull = 11,

    /// <summary>Expedition does not exist.</summary>
    [Label("ExpeditionJoinResult_NotExist")]
    [Label("Join Not Exist", 1)]
    JoinNotExist = 12,
}
