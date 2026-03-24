using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Rock-paper-scissors mini-game protocol operations.
/// </summary>
public enum RockPaperScissorsOperation : byte
{
    /// <summary>Client starts game.</summary>
    [Label("RPSReq_StartGame")]
    [Label("Req Start Game", 1)]
    ReqStartGame = 0,

    /// <summary>Client sends choice.</summary>
    [Label("RPSReq_UserSelection")]
    [Label("Req User Selection", 1)]
    ReqUserSelection = 1,

    /// <summary>Client time expired.</summary>
    [Label("RPSReq_TimeOver")]
    [Label("Req Time Over", 1)]
    ReqTimeOver = 2,

    /// <summary>Client continues game.</summary>
    [Label("RPSReq_Continue")]
    [Label("Req Continue", 1)]
    ReqContinue = 3,

    /// <summary>Client quits game.</summary>
    [Label("RPSReq_Quit")]
    [Label("Req Quit", 1)]
    ReqQuit = 4,

    /// <summary>Client retries round.</summary>
    [Label("RPSReq_Retry")]
    [Label("Req Retry", 1)]
    ReqRetry = 5,

    /// <summary>Insufficient meso error.</summary>
    [Label("RPSRes_NotEnoughMoney")]
    [Label("Res Not Enough Money", 1)]
    ResNotEnoughMoney = 6,

    /// <summary>No inventory space.</summary>
    [Label("RPSRes_NoEmptySlotForReward")]
    [Label("Res No Empty Slot For Reward", 1)]
    ResNoEmptySlotForReward = 7,

    /// <summary>Open game window.</summary>
    [Label("RPSRes_Open")]
    [Label("Res Open", 1)]
    ResOpen = 8,

    /// <summary>Server starts game.</summary>
    [Label("RPSRes_StartGame")]
    [Label("Res Start Game", 1)]
    ResStartGame = 9,

    /// <summary>Server time expired.</summary>
    [Label("RPSRes_TimeOver")]
    [Label("Res Time Over", 1)]
    ResTimeOver = 10,

    /// <summary>NPC choice revealed.</summary>
    [Label("RPSRes_NpcSelection")]
    [Label("Res Npc Selection", 1)]
    ResNpcSelection = 11,

    /// <summary>Server continue response.</summary>
    /// <remarks>Documented original client typo in typos.md.</remarks>
    [Label("RPSRes_Coninue")]
    [Label("Res Continue", 1)]
    ResContinue = 12,

    /// <summary>Server quit response.</summary>
    [Label("RPSRes_Quit")]
    [Label("Res Quit", 1)]
    ResQuit = 13,

    /// <summary>Server retry response.</summary>
    [Label("RPSRes_Retry")]
    [Label("Res Retry", 1)]
    ResRetry = 14,
}
