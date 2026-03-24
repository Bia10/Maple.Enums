using FastEnumUtility;

namespace Maple.Enums;

/// <summary>
/// Gold hammer upgrade result codes.
/// </summary>
public enum GoldHammerResult : byte
{
    /// <summary>Hammer succeeded.</summary>
    [Label("GoldHammerRes_Success")]
    Success = 0,

    /// <summary>Hammer failed.</summary>
    [Label("GoldHammerRes_Fail")]
    Fail = 1,

    /// <summary>Hammer already applied.</summary>
    [Label("GoldHammerRes_Done")]
    Done = 2,

    /// <summary>Invalid hammer use.</summary>
    [Label("GoldHammerRes_Err")]
    Error = 3,
}
