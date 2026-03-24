using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// MapleTV broadcast result codes.
/// </summary>
public enum MapleTvResultCode : int
{
    /// <summary>Broadcast failed.</summary>
    [Label("MapleTVResCode_Fail")]
    Fail = -1,

    /// <summary>Broadcast succeeded.</summary>
    [Label("MapleTVResCode_Success")]
    Success = 0,

    /// <summary>Not a GM account.</summary>
    [Label("MapleTVResCode_IsNotGM")]
    [Label("Is Not Gm", 1)]
    IsNotGm = 1,

    /// <summary>Invalid target user.</summary>
    [Label("MapleTVResCode_WrongUser")]
    [Label("Wrong User", 1)]
    WrongUser = 2,

    /// <summary>Broadcast timed out.</summary>
    [Label("MapleTVResCode_TimeOut")]
    Timeout = 3,
}
