using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Error code returned by Nexon P2P operations.
/// </summary>
public enum NmP2PErrorCode : int
{
    /// <summary>No error.</summary>
    [Label("kP2PError_OK")]
    Ok = 0,

    /// <summary>P2P subsystem is already initialised.</summary>
    [Label("kP2PError_AlreadyInitialized")]
    AlreadyInitialized = 1,

    /// <summary>Generic failure.</summary>
    [Label("kP2PError_Failed")]
    Failed = -1,

    /// <summary>User is not logged in.</summary>
    [Label("kP2PError_NotLoggedIn")]
    NotLoggedIn = -2,

    /// <summary>P2P subsystem has not been initialised.</summary>
    [Label("kP2PError_NotInitialized")]
    NotInitialized = -3,

    /// <summary>Connection handle is invalid.</summary>
    [Label("kP2PError_InvalidConnection")]
    InvalidConnection = -4,

    /// <summary>Server info provided is invalid.</summary>
    [Label("kP2PError_InvalidServerInfo")]
    InvalidServerInfo = -5,

    /// <summary>Internal error in P2P subsystem.</summary>
    [Label("kP2PError_InternalError")]
    InternalError = -6,

    /// <summary>Peer is not online.</summary>
    [Label("kP2PError_NotOnline")]
    NotOnline = -7,

    /// <summary>Target peer does not exist.</summary>
    [Label("kP2PError_NotExists")]
    NotExists = -8,

    /// <summary>Sender identity mismatch.</summary>
    [Label("kP2PError_SenderMismatch")]
    SenderMismatch = -9,

    /// <summary>Receiver identity mismatch.</summary>
    [Label("kP2PError_ReceiverMismatch")]
    ReceiverMismatch = -10,
}
