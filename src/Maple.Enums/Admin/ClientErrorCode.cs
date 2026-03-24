using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Client-side error codes for disconnect and fatal error conditions.
/// </summary>
public enum ClientErrorCode : uint
{
    /// <summary>Patch required.</summary>
    [Label("EC_PATCH")]
    Patch = 536870912,

    /// <summary>Disconnect range start.</summary>
    [Label("EC_DISCONNECT_BEGIN")]
    [Label("Disconnect Begin", 1)]
    DisconnectBegin = 553648128,

    /// <summary>Game server connection failed.</summary>
    [Label("EC_CONNECT_TO_GAME_FAILED")]
    [Label("Connect To Game Failed", 1)]
    ConnectToGameFailed = 553648129,

    /// <summary>Game server connection closed.</summary>
    [Label("EC_CONNECTION_FROM_GAME_CLOSED")]
    [Label("Connection From Game Closed", 1)]
    ConnectionFromGameClosed = 553648130,

    /// <summary>Protocol error with game server.</summary>
    [Label("EC_FAILED_PROTOCOL_WITH_GAME")]
    [Label("Failed Protocol With Game", 1)]
    FailedProtocolWithGame = 553648131,

    /// <summary>Forcibly disconnected.</summary>
    [Label("EC_FORCE_DISCONNECT")]
    [Label("Force Disconnect", 1)]
    ForceDisconnect = 553648132,

    /// <summary>Malicious process detected.</summary>
    [Label("EC_DISCONNECT_BY_MALICIOUS_PROCESS")]
    [Label("Disconnect By Malicious Process", 1)]
    DisconnectByMaliciousProcess = 553648133,

    /// <summary>Disconnect range end.</summary>
    [Label("EC_DISCONNECT_END")]
    [Label("Disconnect End", 1)]
    DisconnectEnd = 553648134,

    /// <summary>Terminate range start.</summary>
    [Label("EC_TERMINATE_BEGIN")]
    [Label("Terminate Begin", 1)]
    TerminateBegin = 570425344,

    /// <summary>Login server connection failed.</summary>
    [Label("EC_CONNECT_TO_LOGIN_FAILED")]
    [Label("Connect To Login Failed", 1)]
    ConnectToLoginFailed = 570425345,

    /// <summary>Login server connection closed.</summary>
    [Label("EC_CONNECTION_FROM_LOGIN_CLOSED")]
    [Label("Connection From Login Closed", 1)]
    ConnectionFromLoginClosed = 570425346,

    /// <summary>Out of memory.</summary>
    [Label("EC_NOT_ENOUGH_MEMORY")]
    [Label("Not Enough Memory", 1)]
    NotEnoughMemory = 570425347,

    /// <summary>Missing data package.</summary>
    [Label("EC_NO_DATA_PACKAGE")]
    [Label("No Data Package", 1)]
    NoDataPackage = 570425348,

    /// <summary>Data version mismatch.</summary>
    [Label("EC_INVALID_GAME_DATA_VERSION")]
    [Label("Invalid Game Data Version", 1)]
    InvalidGameDataVersion = 570425349,

    /// <summary>Corrupt game data.</summary>
    [Label("EC_INVALID_GAME_DATA")]
    [Label("Invalid Game Data", 1)]
    InvalidGameData = 570425350,

    /// <summary>Client version mismatch.</summary>
    [Label("EC_INVALID_CLIENT_VERSION")]
    [Label("Invalid Client Version", 1)]
    InvalidClientVersion = 570425351,

    /// <summary>Critical protocol failure.</summary>
    [Label("EC_FAILED_CRITICAL_PROTOCOL_WITH_GAME")]
    [Label("Failed Critical Protocol With Game", 1)]
    FailedCriticalProtocolWithGame = 570425352,

    /// <summary>Web login required.</summary>
    [Label("EC_WEB_LOGIN_NEEDED")]
    [Label("Web Login Needed", 1)]
    WebLoginNeeded = 570425353,

    /// <summary>Client CRC check failed.</summary>
    [Label("EC_CLIENTCRC_FAILED")]
    [Label("Client Crc Failed", 1)]
    ClientCrcFailed = 570425354,

    /// <summary>Full client download needed.</summary>
    [Label("EC_DOWNLOAD_FULL_CLIENT")]
    [Label("Download Full Client", 1)]
    DownloadFullClient = 570425355,

    /// <summary>Locale setting failed.</summary>
    [Label("EC_AUTH_SETLOCALE_FAILED")]
    [Label("Auth Set Locale Failed", 1)]
    AuthSetLocaleFailed = 570425356,

    /// <summary>COM initialization failed.</summary>
    [Label("EC_AUTH_COINIT_FAILED")]
    [Label("Auth Co Init Failed", 1)]
    AuthCoInitFailed = 570425357,

    /// <summary>Terminate range end.</summary>
    [Label("EC_TERMINATE_END")]
    [Label("Terminate End", 1)]
    TerminateEnd = 570425358,
}
