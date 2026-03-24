using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Leave result codes (channel/server disconnect reasons).
/// </summary>
public enum LeaveResult : byte
{
    /// <summary>No leave reason.</summary>
    [Label("LR_None")]
    None = 0,

    /// <summary>Left to game server.</summary>
    [Label("LR_GameSvr")]
    [Label("Game Server", 1)]
    GameServer = 1,

    /// <summary>Left to Cash Shop.</summary>
    [Label("LR_ShopSvr")]
    [Label("Shop Server", 1)]
    ShopServer = 2,

    /// <summary>Changed channel.</summary>
    [Label("LR_OtherChannel")]
    [Label("Other Channel", 1)]
    OtherChannel = 3,

    /// <summary>Disconnected by admin.</summary>
    [Label("LR_Admin")]
    Admin = 4,
}
