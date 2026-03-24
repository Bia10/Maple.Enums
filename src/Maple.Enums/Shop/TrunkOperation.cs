using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Trunk (storage) request/response operation codes.
/// </summary>
public enum TrunkOperation : byte
{
    /// <summary>Load stored items.</summary>
    [Label("TrunkReq_Load")]
    [Label("Req Load", 1)]
    ReqLoad = 0,

    /// <summary>Save items to storage.</summary>
    [Label("TrunkReq_Save")]
    [Label("Req Save", 1)]
    ReqSave = 1,

    /// <summary>Close storage session.</summary>
    [Label("TrunkReq_Close")]
    [Label("Req Close", 1)]
    ReqClose = 2,

    /// <summary>Verify storage PIN.</summary>
    [Label("TrunkReq_CheckSSN2")]
    [Label("Req Check SSN2", 1)]
    ReqCheckSSN2 = 3,

    /// <summary>Withdraw item from storage.</summary>
    [Label("TrunkReq_GetItem")]
    [Label("Req Get Item", 1)]
    ReqGetItem = 4,

    /// <summary>Deposit item to storage.</summary>
    [Label("TrunkReq_PutItem")]
    [Label("Req Put Item", 1)]
    ReqPutItem = 5,

    /// <summary>Sort stored items.</summary>
    [Label("TrunkReq_SortItem")]
    [Label("Req Sort Item", 1)]
    ReqSortItem = 6,

    /// <summary>Deposit or withdraw meso.</summary>
    [Label("TrunkReq_Money")]
    [Label("Req Money", 1)]
    ReqMoney = 7,

    /// <summary>Close storage dialog.</summary>
    [Label("TrunkReq_CloseDialog")]
    [Label("Req Close Dialog", 1)]
    ReqCloseDialog = 8,

    /// <summary>Withdraw succeeded.</summary>
    [Label("TrunkRes_GetSuccess")]
    [Label("Res Get Success", 1)]
    ResGetSuccess = 9,

    /// <summary>Withdraw failed (unknown).</summary>
    [Label("TrunkRes_GetUnknown")]
    [Label("Res Get Unknown", 1)]
    ResGetUnknown = 10,

    /// <summary>Withdraw failed, not enough meso.</summary>
    [Label("TrunkRes_GetNoMoney")]
    [Label("Res Get No Money", 1)]
    ResGetNoMoney = 11,

    /// <summary>Only one of item remains.</summary>
    /// <remarks>Documented original client typo in typos.md.</remarks>
    [Label("TruncRes_GetHavingOnlyItem")]
    [Label("Res Get Having Only Item", 1)]
    ResGetHavingOnlyItem = 12,

    /// <summary>Deposit succeeded.</summary>
    [Label("TrunkRes_PutSuccess")]
    [Label("Res Put Success", 1)]
    ResPutSuccess = 13,

    /// <summary>Deposit request invalid.</summary>
    [Label("TrunkRes_PutIncorrectRequest")]
    [Label("Res Put Incorrect Request", 1)]
    ResPutIncorrectRequest = 14,

    /// <summary>Sort completed.</summary>
    [Label("TrunkRes_SortItem")]
    [Label("Res Sort Item", 1)]
    ResSortItem = 15,

    /// <summary>Deposit failed, not enough meso.</summary>
    [Label("TrunkRes_PutNoMoney")]
    [Label("Res Put No Money", 1)]
    ResPutNoMoney = 16,

    /// <summary>Storage is full.</summary>
    [Label("TrunkRes_PutNoSpace")]
    [Label("Res Put No Space", 1)]
    ResPutNoSpace = 17,

    /// <summary>Deposit failed (unknown).</summary>
    [Label("TrunkRes_PutUnknown")]
    [Label("Res Put Unknown", 1)]
    ResPutUnknown = 18,

    /// <summary>Meso transfer succeeded.</summary>
    [Label("TrunkRes_MoneySuccess")]
    [Label("Res Money Success", 1)]
    ResMoneySuccess = 19,

    /// <summary>Meso transfer failed (unknown).</summary>
    [Label("TrunkRes_MoneyUnknown")]
    [Label("Res Money Unknown", 1)]
    ResMoneyUnknown = 20,

    /// <summary>PIN verification result.</summary>
    [Label("TrunkRes_TrunkCheckSSN2")]
    [Label("Res Check SSN2", 1)]
    ResCheckSSN2 = 21,

    /// <summary>Open storage UI.</summary>
    [Label("TrunkRes_OpenTrunkDlg")]
    [Label("Res Open Trunk Dialog", 1)]
    ResOpenTrunkDialog = 22,

    /// <summary>Trade-blocked item.</summary>
    [Label("TrunkRes_TradeBlocked")]
    [Label("Res Trade Blocked", 1)]
    ResTradeBlocked = 23,

    /// <summary>Server message response.</summary>
    [Label("TrunkRes_ServerMsg")]
    [Label("Res Server Msg", 1)]
    ResServerMsg = 24,
}
