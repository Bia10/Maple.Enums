using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Mini room enter result codes.
/// </summary>
public enum MiniRoomEnterResult : byte
{
    /// <summary>Successfully entered the room.</summary>
    [Label("MREnterResult_Success")]
    Success = 0,

    /// <summary>Room does not exist.</summary>
    [Label("MREnterResult_NoRoom")]
    [Label("No Room", 1)]
    NoRoom = 1,

    /// <summary>Room is full.</summary>
    [Label("MREnterResult_Full")]
    Full = 2,

    /// <summary>Target player is busy.</summary>
    [Label("MREnterResult_Busy")]
    Busy = 3,

    /// <summary>Player is dead and cannot enter.</summary>
    [Label("MREnterResult_Dead")]
    Dead = 4,

    /// <summary>Blocked by an active event.</summary>
    [Label("MREnterResult_Event")]
    Event = 5,

    /// <summary>Insufficient permissions to enter.</summary>
    [Label("MREnterResult_PermissionDenied")]
    [Label("Permission Denied", 1)]
    PermissionDenied = 6,

    /// <summary>Trading is not allowed.</summary>
    [Label("MREnterResult_NoTrading")]
    [Label("No Trading", 1)]
    NoTrading = 7,

    /// <summary>Unspecified error.</summary>
    [Label("MREnterResult_Etc")]
    Etc = 8,

    /// <summary>Must be on the same map.</summary>
    [Label("MREnterResult_OnlyInSameField")]
    [Label("Only In Same Field", 1)]
    OnlyInSameField = 9,

    /// <summary>Too close to a portal.</summary>
    [Label("MREnterResult_NearPortal")]
    [Label("Near Portal", 1)]
    NearPortal = 10,

    /// <summary>Room creation limit exceeded.</summary>
    [Label("MREnterResult_CreateCountOver")]
    [Label("Create Count Over", 1)]
    CreateCountOver = 11,

    /// <summary>Room creation limit per IP exceeded.</summary>
    [Label("MREnterResult_CreateIPCountOver")]
    [Label("Create IP Count Over", 1)]
    CreateIPCountOver = 12,

    /// <summary>Player already has a mini-room open.</summary>
    [Label("MREnterResult_ExistMiniRoom")]
    [Label("Exist Mini Room", 1)]
    ExistMiniRoom = 13,

    /// <summary>Field does not allow game rooms.</summary>
    [Label("MREnterResult_NotAvailableField_Game")]
    [Label("Not Available Field Game", 1)]
    NotAvailableFieldGame = 14,

    /// <summary>Field does not allow personal shops.</summary>
    [Label("MREnterResult_NotAvailableField_PersonalShop")]
    [Label("Not Available Field Personal Shop", 1)]
    NotAvailableFieldPersonalShop = 15,

    /// <summary>Field does not allow entrusted shops.</summary>
    [Label("MREnterResult_NotAvailableField_EntrustedShop")]
    [Label("Not Available Field Entrusted Shop", 1)]
    NotAvailableFieldEntrustedShop = 16,

    /// <summary>Player is on the block list.</summary>
    [Label("MREnterResult_OnBlockedList")]
    [Label("On Blocked List", 1)]
    OnBlockedList = 17,

    /// <summary>Owner is currently managing the shop.</summary>
    [Label("MREnterResult_IsManaging")]
    [Label("Is Managing", 1)]
    IsManaging = 18,

    /// <summary>Cannot enter during a tournament.</summary>
    [Label("MGEnterResult_Tournament")]
    [Label("Mini Game Tournament", 1)]
    MiniGameTournament = 19,

    /// <summary>Player is already in a game.</summary>
    [Label("MGEnterResult_AlreadyPlaying")]
    [Label("Mini Game Already Playing", 1)]
    MiniGameAlreadyPlaying = 20,

    /// <summary>Not enough mesos to enter the game.</summary>
    [Label("MGEnterResult_NotEnoughMoney")]
    [Label("Mini Game Not Enough Money", 1)]
    MiniGameNotEnoughMoney = 21,

    /// <summary>Incorrect room password.</summary>
    [Label("MGEnterResult_InvalidPassword")]
    [Label("Mini Game Invalid Password", 1)]
    MiniGameInvalidPassword = 22,

    /// <summary>Field does not allow shop scanners.</summary>
    [Label("MREnterResult_NotAvailableField_ShopScanner")]
    [Label("Not Available Field Shop Scanner", 1)]
    NotAvailableFieldShopScanner = 23,

    /// <summary>Room has expired.</summary>
    [Label("MREnterResult_Expired")]
    Expired = 24,

    /// <summary>Action attempted too quickly.</summary>
    [Label("MREnterResult_TooShortTimeInterval")]
    [Label("Too Short Time Interval", 1)]
    TooShortTimeInterval = 25,
}
