using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Online presence status of a Nexon Messenger user.
/// </summary>
public enum NmUserStatus : byte
{
    /// <summary>Status is unknown.</summary>
    [Label("kStatus_Unknown")]
    Unknown = 0,

    /// <summary>User is online.</summary>
    [Label("kStatus_Online")]
    Online = 10,

    /// <summary>User is busy.</summary>
    [Label("kStatus_Busy")]
    Busy = 11,

    /// <summary>User is away.</summary>
    [Label("kStatus_Away")]
    Away = 12,

    /// <summary>User appears offline but is connected.</summary>
    [Label("kStatus_AppearOffline")]
    AppearOffline = 13,

    /// <summary>User is offline.</summary>
    [Label("kStatus_Offline")]
    Offline = 14,

    /// <summary>User is online and in-game.</summary>
    [Label("kStatus_GameOnline")]
    GameOnline = 15,

    /// <summary>Status is in an error state.</summary>
    [Label("kStatus_Error")]
    Error = 16,

    /// <summary>User session has been authenticated.</summary>
    [Label("kStatus_Authenticated")]
    Authenticated = 17,
}
