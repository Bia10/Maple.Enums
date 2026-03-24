using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Cash item gachapon machine states.
/// </summary>
public enum CashItemGachaponState : byte
{
    /// <summary>Idle state.</summary>
    [Label("CASHITEMGACHAPON_NORMAL")]
    Normal = 0,

    /// <summary>Opening gachapon UI.</summary>
    [Label("CASHITEMGACHAPON_OPEN_REQUEST")]
    [Label("Open Request", 1)]
    OpenRequest = 1,

    /// <summary>Requesting item draw.</summary>
    [Label("CASHITEMGACHAPON_GET_REQUEST")]
    [Label("Get Request", 1)]
    GetRequest = 2,

    /// <summary>Item drawn successfully.</summary>
    [Label("CASHITEMGACHAPON_GET_SUCCESS")]
    [Label("Get Success", 1)]
    GetSuccess = 3,

    /// <summary>Item draw failed.</summary>
    [Label("CASHITEMGACHAPON_GET_FAIL")]
    [Label("Get Fail", 1)]
    GetFail = 4,
}
