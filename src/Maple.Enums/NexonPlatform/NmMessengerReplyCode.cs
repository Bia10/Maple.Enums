using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Result code returned by the Nexon Messenger service.
/// Values 0 and 1 are success codes; negative values indicate errors.
/// </summary>
public enum NmMessengerReplyCode : int
{
    /// <summary>Operation succeeded.</summary>
    [Label("kMessengerReplyOK")]
    Ok = 0,

    /// <summary>New user created during login.</summary>
    [Label("kMessengerReplyNewUser")]
    NewUser = 1,

    /// <summary>Resource does not belong to this user.</summary>
    [Label("kMessengerReplyNotMine")]
    NotMine = -1,

    /// <summary>User ID is wrong.</summary>
    [Label("kMessengerReplyWrongId")]
    WrongId = -2,

    /// <summary>Password is wrong.</summary>
    [Label("kMessengerReplyWrongPwd")]
    WrongPassword = -3,

    /// <summary>Client version is incompatible.</summary>
    [Label("kMessengerReplyWrongClientVersion")]
    WrongClientVersion = -4,

    /// <summary>Message protocol version is incompatible.</summary>
    [Label("kMessengerReplyWrongMsgVersion")]
    WrongMsgVersion = -5,

    /// <summary>Service is being shut down.</summary>
    [Label("kMessengerReplyServiceShutdown")]
    ServiceShutdown = -6,

    /// <summary>Messenger is already locked by another process.</summary>
    [Label("kMessengerReplyLockedByAnotherProcess")]
    LockedByAnotherProcess = -7,

    /// <summary>Session must switch server authority (SA switch).</summary>
    [Label("kMessengerReplySwitchSA")]
    SwitchSa = -8,

    /// <summary>Account owner mismatch.</summary>
    [Label("kMessengerReplyWrongOwner")]
    WrongOwner = -9,

    /// <summary>Account is blocked by an administrator.</summary>
    [Label("kMessengerReplyBlockByAdmin")]
    BlockedByAdmin = -10,

    /// <summary>Account temporarily blocked due to a warning.</summary>
    [Label("kMessengerReplyTempBlockByWarning")]
    TempBlockedByWarning = -11,

    /// <summary>Account temporarily blocked due to repeated login failures.</summary>
    [Label("kMessengerReplyTempBlockByLoginFail")]
    TempBlockedByLoginFail = -12,

    /// <summary>Mabinogi info SOAP call failed.</summary>
    [Label("kMessengerReplyMabiInfoSoapFail")]
    MabiInfoSoapFailed = -13,

    /// <summary>Passport token is wrong.</summary>
    [Label("kMessengerReplyWrongPassport")]
    WrongPassport = -14,

    /// <summary>Client IP address is blocked.</summary>
    [Label("kMessengerReplyBlockedIp")]
    BlockedIp = -15,

    /// <summary>Temporary / guest user account.</summary>
    [Label("kMessengerReplyTempUser")]
    TempUser = -16,

    /// <summary>Session has not been authenticated.</summary>
    [Label("kMessengerReplyNotAuthenticated")]
    NotAuthenticated = -17,

    /// <summary>External passport type is not valid.</summary>
    [Label("kMessengerReplyInvalidExternalPassportType")]
    InvalidExternalPassportType = -18,

    /// <summary>Decoder for this external passport type is not implemented.</summary>
    [Label("kMessengerReplyExternalPassportDecoderNotImplemented")]
    ExternalPassportDecoderNotImplemented = -19,

    /// <summary>External passport decoding failed.</summary>
    [Label("kMessengerReplyExternalPassportDecodingFailed")]
    ExternalPassportDecodingFailed = -20,

    /// <summary>External passport value is wrong.</summary>
    [Label("kMessengerReplyWrongExternalPassport")]
    WrongExternalPassport = -21,

    /// <summary>Generic server failure.</summary>
    [Label("kMessengerReplyServerFailed")]
    ServerFailed = -99,
}
