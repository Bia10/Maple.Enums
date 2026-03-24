using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Mini-game (Omok / Memory Game etc.) event notification codes sent via MrpGameMessage.
/// </summary>
public enum MiniGameEvent : byte
{
    /// <summary>Player banned from the mini-game.</summary>
    [Label("MiniGame_UserBan")]
    [Label("User Ban", 1)]
    UserBan = 0,

    /// <summary>Notify which player's turn it is.</summary>
    [Label("MiniGame_UserTurn")]
    [Label("User Turn", 1)]
    UserTurn = 1,

    /// <summary>Player forfeits the game.</summary>
    [Label("MiniGame_UserGiveUp")]
    [Label("User Give Up", 1)]
    UserGiveUp = 2,

    /// <summary>Player successfully retreated from the game.</summary>
    [Label("MiniGame_UserRetreatSuccess")]
    [Label("User Retreat Success", 1)]
    UserRetreatSuccess = 3,

    /// <summary>Player leaves the mini-game room.</summary>
    [Label("MiniGame_UserLeave")]
    [Label("User Leave", 1)]
    UserLeave = 4,

    /// <summary>Player leaves during an active game.</summary>
    [Label("MiniGame_UserLeaveEngage")]
    [Label("User Leave Engage", 1)]
    UserLeaveEngage = 5,

    /// <summary>Cancel of leave during an active game.</summary>
    [Label("MiniGame_UserLeaveEngageCancel")]
    [Label("User Leave Engage Cancel", 1)]
    UserLeaveEngageCancel = 6,

    /// <summary>Player enters the mini-game room.</summary>
    [Label("MiniGame_UserEnter")]
    [Label("User Enter", 1)]
    UserEnter = 7,

    /// <summary>Player lacks sufficient mesos to play.</summary>
    [Label("MiniGame_UserNotEnoughMoney")]
    [Label("User Not Enough Money", 1)]
    UserNotEnoughMoney = 8,

    /// <summary>Player matched a pair of cards.</summary>
    [Label("MiniGame_UserMatchCard")]
    [Label("User Match Card", 1)]
    UserMatchCard = 9,

    // 0xA–0x64 reserved/unused in V95.

    /// <summary>Ten-second turn timer warning.</summary>
    [Label("MiniGame_10SecAlert")]
    Alert10Sec = 101,

    /// <summary>Mini-game round has started.</summary>
    [Label("MiniGame_GameStart")]
    [Label("Game Start", 1)]
    GameStart = 102,

    /// <summary>Tournament match has ended.</summary>
    [Label("MiniGame_TournamentMatchEnd")]
    [Label("Tournament Match End", 1)]
    TournamentMatchEnd = 103,
}
