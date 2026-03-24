using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Mini room / trade room / personal shop leave reason codes.
/// </summary>
public enum MiniRoomLeaveType : byte
{
    /// <summary>Player voluntarily left.</summary>
    [Label("MRLeave_UserRequest")]
    [Label("User Request", 1)]
    UserRequest = 0,

    /// <summary>Player in an invalid position.</summary>
    [Label("MRLeave_WrongPosition")]
    [Label("Wrong Position", 1)]
    WrongPosition = 1,

    /// <summary>Room was closed by the host.</summary>
    [Label("MRLeave_Closed")]
    Closed = 2,

    /// <summary>Host left the room.</summary>
    [Label("MRLeave_HostOut")]
    [Label("Host Out", 1)]
    HostOut = 3,

    /// <summary>Room slot was reserved.</summary>
    [Label("MRLeave_Booked")]
    Booked = 4,

    /// <summary>Player was kicked from the room.</summary>
    [Label("MRLeave_Kicked")]
    Kicked = 5,

    /// <summary>Room open time limit exceeded.</summary>
    [Label("MRLeave_OpenTimeOver")]
    [Label("Open Time Over", 1)]
    OpenTimeOver = 6,

    /// <summary>Trade completed successfully.</summary>
    [Label("TRLeave_TradeDone")]
    [Label("Trade Done", 1)]
    TradeDone = 7,

    /// <summary>Trade failed.</summary>
    [Label("TRLeave_TradeFail")]
    [Label("Trade Fail", 1)]
    TradeFail = 8,

    /// <summary>Trade failed; items only returned.</summary>
    [Label("TRLeave_TradeFail_OnlyItem")]
    [Label("Trade Fail Only Item", 1)]
    TradeFailOnlyItem = 9,

    /// <summary>Trade failed due to expiration.</summary>
    [Label("TRLeave_TradeFail_Expired")]
    [Label("Trade Fail Expired", 1)]
    TradeFailExpired = 10,

    /// <summary>Trade denied by the other party.</summary>
    [Label("TRLeave_TradeFail_Denied")]
    [Label("Trade Fail Denied", 1)]
    TradeFailDenied = 11,

    /// <summary>Trade failed due to field error.</summary>
    [Label("TRLeave_FieldError")]
    [Label("Trade Field Error", 1)]
    TradeFieldError = 12,

    /// <summary>Trade item integrity check failed.</summary>
    [Label("TRLeave_ItemCRCFailed")]
    [Label("Trade Item CRC Failed", 1)]
    TradeItemCRCFailed = 13,

    /// <summary>Personal shop has no more items.</summary>
    [Label("PSLeave_NoMoreItem")]
    [Label("Personal Shop No More Item", 1)]
    PersonalShopNoMoreItem = 14,

    /// <summary>Kicked from personal shop after time limit.</summary>
    [Label("PSLeave_KickedTimeOver")]
    [Label("Personal Shop Kicked Time Over", 1)]
    PersonalShopKickedTimeOver = 15,

    /// <summary>Entrusted shop opened for business.</summary>
    [Label("ESLeave_Open")]
    [Label("Entrusted Shop Open", 1)]
    EntrustedShopOpen = 16,

    /// <summary>Owner started managing the entrusted shop.</summary>
    [Label("ESLeave_StartManage")]
    [Label("Entrusted Shop Start Manage", 1)]
    EntrustedShopStartManage = 17,

    /// <summary>Entrusted shop closed after time limit.</summary>
    [Label("ESLeave_ClosedTimeOver")]
    [Label("Entrusted Shop Closed Time Over", 1)]
    EntrustedShopClosedTimeOver = 18,

    /// <summary>Owner stopped managing the entrusted shop.</summary>
    [Label("ESLeave_EndManage")]
    [Label("Entrusted Shop End Manage", 1)]
    EntrustedShopEndManage = 19,

    /// <summary>Entrusted shop destroyed by a GM.</summary>
    /// <remarks>Documented original client typo in typos.md.</remarks>
    [Label("ESLeave_DestoryByAdmin")]
    [Label("Entrusted Shop Destroy By Admin", 1)]
    EntrustedShopDestroyByAdmin = 20,

    /// <summary>Player voluntarily left the mini-game.</summary>
    [Label("MGLeave_UserRequest")]
    [Label("Mini Game User Request", 1)]
    MiniGameUserRequest = 21,
}
