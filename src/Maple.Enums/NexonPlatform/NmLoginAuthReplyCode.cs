using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Login authentication result code returned by the Nexon Platform.
/// </summary>
public enum NmLoginAuthReplyCode : int
{
    /// <summary>Authentication succeeded.</summary>
    [Label("kLoginAuth_OK")]
    Ok = 0,

    /// <summary>Server-side failure.</summary>
    [Label("kLoginAuth_ServerFailed")]
    ServerFailed = 20000,

    /// <summary>Service is being shut down.</summary>
    [Label("kLoginAuth_ServiceShutdown")]
    ServiceShutdown = 20002,

    /// <summary>Locale is not permitted to log in.</summary>
    [Label("kLoginAuth_NotAllowedLocale")]
    NotAllowedLocale = 20003,

    /// <summary>Account ID is wrong or does not exist.</summary>
    [Label("kLoginAuth_WrongID")]
    WrongId = 20006,

    /// <summary>Client IP address is blocked.</summary>
    [Label("kLoginAuth_BlockedIP")]
    BlockedIp = 20007,

    /// <summary>Account temporarily blocked due to repeated login failures.</summary>
    [Label("kLoginAuth_TempBlockedByLoginFail")]
    TempBlockedByLoginFail = 20008,

    /// <summary>Account temporarily blocked due to a warning.</summary>
    [Label("kLoginAuth_TempBlockedByWarning")]
    TempBlockedByWarning = 20009,

    /// <summary>Account is blocked by an administrator.</summary>
    [Label("kLoginAuth_BlockedByAdmin")]
    BlockedByAdmin = 20010,

    /// <summary>Passport token is invalid.</summary>
    [Label("kLoginAuth_InvalidPassport")]
    InvalidPassport = 20015,

    /// <summary>Server does not allow this account.</summary>
    [Label("kLoginAuth_NotAllowedServer")]
    NotAllowedServer = 20021,

    /// <summary>User account does not exist.</summary>
    [Label("kLoginAuth_UserNotExists")]
    UserNotExists = 20025,

    /// <summary>Password is incorrect.</summary>
    [Label("kLoginAuth_WrongPassword")]
    WrongPassword = 20026,

    /// <summary>Account has been withdrawn / deleted.</summary>
    [Label("kLoginAuth_WithdrawnUser")]
    WithdrawnUser = 20027,

    /// <summary>Wrong account owner.</summary>
    [Label("kLoginAuth_WrongOwner")]
    WrongOwner = 20028,

    /// <summary>Game server is under inspection/maintenance.</summary>
    [Label("kLoginAuth_GameServerInspection")]
    GameServerInspection = 20030,

    /// <summary>Temporary user login is blocked.</summary>
    [Label("kLoginAuth_TempUserLoginBlocked")]
    TempUserLoginBlocked = 20031,

    /// <summary>Matrix card login is required.</summary>
    [Label("kLoginAuth_NeedMatrixLogin")]
    NeedMatrixLogin = 20032,

    /// <summary>Matrix card data is wrong.</summary>
    [Label("kLoginAuth_WrongMatrixData")]
    WrongMatrixData = 20033,

    /// <summary>Account has been deactivated.</summary>
    [Label("kLoginAuth_DeactivatedAccount")]
    DeactivatedAccount = 20036,

    /// <summary>Auth module has not been initialised.</summary>
    [Label("kLoginAuth_ModuleNotInitialized")]
    ModuleNotInitialized = 30002,

    /// <summary>Auth module failed to initialise.</summary>
    [Label("kLoginAuth_ModuleInitializeFailed")]
    ModuleInitializeFailed = 30003,
}
