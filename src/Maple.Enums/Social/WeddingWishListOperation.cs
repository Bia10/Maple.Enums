using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Wedding wish list operation codes.
/// </summary>
public enum WeddingWishListOperation : byte
{
    /// <summary>Load give wish list.</summary>
    [Label("WeddingWLReq_GiveLoad")]
    [Label("Req Give Load", 1)]
    ReqGiveLoad = 0,

    /// <summary>Save give wish list.</summary>
    [Label("WeddingWLReq_GiveSave")]
    [Label("Req Give Save", 1)]
    ReqGiveSave = 1,

    /// <summary>Close give wish list.</summary>
    [Label("WeddingWLReq_GiveClose")]
    [Label("Req Give Close", 1)]
    ReqGiveClose = 2,

    /// <summary>Load receive wish list.</summary>
    [Label("WeddingWLReq_RecvLoad")]
    [Label("Req Recv Load", 1)]
    ReqRecvLoad = 3,

    /// <summary>Save receive wish list.</summary>
    [Label("WeddingWLReq_RecvSave")]
    [Label("Req Recv Save", 1)]
    ReqRecvSave = 4,

    /// <summary>Close receive wish list.</summary>
    [Label("WeddingWLReq_RecvClose")]
    [Label("Req Recv Close", 1)]
    ReqRecvClose = 5,

    /// <summary>Add item to wish list.</summary>
    [Label("WeddingWLReq_PutItem")]
    [Label("Req Put Item", 1)]
    ReqPutItem = 6,

    /// <summary>Take item from wish list.</summary>
    [Label("WeddingWLReq_GetItem")]
    [Label("Req Get Item", 1)]
    ReqGetItem = 7,

    /// <summary>Close wish list dialog.</summary>
    [Label("WeddingWLReq_CloseDialog")]
    [Label("Req Close Dialog", 1)]
    ReqCloseDialog = 8,

    /// <summary>Open give wish list UI.</summary>
    [Label("WeddingWLRes_OpenGiveWishListDlg")]
    [Label("Res Open Give Wish List Dlg", 1)]
    ResOpenGiveWishListDlg = 9,

    /// <summary>Open receive wish list UI.</summary>
    [Label("WeddingWLRes_OpenRecvWishListDlg")]
    [Label("Res Open Recv Wish List Dlg", 1)]
    ResOpenRecvWishListDlg = 10,

    /// <summary>Item added successfully.</summary>
    [Label("WeddingWLRes_PutSuccess")]
    [Label("Res Put Success", 1)]
    ResPutSuccess = 11,

    /// <summary>Wish list is full.</summary>
    [Label("WeddingWLRes_PutNoSpace")]
    [Label("Res Put No Space", 1)]
    ResPutNoSpace = 12,

    /// <summary>Invalid add request.</summary>
    [Label("WeddingWLRes_PutIncorrectRequest")]
    [Label("Res Put Incorrect Request", 1)]
    ResPutIncorrectRequest = 13,

    /// <summary>Add failed (unknown).</summary>
    [Label("WeddingWLRes_PutUnknown")]
    [Label("Res Put Unknown", 1)]
    ResPutUnknown = 14,

    /// <summary>Item taken successfully.</summary>
    [Label("WeddingWLRes_GetSuccess")]
    [Label("Res Get Success", 1)]
    ResGetSuccess = 15,

    /// <summary>Take failed (unknown).</summary>
    [Label("WeddingWLRes_GetUnknown")]
    [Label("Res Get Unknown", 1)]
    ResGetUnknown = 16,

    /// <summary>Only one of item remains.</summary>
    [Label("WeddingWLRes_GetHavingOnlyItem")]
    [Label("Res Get Having Only Item", 1)]
    ResGetHavingOnlyItem = 17,
}
