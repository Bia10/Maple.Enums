using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Mini room / trading room type.
/// Classifies interactive multiplayer room types in the game.
/// </summary>
public enum MiniRoomType : byte
{
    /// <summary>Omok (Go/Gomoku) board game.</summary>
    [Label("MR_OmokRoom")]
    [Label("Omok Room", 1)]
    OmokRoom = 1,

    /// <summary>Match cards memory game.</summary>
    [Label("MR_MemoryGameRoom")]
    [Label("Memory Game Room", 1)]
    MemoryGameRoom = 2,

    /// <summary>Player-to-player trade.</summary>
    [Label("MR_TradingRoom")]
    [Label("Trading Room", 1)]
    TradingRoom = 3,

    /// <summary>Player-owned shop.</summary>
    [Label("MR_PersonalShop")]
    [Label("Personal Shop", 1)]
    PersonalShop = 4,

    /// <summary>Hired merchant shop.</summary>
    [Label("MR_EntrustedShop")]
    [Label("Entrusted Shop", 1)]
    EntrustedShop = 5,

    /// <summary>Cash item trade room.</summary>
    [Label("MR_CashTradingRoom")]
    [Label("Cash Trading Room", 1)]
    CashTradingRoom = 6,
}
