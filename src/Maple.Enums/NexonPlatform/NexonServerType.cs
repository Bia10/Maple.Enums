using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Role of a Nexon Platform server node.
/// </summary>
public enum NexonServerType : byte
{
    /// <summary>Server role is undefined.</summary>
    [Label("UNDEFINED_SERVER")]
    Undefined = 0,

    /// <summary>Login server.</summary>
    [Label("LOGIN_SERVER")]
    Login = 1,

    /// <summary>Session management server.</summary>
    [Label("SESSION_SERVER")]
    Session = 2,

    /// <summary>Statistics/tracking server.</summary>
    [Label("STAT_SERVER")]
    Stat = 3,

    /// <summary>Gateway / proxy server.</summary>
    [Label("GATEWAY_SERVER")]
    Gateway = 4,

    /// <summary>Application server.</summary>
    [Label("APP_SERVER")]
    App = 5,

    /// <summary>Channel server.</summary>
    [Label("CHANNEL_SERVER")]
    Channel = 6,

    /// <summary>Relay server.</summary>
    [Label("RELAY_SERVER")]
    Relay = 7,

    /// <summary>Authentication server.</summary>
    [Label("AUTH_SERVER")]
    Auth = 16,
}
