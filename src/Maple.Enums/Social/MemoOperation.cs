using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// In-game memo operation codes.
/// </summary>
public enum MemoOperation : byte
{
    /// <summary>Request send memo.</summary>
    [Label("MemoReq_Send")]
    [Label("Req Send", 1)]
    ReqSend = 0,

    /// <summary>Request delete memo.</summary>
    [Label("MemoReq_Delete")]
    [Label("Req Delete", 1)]
    ReqDelete = 1,

    /// <summary>Request load memos.</summary>
    [Label("MemoReq_Load")]
    [Label("Req Load", 1)]
    ReqLoad = 2,

    /// <summary>Response load memos.</summary>
    [Label("MemoRes_Load")]
    [Label("Res Load", 1)]
    ResLoad = 3,

    /// <summary>Send succeeded.</summary>
    [Label("MemoRes_Send_Succeed")]
    [Label("Res Send Succeed", 1)]
    ResSendSucceed = 4,

    /// <summary>Send warning.</summary>
    [Label("MemoRes_Send_Warning")]
    [Label("Res Send Warning", 1)]
    ResSendWarning = 5,

    /// <summary>Confirm recipient online.</summary>
    [Label("MemoRes_Send_ConfirmOnline")]
    [Label("Res Send Confirm Online", 1)]
    ResSendConfirmOnline = 6,

    /// <summary>New memo notification.</summary>
    [Label("MemoNotify_Receive")]
    [Label("Notify Receive", 1)]
    NotifyReceive = 7,
}
