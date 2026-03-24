using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Map transfer (Maple Guide teleport) operation codes.
/// </summary>
public enum MapTransferOperation : byte
{
    /// <summary>Request delete transfer list.</summary>
    [Label("MapTransferReq_DeleteList")]
    [Label("Req Delete List", 1)]
    ReqDeleteList = 0,

    /// <summary>Request register transfer list.</summary>
    [Label("MapTransferReq_RegisterList")]
    [Label("Req Register List", 1)]
    ReqRegisterList = 1,

    /// <summary>Response delete list.</summary>
    [Label("MapTransferRes_DeleteList")]
    [Label("Res Delete List", 1)]
    ResDeleteList = 2,

    /// <summary>Response register list.</summary>
    [Label("MapTransferRes_RegisterList")]
    [Label("Res Register List", 1)]
    ResRegisterList = 3,

    /// <summary>Response use transfer.</summary>
    [Label("MapTransferRes_Use")]
    [Label("Res Use", 1)]
    ResUse = 4,

    /// <summary>Unknown response.</summary>
    [Label("MapTransferRes_Unknown")]
    [Label("Res Unknown", 1)]
    ResUnknown = 5,

    /// <summary>Target does not exist.</summary>
    [Label("MapTransferRes_TargetNotExist")]
    [Label("Res Target Not Exist", 1)]
    ResTargetNotExist = 6,

    /// <summary>Target has died.</summary>
    [Label("MapTransferRes_TargetDied")]
    [Label("Res Target Died", 1)]
    ResTargetDied = 7,

    /// <summary>Transfer not allowed.</summary>
    [Label("MapTransferRes_NotAllowed")]
    [Label("Res Not Allowed", 1)]
    ResNotAllowed = 8,

    /// <summary>Already in target map.</summary>
    [Label("MapTransferRes_AlreadyInMap")]
    [Label("Res Already In Map", 1)]
    ResAlreadyInMap = 9,

    /// <summary>Registration failed.</summary>
    [Label("MapTransferRes_RegisterFail")]
    [Label("Res Register Fail", 1)]
    ResRegisterFail = 10,

    /// <summary>Level requirement not met.</summary>
    [Label("MapTransferRes_LevelLimit")]
    [Label("Res Level Limit", 1)]
    ResLevelLimit = 11,
}
