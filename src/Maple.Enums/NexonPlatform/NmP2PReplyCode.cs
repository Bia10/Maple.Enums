using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Reply code returned by the Nexon P2P service.
/// </summary>
public enum NmP2PReplyCode : int
{
    /// <summary>Operation succeeded.</summary>
    [Label("kP2PReply_OK")]
    Ok = 0,

    /// <summary>Generic server failure.</summary>
    [Label("kP2PReply_ServerFailed")]
    ServerFailed = -1,

    /// <summary>Failed to create relay object.</summary>
    [Label("kP2PReply_CreateRelayObjectFail")]
    CreateRelayObjectFailed = -2,

    /// <summary>Session is not authenticated.</summary>
    [Label("kP2PReply_NotAuthenticated")]
    NotAuthenticated = -3,

    /// <summary>Resource does not belong to this user.</summary>
    [Label("kP2PReply_NotMine")]
    NotMine = -4,
}
