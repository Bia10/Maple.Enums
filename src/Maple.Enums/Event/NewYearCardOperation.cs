using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// New Year card operation codes.
/// </summary>
public enum NewYearCardOperation : byte
{
    /// <summary>Client request to send a New Year card.</summary>
    [Label("NewYearCardReq_Send")]
    [Label("Req Send", 1)]
    ReqSend = 0,

    /// <summary>Client request to receive a New Year card.</summary>
    [Label("NewYearCardReq_Receive")]
    [Label("Req Receive", 1)]
    ReqReceive = 1,

    /// <summary>Client request to delete a New Year card.</summary>
    [Label("NewYearCardReq_Delete")]
    [Label("Req Delete", 1)]
    ReqDelete = 2,

    /// <summary>Client request to get list of unreceived cards.</summary>
    [Label("NewYearCardReq_GetUnreceivedList")]
    [Label("Req Get Unreceived List", 1)]
    ReqGetUnreceivedList = 3,

    /// <summary>Server response: card sent successfully.</summary>
    [Label("NewYearCardRes_Send_Done")]
    [Label("Res Send Done", 1)]
    ResSendDone = 4,

    /// <summary>Server response: card send failed.</summary>
    [Label("NewYearCardRes_Send_Failed")]
    [Label("Res Send Failed", 1)]
    ResSendFailed = 5,

    /// <summary>Server response: card received successfully.</summary>
    [Label("NewYearCardRes_Receive_Done")]
    [Label("Res Receive Done", 1)]
    ResReceiveDone = 6,

    /// <summary>Server response: card receive failed.</summary>
    [Label("NewYearCardRes_Receive_Failed")]
    [Label("Res Receive Failed", 1)]
    ResReceiveFailed = 7,

    /// <summary>Server response: card deleted successfully.</summary>
    [Label("NewYearCardRes_Delete_Done")]
    [Label("Res Delete Done", 1)]
    ResDeleteDone = 8,

    /// <summary>Server response: card delete failed.</summary>
    [Label("NewYearCardRes_Delete_Failed")]
    [Label("Res Delete Failed", 1)]
    ResDeleteFailed = 9,

    /// <summary>Server response: unreceived list retrieved successfully.</summary>
    [Label("NewYearCardRes_GetUnreceivedList_Done")]
    [Label("Res Get Unreceived List Done", 1)]
    ResGetUnreceivedListDone = 10,

    /// <summary>Server response: unreceived list retrieval failed.</summary>
    [Label("NewYearCardRes_GetUnreceivedList_Failed")]
    [Label("Res Get Unreceived List Failed", 1)]
    ResGetUnreceivedListFailed = 11,

    /// <summary>Server notification: a new card has arrived.</summary>
    [Label("NewYearCardRes_NotiArrived")]
    [Label("Res Noti Arrived", 1)]
    ResNotiArrived = 12,

    /// <summary>Broadcast notification: card info added.</summary>
    [Label("NewYearCardRes_BroadCast_AddCardInfo")]
    [Label("Res Broad Cast Add Card Info", 1)]
    ResBroadCastAddCardInfo = 13,

    /// <summary>Broadcast notification: card info removed.</summary>
    [Label("NewYearCardRes_BroadCast_RemoveCardInfo")]
    [Label("Res Broad Cast Remove Card Info", 1)]
    ResBroadCastRemoveCardInfo = 14,

    /// <summary>Failure: cannot send a card to yourself.</summary>
    [Label("NewYearCardFailReason_CannotSendToSelf")]
    [Label("Fail Cannot Send To Self", 1)]
    FailCannotSendToSelf = 15,

    /// <summary>Failure: no free inventory slot available.</summary>
    [Label("NewYearCardFailReason_NoFreeSlot")]
    [Label("Fail No Free Slot", 1)]
    FailNoFreeSlot = 16,

    /// <summary>Failure: item is not a valid New Year card.</summary>
    [Label("NewYearCardFailReason_NotANewYearCard")]
    [Label("Fail Not A New Year Card", 1)]
    FailNotANewYearCard = 17,

    /// <summary>Failure: item data is incoherent.</summary>
    [Label("NewYearCardFailReason_IncoherentItem")]
    [Label("Fail Incoherent Item", 1)]
    FailIncoherentItem = 18,

    /// <summary>Failure: target character does not exist.</summary>
    [Label("NewYearCardFailReason_TargetNotExist")]
    [Label("Fail Target Not Exist", 1)]
    FailTargetNotExist = 19,

    /// <summary>Failure: request data is incoherent.</summary>
    [Label("NewYearCardFailReason_IncoherentData")]
    [Label("Fail Incoherent Data", 1)]
    FailIncoherentData = 20,

    /// <summary>Failure: database error occurred.</summary>
    [Label("NewYearCardFailReason_DBError")]
    [Label("Fail Db Error", 1)]
    FailDbError = 21,

    /// <summary>Failure: unknown error occurred.</summary>
    [Label("NewYearCardFailReason_UnknownError")]
    [Label("Fail Unknown Error", 1)]
    FailUnknownError = 22,
}
