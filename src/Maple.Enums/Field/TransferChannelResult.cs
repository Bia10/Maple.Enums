using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Channel transfer result codes.
/// </summary>
public enum TransferChannelResult : byte
{
    /// <summary>Channel switch succeeded.</summary>
    [Label("TC_DONE")]
    Done = 0,

    /// <summary>Game server unreachable.</summary>
    [Label("TC_GAMESVR_DISCONNECTED")]
    [Label("Game Server Disconnected", 1)]
    GameServerDisconnected = 1,

    /// <summary>Cash shop server unreachable.</summary>
    [Label("TC_SHOPSVR_DISCONNECTED")]
    [Label("Shop Server Disconnected", 1)]
    ShopServerDisconnected = 2,

    /// <summary>ITC server unreachable.</summary>
    [Label("TC_ITCSVR_DISCONNECTED")]
    [Label("Itc Server Disconnected", 1)]
    ItcServerDisconnected = 3,

    /// <summary>ITC server at capacity.</summary>
    [Label("TC_ITCSVR_OVERLIMITUSER")]
    [Label("Itc Server Over Limit User", 1)]
    ItcServerOverLimitUser = 4,

    /// <summary>Level too low for ITC.</summary>
    [Label("TC_ITCSVR_LOWLEVELUSER")]
    [Label("Itc Server Low Level User", 1)]
    ItcServerLowLevelUser = 5,
}
