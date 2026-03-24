using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Online connectivity status of a Nexon P2P peer.
/// </summary>
public enum NmP2PStatus : byte
{
    /// <summary>Peer status is unknown.</summary>
    [Label("kP2PStatus_Unknown")]
    Unknown = 0,

    /// <summary>Peer is online and reachable.</summary>
    [Label("kP2PStatus_Online")]
    Online = 10,

    /// <summary>Peer is offline.</summary>
    [Label("kP2PStatus_Offline")]
    Offline = 11,
}
