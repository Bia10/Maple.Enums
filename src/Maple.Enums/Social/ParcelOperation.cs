using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// In-game parcel (mail) request/response operation codes.
/// </summary>
public enum ParcelOperation : byte
{
    /// <summary>Client request to open quick-receive window.</summary>
    [Label("ParcelReq_OpenQuickReceive")]
    [Label("Req Open Quick Receive", 1)]
    ReqOpenQuickReceive = 0,

    /// <summary>Client request to load parcel list.</summary>
    [Label("ParcelReq_Load")]
    [Label("Req Load", 1)]
    ReqLoad = 1,

    /// <summary>Client request to send a parcel.</summary>
    [Label("ParcelReq_Send")]
    [Label("Req Send", 1)]
    ReqSend = 2,

    /// <summary>Client request to confirm parcel send.</summary>
    [Label("ParcelReq_ConfirmSend")]
    [Label("Req Confirm Send", 1)]
    ReqConfirmSend = 3,

    /// <summary>Client request to receive a parcel.</summary>
    [Label("ParcelReq_Receive")]
    [Label("Req Receive", 1)]
    ReqReceive = 4,

    /// <summary>Client request to discard a parcel.</summary>
    [Label("ParcelReq_Discard")]
    [Label("Req Discard", 1)]
    ReqDiscard = 5,

    /// <summary>Client request to remove a parcel.</summary>
    [Label("ParcelReq_Remove")]
    [Label("Req Remove", 1)]
    ReqRemove = 6,

    /// <summary>Client request to close parcel window.</summary>
    [Label("ParcelReq_Close")]
    [Label("Req Close", 1)]
    ReqClose = 7,

    /// <summary>Server response: parcel list loaded.</summary>
    [Label("ParcelRes_Loaded")]
    [Label("Res Loaded", 1)]
    ResLoaded = 8,

    /// <summary>Server response: parcel sent successfully.</summary>
    [Label("ParcelRes_SendSuccess")]
    [Label("Res Send Success", 1)]
    ResSendSuccess = 9,

    /// <summary>Send error: insufficient mesos.</summary>
    [Label("ParcelRes_SendErr_NotEnoughMoney")]
    [Label("Res Send Err Not Enough Money", 1)]
    ResSendErrNotEnoughMoney = 10,

    /// <summary>Send error: incorrect request.</summary>
    [Label("ParcelRes_SendErr_IncorrectRequest")]
    [Label("Res Send Err Incorrect Request", 1)]
    ResSendErrIncorrectRequest = 11,

    /// <summary>Send error: target character not found.</summary>
    [Label("ParcelRes_SendErr_NoCharacter")]
    [Label("Res Send Err No Character", 1)]
    ResSendErrNoCharacter = 12,

    /// <summary>Send error: cannot send to same account.</summary>
    [Label("ParcelRes_SendErr_SameAccount")]
    [Label("Res Send Err Same Account", 1)]
    ResSendErrSameAccount = 13,

    /// <summary>Send error: recipient has no inventory space.</summary>
    [Label("ParcelRes_SendErr_NoSpaceToPeer")]
    [Label("Res Send Err No Space To Peer", 1)]
    ResSendErrNoSpaceToPeer = 14,

    /// <summary>Send error: target user cannot receive parcels.</summary>
    [Label("ParcelRes_SendErr_TargetUserCannotReceive")]
    [Label("Res Send Err Target User Cannot Receive", 1)]
    ResSendErrTargetUserCannotReceive = 15,

    /// <summary>Send error: target has only-item restriction.</summary>
    [Label("ParcelRes_SendErr_TargetHavingOnlyItem")]
    [Label("Res Send Err Target Having Only Item", 1)]
    ResSendErrTargetHavingOnlyItem = 16,

    /// <summary>Send error: meso limit exceeded.</summary>
    [Label("ParcelRes_SendErr_LimitMoney")]
    [Label("Res Send Err Limit Money", 1)]
    ResSendErrLimitMoney = 17,

    /// <summary>Server response: send confirmed successfully.</summary>
    [Label("ParcelRes_ConfirmSend_Success")]
    [Label("Res Confirm Send Success", 1)]
    ResConfirmSendSuccess = 18,

    /// <summary>Server response: send confirmation failed.</summary>
    [Label("ParcelRes_ConfirmSend_Failure")]
    [Label("Res Confirm Send Failure", 1)]
    ResConfirmSendFailure = 19,

    /// <summary>Server response: parcel received successfully.</summary>
    [Label("ParcelRes_ReceiveSuccess")]
    [Label("Res Receive Success", 1)]
    ResReceiveSuccess = 20,

    /// <summary>Receive error: no empty inventory slot.</summary>
    [Label("ParcelRes_ReceiveErr_NoEmptySlot")]
    [Label("Res Receive Err No Empty Slot", 1)]
    ResReceiveErrNoEmptySlot = 21,

    /// <summary>Receive error: only-item restriction.</summary>
    [Label("ParcelRes_ReceiveErr_HavingOnlyItem")]
    [Label("Res Receive Err Having Only Item", 1)]
    ResReceiveErrHavingOnlyItem = 22,

    /// <summary>Server response: parcel removed successfully.</summary>
    [Label("ParcelRes_RemoveSuccess")]
    [Label("Res Remove Success", 1)]
    ResRemoveSuccess = 23,

    /// <summary>Notification: a new parcel was sent.</summary>
    [Label("ParcelRes_NewParcelSent")]
    [Label("Res New Parcel Sent", 1)]
    ResNewParcelSent = 24,

    /// <summary>Notification: a new parcel was received.</summary>
    [Label("ParcelRes_ReceivedNewParcel")]
    [Label("Res Received New Parcel", 1)]
    ResReceivedNewParcel = 25,

    /// <summary>Server response: open quick-send window.</summary>
    [Label("ParcelRes_OpenQuickSend")]
    [Label("Res Open Quick Send", 1)]
    ResOpenQuickSend = 26,

    /// <summary>Server response: delayed parcel notification.</summary>
    [Label("ParcelRes_DelayedNotify")]
    [Label("Res Delayed Notify", 1)]
    ResDelayedNotify = 27,

    /// <summary>Server response: unknown error occurred.</summary>
    [Label("ParcelRes_UnknownError")]
    [Label("Res Unknown Error", 1)]
    ResUnknownError = 28,

    /// <summary>Server response: parcel has expired.</summary>
    [Label("ParcelRes_Expired")]
    [Label("Res Expired", 1)]
    ResExpired = 29,

    /// <summary>Server message response.</summary>
    [Label("ParcelRes_ServerMsg")]
    [Label("Res Server Msg", 1)]
    ResServerMsg = 30,
}
