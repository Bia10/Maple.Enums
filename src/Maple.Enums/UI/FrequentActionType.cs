using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Anti-macro system: type of frequent action the client reportedly performed.
/// </summary>
public enum FrequentActionType : byte
{
    /// <summary>Opened a shop.</summary>
    [Label("FREQUENT_ACTION_CREATE_SHOP")]
    [Label("Create Shop", 1)]
    CreateShop = 0,

    /// <summary>Requested party quest.</summary>
    [Label("FREQUENT_ACTION_REQUEST_PQ")]
    [Label("Request Pq", 1)]
    RequestPq = 1,

    /// <summary>Used HP recovery.</summary>
    [Label("FREQUENT_ACTION_REQUEST_HP_RECOVERY")]
    [Label("Request Hp Recovery", 1)]
    RequestHpRecovery = 2,

    /// <summary>Used MP recovery.</summary>
    [Label("FREQUENT_ACTION_REQUEST_MP_RECOVERY")]
    [Label("Request Mp Recovery", 1)]
    RequestMpRecovery = 3,

    /// <summary>Sentinel / count.</summary>
    [Label("FREQUENT_ACTION_NO")]
    No = 4,
}
